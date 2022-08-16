using AutoMapper;
using Dreamland.Application.Interfaces.Posts;
using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.Post;
using Dreamland.Domain.ViewModels.Posts;
using Dreamland.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Services.Posts
{
    public class PostServices : IPostServices
    {
        private readonly IPostData _postData;
        private readonly IMapper _mapper;
        public PostServices(IPostData postData,
            IMapper mapper)
        {
            _postData = postData;
            _mapper = mapper;
        }
        public async Task<List<PostItemListViewModel>> GetPostList(PostSubCategories postSubCategories)
        {
            var query = await _postData.GetPostItemsAsync(postSubCategories);
            var result = query.OrderByDescending(x => x.CreatedAt).Take(6).ToList();
            return _mapper.Map<List<PostItem>, List<PostItemListViewModel>>(result);
        }
        public async Task<PostItemViewModel> GetPostByIdAsync(Guid id)
        {
            foreach (var item in Enum.GetValues(typeof(PostSubCategories)))
            {
                var query = await _postData.GetPostItemsAsync((PostSubCategories)Enum.Parse(typeof(PostSubCategories), item.ToString()));
                var result = query.Where(x => x.Id == id).FirstOrDefault();
                if(result!=null)
                {
                    result.RelatePosts = new List<PostItem>();
                    if (query.Where(x => x.CreatedAt < result.CreatedAt).Count() > 0)
                        result.RelatePosts.Add(query.Where(x => x.CreatedAt < result.CreatedAt).OrderByDescending(x => x.CreatedAt).FirstOrDefault());
                    else
                        result.RelatePosts.Add(query.OrderBy(x => x.CreatedAt).FirstOrDefault());
                    var pivotDate = result.CreatedAt;
                    for (int i = 0; i < 2; i++)
                    {
                        var test = query.Where(x => x.CreatedAt > pivotDate).Count();
                        if (query.Where(x => x.CreatedAt > pivotDate).Count() > 0)
                            result.RelatePosts.Add(query.Where(x => x.CreatedAt > pivotDate && x.Id != result.Id).OrderBy(x => x.CreatedAt).FirstOrDefault());
                        else
                            result.RelatePosts.Add(query.Where(x => x.CreatedAt < pivotDate && x.Id != result.Id).OrderBy(x => x.CreatedAt).FirstOrDefault());
                        pivotDate = result.RelatePosts.Last().CreatedAt;
                    }
                    return _mapper.Map<PostItem, PostItemViewModel>(result);
                }
            }
            throw new Exception("Not found item in database");
        }
    }
}

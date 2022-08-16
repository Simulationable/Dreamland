using Dreamland.Domain.Enums;
using Dreamland.Domain.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Interfaces.Posts
{
    public interface IPostServices
    {
        public Task<List<PostItemListViewModel>> GetPostList(PostSubCategories postSubCategories);
        public Task<PostItemViewModel> GetPostByIdAsync(Guid id);
    }
}

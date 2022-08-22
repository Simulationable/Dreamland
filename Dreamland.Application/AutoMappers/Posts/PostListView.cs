using AutoMapper;
using Dreamland.Application.Helper.Cryptography;
using Dreamland.Domain.Models.Post;
using Dreamland.Domain.ViewModels.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.AutoMappers.Posts
{
    public class PostListView : Profile
    {
        public PostListView()
        {
            CreateMap<PostItem, PostItemListViewModel>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => AES.Encrypt(src.Id.ToString())))
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name))
                .ForMember(dest => dest.PostCategories, options => options.MapFrom(src => src.FormatPostCategories()))
                .ForMember(dest => dest.PostSubCategories, options => options.MapFrom(src => src.FormatPostSubCategories()))
                .ForMember(dest => dest.TitleImage, options => options.MapFrom(src => src.TitleImage.Contains("https:") ? src.TitleImage : "https://localhost:44309/" + src.TitleImage))
                .ForMember(dest => dest.Description, options => options.MapFrom(src => src.Description));
        }
    }
}

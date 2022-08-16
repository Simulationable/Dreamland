using AutoMapper;
using Dreamland.Application.Helper.HttpContext;
using Dreamland.Domain.Models.Post;
using Dreamland.Domain.ViewModels.Posts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.AutoMappers.Posts
{
    public class PostView : Profile
    {
        public PostView()
        {
            CreateMap<PostItem, PostItemViewModel>()
                .ForMember(dest => dest.Name, options => options.MapFrom(src => src.Name))
                .ForMember(dest => dest.Category, options => options.MapFrom(src => src.FormatPostCategories() + " - " + src.FormatPostSubCategories()))
                .ForMember(dest => dest.Date, options => options.MapFrom(src => src.GetFullDate()))
                .ForMember(dest => dest.TitleImage, options => options.MapFrom(src => HttpContextHelper.MapUrl() + src.TitleImage))
                .ForMember(dest => dest.Content, options => options.MapFrom(src => src.Content));
        }
    }
}

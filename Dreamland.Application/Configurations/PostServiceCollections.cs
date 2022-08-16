using Dreamland.Application.Interfaces.Posts;
using Dreamland.Application.Services.Posts;
using Dreamland.Infrastructure.Data.Interfaces;
using Dreamland.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Configurations
{
    public static class PostServiceCollections
    {
        public static void AddPostScopeCollection(this IServiceCollection service)
        {
            service.AddScoped<IPostData, PostData>();
            service.AddScoped<IPostServices, PostServices>();
        }
    }
}

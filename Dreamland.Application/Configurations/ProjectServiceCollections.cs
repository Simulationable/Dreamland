using Dreamland.Application.Interfaces.Projects;
using Dreamland.Application.Services.Projects;
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
    public static class ProjectServiceCollections
    {
        public static void AddProjectScopeCollection(this IServiceCollection service)
        {
            service.AddScoped<IProjectData, ProjectData>();
            service.AddScoped<IProjectServices, ProjectServices>();
        }
    }
}

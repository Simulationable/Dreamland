using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Services.MasterData;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Configurations
{
    public static class MasterDataServiceCollections
    {
        public static void AddMasterDataScopeCollection(this IServiceCollection service)
        {
            service.AddScoped<IMasterDataServices, MasterDataServices>();
        }
    }
}

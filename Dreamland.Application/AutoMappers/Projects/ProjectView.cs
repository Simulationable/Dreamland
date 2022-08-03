using AutoMapper;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.ViewModels.MasterData;
using Dreamland.Domain.ViewModels.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.AutoMappers.MasterData
{
    public class ProjectView : Profile
    {
        public ProjectView ()
        {
            CreateMap<ProjectList, ProjectItemListViewModel>()
                .AfterMap((s,d) => d.Price = s.IsSoldOut ? "Sold Out" : "ราคาเริ่มต้น " + s.Price + " ล้านบาท");
        }
    }
}

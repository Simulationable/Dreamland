using AutoMapper;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.ViewModels.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.AutoMappers.MasterData
{
    public class ProjectListView : Profile
    {
        public ProjectListView ()
        {
            CreateMap<ProjectList, ProjectListViewModel>()
                .AfterMap((s,d) => d.Id = s.EncodeID());
        }
    }
}

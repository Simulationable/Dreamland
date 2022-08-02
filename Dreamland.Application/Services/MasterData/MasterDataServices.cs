using AutoMapper;
using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.ViewModels.MasterData;
using Dreamland.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Services.MasterData
{
    internal class MasterDataServices : IMasterDataServices
    {
        private readonly IProjectData _projectData;
        private readonly IMapper _mapper;
        public MasterDataServices(IProjectData projectData,
            IMapper mapper)
        {
            _projectData = projectData;
            _mapper = mapper;
        }
        public List<ProjectListViewModel> GetProjectListView(ProjectType projectType)
        {
            var projectList = _projectData.GetProjectList(projectType);
            var projectListView = _mapper.Map<List<ProjectList>, List<ProjectListViewModel>>(projectList);
            return projectListView;
        }
    }
}

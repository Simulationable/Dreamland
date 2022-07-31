﻿using AutoMapper;
using Dreamland.Application.Interfaces.Projects;
using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.ViewModels.MasterData;
using Dreamland.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Services.Projects
{
    internal class ProjectServices : IProjectServices
    {
        private readonly IProjectData _projectData;
        private readonly IMapper _mapper;
        public ProjectServices(IProjectData projectData,
            IMapper mapper)
        {
            _projectData = projectData;
            _mapper = mapper;
        }
    }
}

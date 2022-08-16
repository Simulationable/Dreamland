using Dreamland.Domain.Enums;
using Dreamland.Domain.ViewModels.MasterData;
using Dreamland.Domain.ViewModels.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Interfaces.Projects
{
    public interface IProjectServices
    {
        List<ProjectItemListViewModel> GetProjectItemList(ProjectTypes projectType);
    }
}

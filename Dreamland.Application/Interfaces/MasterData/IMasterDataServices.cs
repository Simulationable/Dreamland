using Dreamland.Domain.Enums;
using Dreamland.Domain.ViewModels.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Application.Interfaces.MasterData
{
    public interface IMasterDataServices
    {
        List<ProjectListViewModel> GetProjectListView(ProjectTypes projectType);
    }
}

using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.MasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Infrastructure.Data.Interfaces
{
    public interface IProjectData
    {
        public List<Project> GetProjectList(ProjectType type);
    }
}

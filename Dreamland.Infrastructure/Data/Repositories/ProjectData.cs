using Dreamland.Domain.Enums;
using Dreamland.Domain.Models.MasterData;
using Dreamland.Domain.Models.Project;
using Dreamland.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamland.Infrastructure.Data.Repositories
{
    public class ProjectData : IProjectData
    {
        public List<Project> GetProjectList(ProjectType type)
        {
            List<Project> listProject = new List<Project>();
            if (type.Equals(ProjectType.TownHome))
            {
                listProject.Add(new Project { Name = "Dream Priva", IsShow = true, IsActive = true });
            }
            else if (type.Equals(ProjectType.House))
            {
                listProject.Add(new Project { Name = "Ratirom Deluxe", IsShow = true, IsActive = true });
            }
            return listProject;
        }

        public ProjectItem GetProjectById(int id)
        {
            ProjectItem project = new ProjectItem();
            if (id == 1)
            {
                project.Id = new Guid();
                project.Name = "Ratiron Deluxe";
                project.Content = "";
                project.CreatedAt = DateTime.Parse("2021-03-19T05:20:12.0000000Z");
                project.CreateBy = "Administartor";
            }
            else if (id == 2)
            {
                project.Id = new Guid();
                project.Name = "Dream Priva";
                project.Content = "";
                project.CreatedAt = DateTime.Parse("2021-03-19T05:20:12.0000000Z");
                project.CreateBy = "Administrator";
            }
            return project;
        }
    }
}

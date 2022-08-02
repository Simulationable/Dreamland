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
        public List<ProjectList> GetProjectList(ProjectType type)
        {
            List<ProjectList> listProject = new List<ProjectList>();
            if (type.Equals(ProjectType.TownHome))
            {
                listProject.Add(new ProjectList { Id = new Guid("00e4ed1f-0dde-4265-9f22-f82ca08e32e6"), Name = "Dream Priva", IsShow = true, IsActive = true });
            }
            else if (type.Equals(ProjectType.House))
            {
                listProject.Add(new ProjectList { Id = new Guid("0338dcc9-9db1-42fd-9c89-6aa3884bb52f"), Name = "Ratirom Deluxe", IsShow = true, IsActive = true });
            }
            return listProject;
        }

        public ProjectItem GetProjectById(int id)
        {
            ProjectItem project = new ProjectItem();
            if (id == 1)
            {
                project.Id = new Guid("00e4ed1f-0dde-4265-9f22-f82ca08e32e6");
                project.Name = "Ratiron Deluxe";
                project.Content = "";
                project.CreatedAt = DateTime.Parse("2021-03-19T05:20:12.0000000Z");
                project.CreateBy = "Administartor";
            }
            else if (id == 2)
            {
                project.Id = new Guid("0338dcc9-9db1-42fd-9c89-6aa3884bb52f");
                project.Name = "Dream Priva";
                project.Content = "";
                project.CreatedAt = DateTime.Parse("2021-03-19T05:20:12.0000000Z");
                project.CreateBy = "Administrator";
            }
            return project;
        }
    }
}

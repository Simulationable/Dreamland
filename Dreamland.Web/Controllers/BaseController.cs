using Dreamland.Domain.Enums;
using Dreamland.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly IProjectData _projectData;

        public BaseController(IProjectData projectData)
        {
            _projectData = projectData; ;
        }

        protected void SetMenu()
        {
            ViewBag.townhomeList = _projectData.GetProjectList(ProjectType.TownHome);
            ViewBag.houseList = _projectData.GetProjectList(ProjectType.House);
        }
    }
}

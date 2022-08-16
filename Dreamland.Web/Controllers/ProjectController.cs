using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Projects;
using Dreamland.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class ProjectController : BaseController
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectServices _projectServices;
        public ProjectController(ILogger<ProjectController> logger,
            IMasterDataServices masterDataServices,
            IProjectServices projectServices) : base(masterDataServices)
        {
            _logger = logger;
            _projectServices = projectServices;
        }
        public IActionResult TownhomeListView()
        {
            SetMenu();
            ViewBag.townhomeListView = _projectServices.GetProjectItemList(ProjectTypes.TownHome);
            return View();
        }
        public IActionResult HouseListView()
        {
            SetMenu();
            ViewBag.houseListView = _projectServices.GetProjectItemList(ProjectTypes.House);
            return View();
        }
    }
}

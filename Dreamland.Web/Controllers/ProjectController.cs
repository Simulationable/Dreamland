using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Projects;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class ProjectController : BaseController
    {
        private readonly ILogger<ProjectController> _logger;
        public ProjectController(ILogger<ProjectController> logger,
            IMasterDataServices masterDataServices) : base(masterDataServices)
        {
            _logger = logger;
        }
        public IActionResult TownhomeList()
        {
            SetMenu();
            return View();
        }
    }
}

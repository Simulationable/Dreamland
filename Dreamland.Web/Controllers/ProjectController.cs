using Dreamland.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class ProjectController : BaseController
    {
        private readonly ILogger<ProjectController> _logger;
        public ProjectController(ILogger<ProjectController> logger,
            IProjectData projectData) : base(projectData)
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

using Dreamland.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurDreamController : BaseController
    {
        private readonly ILogger<OurDreamController> _logger;
        public OurDreamController(ILogger<OurDreamController> logger,
            IProjectData projectData) : base(projectData)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            SetMenu();
            return View();
        }
    }
}

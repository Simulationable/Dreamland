using Dreamland.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurKingdomController : BaseController
    {
        private readonly ILogger<OurKingdomController> _logger;
        public OurKingdomController(ILogger<OurKingdomController> logger,
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

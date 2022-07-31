using Dreamland.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class ContactController : BaseController
    {
        private readonly ILogger<ContactController> _logger;
        public ContactController(ILogger<ContactController> logger,
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

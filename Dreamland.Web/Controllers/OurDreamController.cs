using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Projects;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurDreamController : BaseController
    {
        private readonly ILogger<OurDreamController> _logger;
        public OurDreamController(ILogger<OurDreamController> logger,
            IMasterDataServices masterDataServices) : base(masterDataServices)
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

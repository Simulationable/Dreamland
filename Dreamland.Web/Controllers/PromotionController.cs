using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Projects;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class PromotionController : BaseController
    {
        private readonly ILogger<PromotionController> _logger;
        public PromotionController(ILogger<PromotionController> logger,
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

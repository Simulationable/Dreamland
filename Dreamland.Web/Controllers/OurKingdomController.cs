using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Projects;
using Dreamland.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurKingdomController : BaseController
    {
        private readonly ILogger<OurKingdomController> _logger;
        public OurKingdomController(ILogger<OurKingdomController> logger,
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

using Dreamland.Application.Interfaces.MasterData;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class ContactController : BaseController
    {
        private readonly ILogger<ContactController> _logger;
        public ContactController(ILogger<ContactController> logger,
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

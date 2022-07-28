using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class PromotionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurKingdomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

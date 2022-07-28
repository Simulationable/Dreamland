using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurDreamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

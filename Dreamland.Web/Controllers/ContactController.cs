using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

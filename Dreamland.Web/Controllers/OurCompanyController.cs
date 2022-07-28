using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurCompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

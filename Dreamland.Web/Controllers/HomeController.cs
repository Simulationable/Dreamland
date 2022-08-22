using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Posts;
using Dreamland.Domain.Enums;
using Dreamland.Domain.ViewModels.Commons;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dreamland.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPostServices _postService;
        public HomeController(ILogger<HomeController> logger,
            IMasterDataServices masterDataServices,
            IPostServices postServices) : base(masterDataServices)
        {
            _logger = logger;
            _postService = postServices;
        }

        public async Task<IActionResult> Index()
        {
            SetMenu();
            ViewBag.highLight = await _postService.GetPinPostList(PostSubCategories.Hightlight);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
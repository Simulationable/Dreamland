using Dreamland.Application.Helper.Cryptography;
using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Posts;
using Dreamland.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class PostController : BaseController
    {
        private readonly ILogger<PostController> _logger;
        private readonly IPostServices _postServices;
        public PostController(ILogger<PostController> logger,
            IMasterDataServices masterDataServices,
            IPostServices postServices) : base(masterDataServices)
        {
            _logger = logger;
            _postServices = postServices;
        }
        public async Task<IActionResult> Index()
        {
            SetMenu();
            ViewBag.testimonailPost = await _postServices.GetPostList(PostSubCategories.Testimonails);
            ViewBag.activityPost = await _postServices.GetPostList(PostSubCategories.Activity);
            return View();
        }

        [HttpGet("Page/{id}")]
        public async Task<IActionResult> Page(string id)
        {
            SetMenu();
            var decryptId = new Guid(AES.DecryptToString(id));
            ViewBag.postItem = await _postServices.GetPostByIdAsync(decryptId); 
            return View();
        }
    }
}

using Dreamland.Application.Helper.Cryptography;
using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Projects;
using Dreamland.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class ProjectController : BaseController
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectServices _projectServices;
        public ProjectController(ILogger<ProjectController> logger,
            IMasterDataServices masterDataServices,
            IProjectServices projectServices) : base(masterDataServices)
        {
            _logger = logger;
            _projectServices = projectServices;
        }
        [Route("{controller}/{action}/{id}")]
        public IActionResult Index(string id)
        {
            SetMenu();
            Guid decryptId = new Guid(AES.DecryptToString(id));
            if (decryptId.ToString().Equals("6c439e12-c08b-40db-8744-faa374452e9b"))
                return RedirectToAction("RatiromFifth");
            if (decryptId.ToString().Equals("e7cd08ef-10b4-4a99-bcb0-5a0debaa4560"))
                return RedirectToAction("DreamDeluxe");
            if (decryptId.ToString().Equals("0338dcc9-9db1-42fd-9c89-6aa3884bb52f"))
                return RedirectToAction("DreamPriva");
            if (decryptId.ToString().Equals("00e4ed1f-0dde-4265-9f22-f82ca08e32e6"))
                return RedirectToAction("RatiromDeluxe");
            return View();
        }
        public IActionResult RatiromFifth()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamDeluxe()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamPriva()
        {
            SetMenu();
            return View();
        }
        public IActionResult RatiromDeluxe()
        {
            SetMenu();
            return View();
        }
        public IActionResult TownhomeListView()
        {
            SetMenu();
            ViewBag.townhomeListView = _projectServices.GetProjectItemList(ProjectTypes.TownHome);
            return View();
        }
        public IActionResult HouseListView()
        {
            SetMenu();
            ViewBag.houseListView = _projectServices.GetProjectItemList(ProjectTypes.House);
            return View();
        }
    }
}

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
            //House
            if (decryptId.ToString().Equals("00e4ed1f-0dde-4265-9f22-f82ca08e32e6"))
                return RedirectToAction("RatiromDeluxe");
            if (decryptId.ToString().Equals("6c439e12-c08b-40db-8744-faa374452e9b"))
                return RedirectToAction("RatiromFifth");
            if (decryptId.ToString().Equals("3a72ca58-f83d-4f9a-b896-bea37bc5b450"))
                return RedirectToAction("RatiromPark");
            if (decryptId.ToString().Equals("2d739859-189a-4647-a6a6-78dc3061b628"))
                return RedirectToAction("RatiromPlace");
            if (decryptId.ToString().Equals("548bcf6f-b70f-43d2-977c-51f05f56a960"))
                return RedirectToAction("Ratirom2");
            
            //Townhome
            if (decryptId.ToString().Equals("0338dcc9-9db1-42fd-9c89-6aa3884bb52f"))
                return RedirectToAction("DreamPriva");
            if (decryptId.ToString().Equals("e7cd08ef-10b4-4a99-bcb0-5a0debaa4560"))
                return RedirectToAction("DreamDeluxe");
            if (decryptId.ToString().Equals("6022c88b-9a00-4bff-9199-8a32ad72a6d7"))
                return RedirectToAction("DreamVille3");
            if (decryptId.ToString().Equals("9186f867-3a72-4a55-9e54-9a810aa4eb2d"))
                return RedirectToAction("DreamVille2");
            if (decryptId.ToString().Equals("8397b74b-2ce9-42c4-97fc-24d4dc49943b"))
                return RedirectToAction("DreamVille");
            if (decryptId.ToString().Equals("c4eebf7e-c769-4945-bf46-c35a38ce7792"))
                return RedirectToAction("ADream");
            if (decryptId.ToString().Equals("22b81537-1be6-4580-b65c-27b02b8cead2"))
                return RedirectToAction("DreamVillage");
            if (decryptId.ToString().Equals("f0956b64-281e-4cf1-b256-fda8e59ccb59"))
                return RedirectToAction("DreamPlace");
            if (decryptId.ToString().Equals("046c38ed-a58e-486f-9440-8ff899fd4896"))
                return RedirectToAction("DreamTown");
            if (decryptId.ToString().Equals("9a6b79e1-5715-4038-99cd-1a30801927cf"))
                return RedirectToAction("DreamHome");
            if (decryptId.ToString().Equals("3844bb3e-0191-4b62-b434-89688d4a12bb"))
                return RedirectToAction("RatiromVille");
            if (decryptId.ToString().Equals("8bcbeb0b-9272-460f-8dfb-40c44bcafe69"))
                return RedirectToAction("Ratirom4");
            if (decryptId.ToString().Equals("35110639-929c-4a40-940c-ecd48067a4fb"))
                return RedirectToAction("Ratirom3");

            return View();
        }
        #region House
        public IActionResult RatiromDeluxe()
        {
            SetMenu();
            return View();
        }
        public IActionResult RatiromFifth()
        {
            SetMenu();
            return View();
        }
        public IActionResult RatiromPark()
        {
            SetMenu();
            return View();
        }
        public IActionResult RatiromPlace()
        {
            SetMenu();
            return View();
        }
        public IActionResult Ratirom2()
        {
            SetMenu();
            return View();
        }
        #endregion

        #region Townhome
        public IActionResult DreamPriva()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamDeluxe()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamVille3()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamVille2()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamVille()
        {
            SetMenu();
            return View();
        }
        public IActionResult ADream()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamVillage()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamPlace()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamTown()
        {
            SetMenu();
            return View();
        }
        public IActionResult DreamHome()
        {
            SetMenu();
            return View();
        }
        public IActionResult RatiromVille()
        {
            SetMenu();
            return View();
        }
        public IActionResult Ratirom4()
        {
            SetMenu();
            return View();
        }
        public IActionResult Ratirom3()
        {
            SetMenu();
            return View();
        }
        #endregion

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

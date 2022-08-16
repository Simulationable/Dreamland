using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Application.Interfaces.Projects;
using Dreamland.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly IMasterDataServices _masterDataServices;
        public BaseController(IMasterDataServices masterDataServices)
        {
            _masterDataServices = masterDataServices;
        }

        protected void SetMenu()
        {
            ViewBag.townhomeList = _masterDataServices.GetProjectListView(ProjectTypes.TownHome);
            ViewBag.houseList = _masterDataServices.GetProjectListView(ProjectTypes.House);
        }
    }
}

﻿using Dreamland.Application.Interfaces.MasterData;
using Dreamland.Domain.ViewModels.Commons;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dreamland.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,
            IMasterDataServices masterDataServices) : base(masterDataServices)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SetMenu();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
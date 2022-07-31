﻿using Dreamland.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dreamland.Web.Controllers
{
    public class OurCompanyController : BaseController
    {
        private readonly ILogger<OurCompanyController> _logger;
        public OurCompanyController(ILogger<OurCompanyController> logger,
            IProjectData projectData) : base(projectData)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            SetMenu();
            return View();
        }
    }
}

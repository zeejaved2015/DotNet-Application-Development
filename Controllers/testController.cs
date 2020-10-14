using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Testing_Dotnet_Application_Development.Models;

namespace Testing_Dotnet_Application_Development.Controllers
{
    public class testController : Controller
    {
        private readonly ILogger<testController> _logger;

        public testController(ILogger<testController> logger)
        {
            _logger = logger;
        }

        public IActionResult Test1()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
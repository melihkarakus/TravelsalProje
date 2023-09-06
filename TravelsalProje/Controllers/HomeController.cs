﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TravelsalProje.Models;

namespace TravelsalProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime d = Convert.ToDateTime(DateTime.Now.ToLongDateString()); //logların tarih biçiminde tutar
            _logger.LogInformation(d + "Index Sayfası çağrıldı.");//logları string tanımladığımız şekilde tutar
            _logger.LogError("Error Sayfası çağrıldı.");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy sayfası çağrıldı.");
            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test sayfası çağrıldı.");
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using kioskigospDALL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace kioskigospDALL.Controllers
{
    public class HomeController : Controller
    {
        private readonly KioskContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(KioskContext context, ILogger<HomeController> logger)   //ILogger<HomeController> logger
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index => View(db.Kiosks.ToList());

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

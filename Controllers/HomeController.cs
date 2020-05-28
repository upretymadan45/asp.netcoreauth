using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using authdemo.Models;
using Microsoft.AspNetCore.Authorization;

namespace authdemo.Controllers
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
            return View();
        }

        [Authorize(Roles="Admin")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Policy ="VotingPolicy")]
        public IActionResult Vote()
        {
            return View();
        }

        [Authorize(Policy = "DiscoAccess")]
        public IActionResult DiscoAccess()
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

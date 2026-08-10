using System.Diagnostics;
using EDAAMS_Desktop.Models;
using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
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

        [HttpPost]
        public IActionResult SetVisited()
        {
            //Setting a has visited parameter so that the user is not repromoted to Log-In
            HttpContext.Session.SetInt32("HaveVisitedHomePage", 1);
            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Settings()
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

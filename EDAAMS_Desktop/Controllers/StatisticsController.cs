using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult StudentStats()
        {
            return View();
        }
    }
}

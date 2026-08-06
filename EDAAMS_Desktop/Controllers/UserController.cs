using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult LogIn()
        {
            return View();

        }

        public IActionResult SignUp()
        {
            return View();

        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult LogIn(string role)
        {
            if (role == "std")
            {
                //Sets the sessions for log-in used to log out and keep track if someone logged in
                HttpContext.Session.SetString("role", "STUDENT");
                HttpContext.Session.SetString("stdNum", "ST12345678");

            }
            else
            {
                HttpContext.Session.SetString("role", "EDUCATOR");

            }

            return RedirectToAction("Index", "Home");

        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");

        }

        public IActionResult CRUDUser()
        {
            return View();

        }
    }
}

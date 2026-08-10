using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult LogIn(string role)
        {
            if (role == "ecr")
            {
                HttpContext.Session.SetString("role", "EDUCATOR");

            }
            if (role == "std")
            {
                //Sets the sessions for log-in used to log out and keep track if someone logged in
                HttpContext.Session.SetString("role", "STUDENT");
                HttpContext.Session.SetString("stdNum", "ST12345678");

            }
            else
            if(role == "adn")
            {
                HttpContext.Session.SetString("role", "ADMIN");

            }

            return RedirectToAction("Index", "Home");

        }
        public IActionResult LogOut()
        {
            //Instead of clear we set each session to null
            HttpContext.Session.SetString("role", "");
            HttpContext.Session.SetString("stdNum", "");

            return RedirectToAction("Index", "Home");

        }

        public IActionResult CRUDUser()
        {
            return View();

        }
    }
}

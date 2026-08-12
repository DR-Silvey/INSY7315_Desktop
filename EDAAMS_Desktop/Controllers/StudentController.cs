using EDAAMS_Desktop.Models.StudentModels;
using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CRUDStudent()
        {
            var vm = new StudentSubjectVM();

            return View(vm);
        }

        [HttpGet]
        public IActionResult FindStudent(string studID)
        {
            //Note- Use an actual LINQ query to find and return then correct student
            var vm = new StudentSubjectVM();

            return View("Index", vm);

        }

    }
}

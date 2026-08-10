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

    }
}

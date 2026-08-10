using EDAAMS_Desktop.Models.AssessmentModels;
using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
{
    public class AssessmentController : Controller
    {
        public IActionResult CreateAssessment()
        {
            var vm = new QuestionVM();

            return View("AssessmentBuilders/CreateAssessment", vm);

        }

        public IActionResult CRUDQuestion()
        {
            var vm = new QuestionVM();

            return View("AssessmentPool/CRUDQuestion", vm);

        }
        
        public IActionResult MarkAssessment()
        {
            return View("AssessmentMarking/MarkAssessment");

        }

        public IActionResult StartAssessment(string assID)
        {
            if (assID != null)
            {
                HttpContext.Session.SetString("assID", assID);

            }
            else
            {
                return RedirectToAction("Index", "Home");

            }

            //Temp Prototype Data
            var vm = new QuestionVM();
            

            return View("AssessmentHosts/StartAssessment", vm);

        }

        public IActionResult EndAssessment()
        {
            return View("AssessmentHosts/EndAssessment");

        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace EDAAMS_Desktop.Controllers
{
    public class AssessmentController : Controller
    {
        public IActionResult CreateAssessment()
        {
            return View("AssessmentBuilders/CreateAssessment");

        }

        public IActionResult CRUDQuestion()
        {
            return View("AssessmentPool/CRUDQuestion");

        }
        
        public IActionResult MarkAssessment()
        {
            return View("AssessmentMarking/MarkAssessment");

        }

        public IActionResult StartAssessment()
        {
            return View("AssessmentHosts/StartAssessment");

        }

        public IActionResult EndAssessment()
        {
            return View("AssessmentHosts/EndAssessment");

        }

    }
}

using EDAAMS_Desktop.Models.AssessmentModels;
using Microsoft.AspNetCore.Mvc;
using QRCoder;

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

        //Generates the QR code used to END an ASSESSMENT ()
        [HttpPost]
        public IActionResult GenerateQRCode(string terminationCode)
        {
            using (QRCodeGenerator qRCodeGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrData = qRCodeGenerator.CreateQrCode(terminationCode, QRCodeGenerator.ECCLevel.Q))
                {
                    using (PngByteQRCode qrCode = new PngByteQRCode(qrData))
                    {
                        //Setting the QR Code to be a certain pixels per module size
                        byte[] qrCodeByteArr = qrCode.GetGraphic(20);

                        //Conversion and injection into HTML view
                        string b64String = Convert.ToBase64String(qrCodeByteArr);
                        ViewBag.QRCode = "data:image/png;base64," + b64String;

                    }

                }

            }

            return View("AssessmentHosts/EndAssessment");

        }

    }
}

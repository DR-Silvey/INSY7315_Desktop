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

/*
    McGeary, R. 2009.
    How do I redirect to another web page?. StackOverflow. [blog] 3 Feb.
    Available at:
    <https://stackoverflow.com/questions/503093/how-do-i-redirect-to-another-webpage>
    [Accessed 1 August 2026]

    Bro Code. 2022.
    Learn how JavaScript COOKIES work!.
    [video online] Available at:
    <https://www.youtube.com/watch?v=i7oL_K_FmM8&t=379s>
    [Accessed 1 August 2026]

    W3 Schools, s.a. JavaScript Tutorial.
    [online] Available at:
    <https://www.w3schools.com/js/DEFAULT.asp>
    [Accessed 1 August 2026]

    W3 Schools, s.a. Bootstrap 5 Containers.
    [online] Available at:
    <https://www.w3schools.com/bootstrap5/bootstrap_containers.php>
    [Accessed 1 August 2026]

    W3 Schools, s.a. Modal.
    [online] Available at:
    <https://www.w3schools.com/bootstrap5/bootstrap_containers.php>
    [Accessed 1 August 2026]

    getbootstrap, s.a. Select.
    [online] Available at:
    <https://getbootstrap.com/docs/5.0/forms/select/>
    [Accessed 1 August 2026]

    W3Schools, s.a. How TO - Navbar with Icons.
    [online] Available at:
    <https://www.w3schools.com/howto/howto_css_navbar_icon.asp>
    [Accessed 1 August 2026]

    Font Awesome, s.a. The Icons.
    [online] Available at:
    <https://fontawesome.com/v4/icons/>
    [Accessed 1 August 2026]

    IIEVC School of Computer Science, 2025.
    CLDV6212 Azure functions part 2 Azure functions and queues triggers.
    [video online] Available at:
    <https://www.youtube.com/watch?v=zP4umzRCsTM&list=PL480DYS-b_kcZiyuCyHolh6Nad8J_Xnk7&index=8>
    [Accessed 1 August 2026]

    Troelson, A. and Japiske, P. 2021.
    Pro C# with .NET 5: Foundational Principles and Practices in programming.
    10th ed. Apress Media: NewYork. ISBN: 978-1-4842-6939-8.
    [eBook]. Available on EBSCOhost at:
    https://ezproxy.iielearn.ac.za/login?url=https://search.ebsco-host.com/login.aspx?direct=true&db=nlebk&AN=2917701&site=ehost-live&scope=site
    [Accessed 1 August 2026]

 */
namespace EDAAMS_Desktop.Models.AssessmentModels
{
    public class Assessment
    {
        public string AssessmentID { get; set; }
        public string StudentID { get; set; }

        //Marked grades in int to 10000 aka %97,42 == 97420
        public int? MarkedGrade { get; set; } //can be null 
        public int AutoMarkGrade { get; set; } //-999 if no auto mark, -000 if should auto mark, can not be null

        //List Containing the Url's linking to images that are stored of assessment pages
        public List<string>? ImgURLs { get; set; } //Can be null if no images uploaded

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
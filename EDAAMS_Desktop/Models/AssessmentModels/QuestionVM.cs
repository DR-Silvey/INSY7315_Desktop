namespace EDAAMS_Desktop.Models.AssessmentModels
{
    public class QuestionVM
    {
        public List<AssessmentQuestion> Questions { get; set; } = new()
        {
                new AssessmentQuestion {
                    QuestionNumber = 1,
                    QuestionBody = "How Many Sides Does a SQAURE have?",
                    IsMultiChoice = true,
                    Options = new List<string>
                    {
                        "A: 4",
                        "B: 2",
                        "C: 762",
                        "D: 1"

                    }

                },

                new AssessmentQuestion {
                    QuestionNumber = 2,
                    QuestionBody = "How Many Legs does a TARANTULA have?",
                    IsMultiChoice = true,
                    Options = new List<string>
                    {
                        "A: 2",
                        "B: 4",
                        "C: 100",
                        "D: None of the Above"

                    }

                },

                new AssessmentQuestion {
                    QuestionNumber = 3,
                    QuestionBody = "What Does DDR mean?",
                    IsMultiChoice = true,
                    Options = new List<string>
                    {
                        "A: Double Direct Rate",
                        "B: Double Data Rate",
                        "C: Direct Data Route",
                        "D: None of the Above"

                    }

                },

                new AssessmentQuestion {
                    QuestionNumber = 4,
                    QuestionBody = "Tomato Sauce belong on?",
                    IsMultiChoice = true,
                    Options = new List<string>
                    {
                        "A: Noodles",
                        "B: French Toast",
                        "C: Fries",
                        "D: All of the above"

                    }

                },

                new AssessmentQuestion {
                    QuestionNumber = 5,
                    QuestionBody = "When did the first moon Landing take Place?",
                    IsMultiChoice = false,
                    Options = new List<string>{}

                },

                new AssessmentQuestion {
                    QuestionNumber = 6,
                    QuestionBody = "Which Famous Philosopher is attributed to the creation of the Phrase -God Is Dead and we have Killed Him- ?",
                    IsMultiChoice = false,
                    Options = new List<string>{}

                },

                new AssessmentQuestion {
                    QuestionNumber = 7,
                    QuestionBody = "OHM's Law States that?",
                    IsMultiChoice = false,
                    Options = new List<string>{}

                },

                new AssessmentQuestion {
                    QuestionNumber = 8,
                    QuestionBody = "Sheldon Cooper from the series Big Bang Theory commonly says which Catchphrase?",
                    IsMultiChoice = false,
                    Options = new List<string>{}

                },

                new AssessmentQuestion {
                    QuestionNumber = 9,
                    QuestionBody = "Main Character of the hit movie named TROY?",
                    IsMultiChoice = false,
                    Options = new List<string>{}

                },

                new AssessmentQuestion {
                    QuestionNumber = 10,
                    QuestionBody = "Which Country hosted the 2016 Olympics?",
                    IsMultiChoice = false,
                    Options = new List<string>{}

                },

             };

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
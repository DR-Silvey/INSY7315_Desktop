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

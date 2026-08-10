namespace EDAAMS_Desktop.Models.AssessmentModels
{
    public class AssessmentQuestion
    {
        public int QuestionNumber { get; set; }
        public string QuestionBody { get; set; }
        public bool IsMultiChoice { get; set; }
        public List<string> Options { get; set; }

    }
}

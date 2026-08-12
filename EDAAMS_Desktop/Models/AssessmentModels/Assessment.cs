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

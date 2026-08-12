namespace EDAAMS_Desktop.Models.StudentModels
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentFullName { get; set; }
        public int CurrentYearOfStudy { get; set; }

        //Saved as an int, but to the ten thousands so always times with 10000 to get true value
        public int GradeAvg { get; set; }

        //List of te Subjects the student takes
        public List<Subject>? Subjects { get; set; }

    }
}
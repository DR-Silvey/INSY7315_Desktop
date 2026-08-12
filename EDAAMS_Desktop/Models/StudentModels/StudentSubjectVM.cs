namespace EDAAMS_Desktop.Models.StudentModels
{
    public class StudentSubjectVM
    {
        public List<Subject> Subjects { get; set; } = new()
        {
            new Subject
            {
                SubjectName = "MATH",
                SubjectCode = "MT123",
                MinPassingGrade = 30

            },

            new Subject
            {
                SubjectName = "ENGLISH",
                SubjectCode = "ENG123",
                MinPassingGrade = 50

            },

            new Subject
            {
                SubjectName = "PHYSICAL SCIENCES",
                SubjectCode = "PHY123",
                MinPassingGrade = 30

            },

            new Subject
            {
                SubjectName = "BIOLOGY",
                SubjectCode = "BIO123",
                MinPassingGrade = 40

            },

            new Subject
            {
                SubjectName = "HISTORY",
                SubjectCode = "HTR123",
                MinPassingGrade = 50

            },

        };

        public Student Student { get; set; } = new()
        {
            StudentID = "ST12345678",
            StudentFullName = "Koos Konfyt",
            CurrentYearOfStudy = 10,
            GradeAvg = 72

        };

    }
}

namespace WebAppSubjectMark.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? SubjectName { get; set; }
        public int SubjectMarks { get; set; }
    }
}

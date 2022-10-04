namespace WebEFmn.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public ICollection<Student> StudentsEnrolled { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace WebEFmn.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? YearOfEntry { get; set; }

        public ICollection<Subject> OwnSubjects { get; set; }
    }
}

using Domain.Enrollments.Entities;

namespace Domain.Students.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Identification { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

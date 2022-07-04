using Domain.Courses.Entities;
using Domain.Students.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enrollments.Entities
{
    public enum Grade
    {
        A,B,C,D,E,F,G
    }
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public Grade Grade { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

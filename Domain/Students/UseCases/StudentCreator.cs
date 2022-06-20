using Domain.Students.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Students.UseCases
{
    public class StudentCreator
    {
        private StudentRepository _studentReposiroty;
        public StudentCreator(StudentRepository studentRepository)
        {
            _studentReposiroty = studentRepository;
        }

        public void Run(Student student)
        {
            _studentReposiroty.Create(student);
        }
    }
}

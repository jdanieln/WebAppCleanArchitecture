
using Domain.Students.Entities;

namespace Domain.Students.UseCases
{
    public class StudentsFinder
    {
        private StudentRepository _studentRepository;
        public StudentsFinder(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> Run()
        {
            return _studentRepository.GetAll();
        }
    }
}


using Domain.Students.Entities;

namespace Domain.Students.UseCases
{
    public class StudentRemover
    {
        private StudentRepository _studentRepository;
        public StudentRemover(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Run(int id)
        {
            _studentRepository.Delete(id);
        }
    }
}

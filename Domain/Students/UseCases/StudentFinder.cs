using Domain.Students.Entities;

namespace Domain.Students.UseCases
{
    public class StudentFinder
    {
        private StudentRepository _studentRepository;
        public StudentFinder(StudentRepository studentReposiroty)
        {
            _studentRepository = studentReposiroty;
        }

        public Student Run(int id)
        {
            return _studentRepository.GetOne(id);
        }
    }
}

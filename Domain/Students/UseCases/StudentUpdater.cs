using Domain.Students.Entities;

namespace Domain.Students.UseCases
{
    public class StudentUpdater
    {
        private StudentRepository _studentRository;
        public StudentUpdater(StudentRepository studentReposiroty)
        {
            _studentRository = studentReposiroty;
        }

        public void Run(Student student)
        {
            _studentRository.Update(student);
        }
    }

}

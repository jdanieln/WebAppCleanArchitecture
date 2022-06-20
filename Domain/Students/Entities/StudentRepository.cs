namespace Domain.Students.Entities
{
    public interface StudentRepository
    {
        List<Student> GetAll();
        Student GetOne(int id);
        void Create(Student student);
        void Update(Student student);
        void Delete(int id);
    }
}

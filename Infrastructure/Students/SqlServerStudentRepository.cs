using Domain.Students.Entities;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using DbUpdateConcurrencyException = Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException;
using DbUpdateException = Microsoft.EntityFrameworkCore.DbUpdateException;

namespace Infrastructure.Students
{
    public class SqlServerStudentRepository : StudentRepository
    {
        private ApplicationDbContext _context;
        public SqlServerStudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public void Delete(int id)
        {
            var course = _context.Students.Find(id);
            if (course == null)
            {
                throw new Exception($"El estudiante con id: { id } no existe");
            }

            _context.Students.Remove(course);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetOne(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null) throw new Exception($"Usuario con Id: { id } No existe");

            return student;
        }

        public void Update(Student student)
        {
            try
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}

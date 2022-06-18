using Domain.Students.Entities;
using Domain.Students.UseCases;
using Infrastructure.Persistance;
using Infrastructure.Students;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCleanArchitecture.Features.Students
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly StudentRepository _studentRepository;
        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
            _studentRepository = new SqlServerStudentRepository(_context);
        }

        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            StudentsFinder studentsFinder = new StudentsFinder(_studentRepository);
            return Ok(studentsFinder.Run());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            StudentFinder studentFinder = new StudentFinder(_studentRepository);
            return Ok(studentFinder.Run(id));
        }

        [HttpPost]
        public ActionResult<Student> CreateStudent(Student student)
        {
            StudentCreator studentCreator = new StudentCreator(_studentRepository);
            studentCreator.Run(student);
            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<Student> UpdateStudent(Student student)
        {
            StudentUpdater studentUpdater = new StudentUpdater(_studentRepository);
            studentUpdater.Run(student);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            StudentRemover studentRemover = new StudentRemover(_studentRepository);
            studentRemover.Run(id);
            return Ok();
        }

    }

}

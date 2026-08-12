using _4_august_practice.Models;
using _4_august_practice.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _4_august_practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        // GET: api/Student
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_service.GetAllStudents());
        }

        // GET: api/Student/1
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _service.GetStudentById(id);

            if (student != null)
            {
                return Ok(student);
            }

            return NotFound("Student not found");
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _service.AddStudent(student);
            return Ok("Student added successfully");
        }

        // PUT: api/Student
        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            _service.UpdateStudent(student);
            return Ok("Student updated successfully");
        }

        // DELETE: api/Student/1
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _service.DeleteStudent(id);
            return Ok("Student deleted successfully");
        }
    }
}
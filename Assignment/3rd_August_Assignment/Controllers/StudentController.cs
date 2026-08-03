using Microsoft.AspNetCore.Mvc;
using _2nd_August_Practice.Models;
using _2nd_August_Practice.Repository;

namespace _2nd_August_Practice.Controllers
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

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _service.GetStudent(id);

            if (student == null)
                return NotFound("Student not found.");

            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _service.AddStudent(student);
            return Ok("Student Added Successfully");
        }

        [HttpPut]
        public IActionResult UpdateStudent(Student student)
        {
            _service.UpdateStudent(student);
            return Ok("Student Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _service.DeleteStudent(id);
            return Ok("Student Deleted Successfully");
        }
    }
}
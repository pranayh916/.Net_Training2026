using _28_July_Assignment.Models;
using _28_July_Assignment.Services;
using Microsoft.AspNetCore.Mvc;

namespace _28_July_Assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : ControllerBase
    {
        private readonly IRegister _service;

        public RegisterController(IRegister service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.DisplayCourse());
        }

        [HttpPost]
        public IActionResult RegisterCourse(Course course)
        {
            return Ok(_service.RegisterCourse(course));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, Course course)
        {
            var result = _service.UpdateCourse(id, course);

            if (result == null)
                return NotFound("Course Not Found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            if (_service.CancelCourse(id))
                return Ok("Course Deleted Successfully");

            return NotFound("Course Not Found");
        }
    }
}
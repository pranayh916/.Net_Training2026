using Microsoft.AspNetCore.Mvc;
using _2nd_August_Practice.Models;
using _2nd_August_Practice.Repository;

namespace _2nd_August_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _service.GetCourse(id);

            if (course == null)
                return NotFound("Course not found.");

            return Ok(course);
        }

        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            _service.AddCourse(course);
            return Ok("Course Added Successfully");
        }

        [HttpPut]
        public IActionResult UpdateCourse(Course course)
        {
            _service.UpdateCourse(course);
            return Ok("Course Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            _service.DeleteCourse(id);
            return Ok("Course Deleted Successfully");
        }
    }
}
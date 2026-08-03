using _2nd_August_Practice.Models;
using _2nd_August_Practice.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace _2nd_August_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatchController : ControllerBase
    {
        private readonly IBatchService _service;

        public BatchController(IBatchService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBatch(int id)
        {
            var batch = _service.GetBatch(id);

            if (batch == null)
                return NotFound();

            return Ok(batch);
        }

        [HttpPost]
        public IActionResult AddBatch(Batch batch)
        {
            _service.AddBatch(batch);
            return Ok("Batch Added Successfully");
        }

        [HttpPut]
        public IActionResult UpdateBatch(Batch batch)
        {
            _service.UpdateBatch(batch);
            return Ok("Batch Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBatch(int id)
        {
            _service.DeleteBatch(id);
            return Ok("Batch Deleted Successfully");
        }
    }
}
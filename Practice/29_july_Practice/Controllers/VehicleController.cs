using _29_july_Practice_2.Models;
using _29_july_Practice_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace _29_july_Practice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.getVehicle());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.getVehicle(id));
        }

        [HttpGet("brand/{brand}")]
        public IActionResult GetByBrand(string brand)
        {
            return Ok(_service.getVehicleBrand(brand));
        }

        [HttpPost]
        public IActionResult Post(Vehicle vehicle)
        {
            var result = _service.addVehicle(vehicle);

            return Ok(new
            {
                Message = "Vehicle Added Successfully",
                Data = result
            });
        }
    }
}
using _6th_and_5th_August_Assignment.Models;
using _6th_and_5th_August_Assignment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _6th_and_5th_August_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(_service.GetAllOrders());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            var order = _service.GetOrderById(id);

            if (order == null)
            {
                return NotFound("Order not found");
            }

            return Ok(order);
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            _service.AddOrder(order);
            return Ok("Order added successfully");
        }

        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            _service.UpdateOrder(order);
            return Ok("Order updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            _service.DeleteOrder(id);
            return Ok("Order deleted successfully");
        }
    }
}
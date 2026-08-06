using _6th_August_Practice.Models;
using _6th_August_Practice.Repository;
using Microsoft.AspNetCore.Mvc;

namespace _6th_August_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET: api/Product
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _service.GetAllProducts();
            return Ok(products);
        }

        // GET: api/Product/1
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _service.GetProductById(id);

            if (product == null)
            {
                return NotFound("Product not found.");
            }

            return Ok(product);
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _service.AddProduct(product);
            return Ok("Product added successfully.");
        }

        // DELETE: api/Product/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            _service.DeleteProductById(id);
            return Ok("Product deleted successfully.");
        }

        // PUT: api/Product
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _service.UpdateProduct(product);
            return Ok("Product updated successfully.");
        }

    }
}
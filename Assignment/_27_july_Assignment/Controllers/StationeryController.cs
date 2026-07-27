using _27_july_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _27_july_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationeryController : ControllerBase
    {
        static List<Stationery> StationeryList = new List<Stationery>()
        {
            new Stationery
            {
                Id = 1,
                ProductName = "Pen",
                Category = "Writing",
                Price = 10,
                Quantity = 100
            },
            new Stationery
            {
                Id = 2,
                ProductName = "Notebook",
                Category = "Notebook",
                Price = 50,
                Quantity = 40
            },
            new Stationery
            {
                Id = 3,
                ProductName = "Pencil",
                Category = "Writing",
                Price = 5,
                Quantity = 150
            }
        };

        // GET ALL
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(StationeryList);
        }

        // GET BY ID----ID SE LA LENGE 
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = StationeryList.FirstOrDefault(x => x.Id == id);

            if (item == null)
                return NotFound("Product not found");

            return Ok(item);
        }

        // POST---DATA LAYENGA
        [HttpPost]
        public IActionResult AddProduct(Stationery s)
        {
            StationeryList.Add(s);
            return Ok("Product Added Successfully");
        }

        // PUT  PRICE KO UPDATE KIYA 
        [HttpPut("{id}")]
        public IActionResult UpdatePrice(int id, Stationery s)
        {
            var item = StationeryList.FirstOrDefault(x => x.Id == id);

            if (item == null)
                return NotFound("Product not found");

            item.Price = s.Price;

            return Ok("Price Updated Successfully");
        }

        // DELETE---  ID SE DELETE KAR LENGA 

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var item = StationeryList.FirstOrDefault(x => x.Id == id);

            if (item == null)
                return NotFound("Product not found");

            StationeryList.Remove(item);

            return Ok("Product Deleted Successfully");
        }

        // GET BY CATEGORY    ----CATEGORY SE FILTER KARENGA 
        [HttpGet("Category/{category}")]
        public IActionResult GetByCategory(string category)
        {
            var result = StationeryList
                .Where(x => x.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (result.Count == 0)
                return NotFound("No products found");

            return Ok(result);
        }
    }
}


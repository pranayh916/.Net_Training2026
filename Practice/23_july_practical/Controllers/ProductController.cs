using Microsoft.AspNetCore.Mvc;
using July23_Practical.Models;

namespace July23_Practical.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ID = 1,
                    Name = "Laptop",
                    Price = 50000
                },

                new Product
                {
                    ID = 2,
                    Name = "Mouse",
                    Price = 800
                },

                new Product
                {
                    ID = 3,
                    Name = "Keyboard",
                    Price = 1200
                }
            };

            return View(products);
        }
    }
}
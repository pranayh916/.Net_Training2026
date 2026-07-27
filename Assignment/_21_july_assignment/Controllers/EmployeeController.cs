using _21_july_assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21_july_assignment.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            if (ModelState.IsValid)
            {
                TempData["Department"] = emp.Department;

                return View("Success", emp);
            }

            return View(emp);
        }
    }
}
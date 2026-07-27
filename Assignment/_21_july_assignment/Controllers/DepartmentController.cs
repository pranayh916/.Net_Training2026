using _21_july_assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace _21_july_assignment.Controllers

{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["Department"] == null)
            {
                return RedirectToAction("Index", "Employee");
            }

            Department dept = new Department()
            {
                DepartmentName = TempData["Department"].ToString(),
                DepartmentHead = "Rajesh Sharma",
                HeadContactNumber = "9876543210",
                HeadEmail = "head@company.com"
            };

            return View(dept);
        }
    }
}
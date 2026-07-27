
using Microsoft.AspNetCore.Mvc;
using _16th__july_assignment.Models;
namespace _16th__july_assignment.Controllers

{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listdepartments = new List<Department>()
            {
                new Department
                {
                    DepartmentName = "IT",
                    DepartmentHead = "Amit Sharma",
                    HeadContact = "9876543210",
                    HeadEmail = "amit@company.com"
                },

                new Department
                {
                    DepartmentName = "HR",
                    DepartmentHead = "Priya Singh",
                    HeadContact = "9876501234",
                    HeadEmail = "priya@company.com"
                },

                new Department
                {
                    DepartmentName = "Finance",
                    DepartmentHead = "Rohit Patil",
                    HeadContact = "9988776655",
                    HeadEmail = "rohit@company.com"
                }
            };

            return View(listdepartments);
        }
    }
}
using _16th__july_assignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _16th__july_assignment.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> listEmployee = new List<Employee>()
          {
             new Employee
            {
                empid = 1,
                empname="Pranay",
                empdepartment = "SAP",
                empsalary=50000.9,
                empemail="pranu91@gmail.com"

            },
            new Employee
            {
                empid = 4,
                empname="Anu",
                empdepartment = "IT",
                empsalary = 50000.9,
                empemail = "anu91@gmail.com"

            },
            new Employee
            {
                empid = 5,
                empname="rutu",
                empdepartment = "Data Science",
                empsalary = 50000.9,
                empemail = "rutuu91@gmail.com"

            }
        };

            return View(listEmployee);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

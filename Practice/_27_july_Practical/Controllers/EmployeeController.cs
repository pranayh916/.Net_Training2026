using _27_july_Practical.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace _27_july_Practical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> EmployeeList = new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "Pranay",
                LastName = "Hajare",
                Department = "IT",
                Mobile = "9862373217"
            },
            new Employee
            {
                Id = 2,
                Name = "Tushar",
                LastName = "Rana",
                Department = "HR",
                Mobile = "9876543210"
            },
            new Employee
            {
                Id = 3,
                Name = "Vinay",
                LastName = "Sharma",
                Department = "Finance",
                Mobile = "9988776655"
            }
        };

        // GET: api/employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(EmployeeList);
        }

        // GET: api/employee/2
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var emp = EmployeeList.FirstOrDefault(e => e.Id == id);

            if (emp == null)
            {
                return NotFound("Employee not found");
            }

            return Ok(emp);
        }

        // POST: api/employee
        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            EmployeeList.Add(emp);
            return Ok("Employee Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateLastName(int id, Employee e)
        {
            var employee = EmployeeList.FirstOrDefault(x => x.Id == id);

            if (employee == null)
            {
                return NotFound("Employee not found");
            }

            employee.LastName = e.LastName;

            return Ok("Last Name Updated Successfully");
        }

        [HttpGet("Dept/{dept}")]
        public IActionResult GetEmployeeDept(string dept)
        {
            var result = EmployeeList
                .Where(s => s.Department.Equals(dept, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (result.Count == 0)
            {
                return NotFound("No employee found in this department.");
            }
            return Ok(result);
        }
    }
}
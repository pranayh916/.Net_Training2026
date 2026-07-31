using _24_july_Practice.Models;
using Microsoft.AspNetCore.Mvc;

namespace _24_july_Practice.Controllers
{
    public class HomeController : Controller
    {
        // Login Page
        public IActionResult Index()
        {
            return View();
        }

        // Login
        [HttpPost]
        public IActionResult Index(Student s)
        {
            if (ModelState.IsValid)
            {
                if (s.username == "admin" && s.password == "1234")
                {
                    HttpContext.Session.SetString("User", s.username);
                    return RedirectToAction("Dashboard");
                }

                ViewBag.Error = "Invalid Username or Password";
            }

            return View(s);
        }

        // Dashboard
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("User") == null)
            {
                return RedirectToAction("Index");
            }

            List<StudentDetails> studentlist = new List<StudentDetails>()
            {
                new StudentDetails
                {
                    Id = 101,
                    Name = "Rahul",
                    Course = "B.E Computer Engineering",
                    Email = "rahul@gmail.com",
                    Mobile = "9543210"
                },

                new StudentDetails
                {
                    Id = 102,
                    Name = "Priya ",
                    Course = "B.E Information Technology",
                    Email = "priya@gmail.com",
                    Mobile = "9843211"
                },

                new StudentDetails
                {
                    Id = 103,
                    Name = "Amit ",
                    Course = " Artificial Intelligence",
                    Email = "amit@gmail.com",
                    Mobile = "9873212"
                },

                new StudentDetails
                {
                    Id = 104,
                    Name = "pranay",
                    Course = "B.E Computer Science",
                    Email = "panya@gmail.com",
                    Mobile = "9873213"
                },

                new StudentDetails
                {
                    Id = 105,
                    Name = "Rohan",
                    Course = "B.E Electronics",
                    Email = "rohan@gmail.com",
                    Mobile = "983214"
                }
            };

            return View(studentlist);
        }

        // Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
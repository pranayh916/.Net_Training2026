using _21_july.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Diagnostics;

namespace _21_july.Controllers
{
    public class HomeController : Controller
    {
        //DISPLAY FORM
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student s)
        {


            if (ModelState.IsValid)
            {
                ViewBag.Message = "Student Registered Successfully!";
                return View();
            }

            return View(s);
        }
    }
}

       
    


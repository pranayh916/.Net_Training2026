using Microsoft.AspNetCore.Mvc;

namespace Stationery_23_july_Assignment.Controllers
{
    public class StationeryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

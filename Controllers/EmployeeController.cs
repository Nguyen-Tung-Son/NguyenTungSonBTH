using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int EmployeeID, string EmployeeName, int Age)
        {
            ViewBag.name = "Hello" + EmployeeID + "-" + EmployeeName + "-" + Age;
            return View();
        }
    }
}
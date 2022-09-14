using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int PersonID, string PersonName, int Age)
        {
            ViewBag.name = "Hello" + PersonID + "-" + PersonName + "-" + Age;
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        // 
        // GET: /Demo/

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            List<Person> PersonList = new List<Person>()
            {
                new Person {PersonID = 1, PersonName = "Nguyen Van A", Age = 18},
                new Person {PersonID = 2, PersonName = "Nguyen Van B", Age = 18},
                new Person {PersonID = 3, PersonName = "Nguyen Van C", Age = 18},
                new Person {PersonID = 4, PersonName = "Nguyen Van D", Age = 18},
                new Person {PersonID = 5, PersonName = "Nguyen Van E", Age = 18},
            };
            ViewData["Persons"] = PersonList;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person PersonList)
        {
            return View();
        } 
        
    }
}
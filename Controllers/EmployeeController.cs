/*using Microsoft.AspNetCore.Mvc;

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
}*/
using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> EmployeeList = new List<Employee>()
            {
                new Employee {EmployeeID = 1, EmployeeName = "Nguyen Van A", Age = 18},
                new Employee {EmployeeID = 2, EmployeeName = "Nguyen Van B", Age = 18},
                new Employee {EmployeeID = 3, EmployeeName = "Nguyen Van C", Age = 18},
                new Employee {EmployeeID = 4, EmployeeName = "Nguyen Van D", Age = 18},
                new Employee {EmployeeID = 5, EmployeeName = "Nguyen Van E", Age = 18},
            };
            ViewData["Employees"] = EmployeeList;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee EmployeeList)
        {
            return View();
        } 
        
    }
}
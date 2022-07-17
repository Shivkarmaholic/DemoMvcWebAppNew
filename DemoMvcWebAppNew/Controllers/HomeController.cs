using DemoMvcWebAppNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoMvcWebAppNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> elist = new List<Employee>()
            {
                new Employee{eid=1,ename="Ramesh",edept="IT",esalary=12000},
                new Employee{eid=2,ename="Manohar",edept="Computer",esalary=25000},
                new Employee{eid=3,ename="Ajinkya",edept="IT",esalary=45000},
                new Employee{eid=4,ename="Rahul",edept="Mechanical",esalary=32000},

            };
            ViewData["emplist"] = elist;

            ViewData["htitle"] = "Welcome to India";
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            

            return View();
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
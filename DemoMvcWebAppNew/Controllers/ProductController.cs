using Microsoft.AspNetCore.Mvc;
using DemoMvcWebAppNew.Models;

namespace DemoMvcWebAppNew.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>()
            {
                new Product { pId= 1,pName="Pen",pPrice=500 },
                new Product { pId= 2,pName="Screwdriver",pPrice=700},
                new Product { pId= 3,pName="foodpaste",pPrice=200},
                new Product { pId= 4,pName="biscuit",pPrice=100},
            };
            ViewBag.Products = plist;
            return View();
        }

        [HttpGet] // by default 
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.id = form["txtid"];
            ViewBag.name=form["txtname"];
            ViewBag.price = form["txtprice"];
            return View("Details");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoMvcWebAppNew.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> options=new List<string>();
            options.Add("Select an Option");
            options.Add("Yes");
            options.Add("No");
            ViewData["options"]=new SelectList(options);
            return View(options);
        }

        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form,ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.Options = form["options"];
            return View("Display");
        }
    }
}

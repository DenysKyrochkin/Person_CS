using Zodiac.Models;
using Microsoft.AspNetCore.Mvc;

namespace Zodiac.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result()
        {
            Person person = new Person(
                HttpContext.Request.Form["Name"],
                HttpContext.Request.Form["Surname"],
                HttpContext.Request.Form["Email"],
                new Dates(HttpContext.Request.Form["Date"])
                );

            //if(HttpContext.Request.Form == null)
            //{

            //}
            if (person.Birthday.Age > 135 || person.Birthday.Age < 0)
            {
                return Redirect("/Home/Index");
            }
            if (person.IsBirthday)
            {
                ViewBag.Whishes = "Happy Birthday to you!";
            }

            return View(person);
        }

   
    }
}



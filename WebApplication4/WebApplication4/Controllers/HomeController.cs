using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Jake";
            user.LastName = "Rose";
            user.Age = 40;
            return View(user);


            return View();
            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View(names);
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\rosej\MVClog.txt", text);
            //Random rnd = new Random(10);
            //    var num = rnd.Next();
            //ViewBag.RandomNumber = num;
            //if (num >20000)
            //{
            //    return View("About");
            //}

            //return View();
            //return Content("Hellow.");
            //return RedirectToAction("Contact");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
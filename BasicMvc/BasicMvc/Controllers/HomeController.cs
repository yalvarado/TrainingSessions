using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using BasicMvc.ViewModel;

namespace BasicMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Message = "This is my message";
            return View();
        }

        public ActionResult Index2()
        {
            return View();
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

        public ActionResult DoStuff() 
        {
            return View(new DoStuffViewModel());
        }

        [HttpPost]
        public ActionResult DoStuff(DoStuffViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            ViewBag.Message =$"Your name is {model.Name}";
            return View("Index");
        }

        public ActionResult WorkingWithPartials()
        {
            return View();
        }

        public ActionResult Example()
        {
            var person = new PersonViewModel("John", "Smith");
            return View(new ExampleViewModel("This is my extra property", person));
        }
    }
}
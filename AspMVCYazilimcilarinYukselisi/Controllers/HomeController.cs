using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationForGitSilBunu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Name1"] = "Jhon";
            ViewData["Age1"] = 18;

            ViewBag.Name2 = "Anna";
            ViewBag.Age2 = 25;

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

        public ActionResult Sleep()
        {
            return View();
        }

        public ActionResult Sleep2()
        {
            return View();
        }

        public ActionResult NestedLayoutExample()
        {
            return View();
        }

        public ActionResult HttpHelperExample()
        {
            ViewBag.Name = "Anna";
            ViewBag.Age = 25;
            ViewBag.Check = true;
            ViewBag.listName = new SelectListItem[] {
                new SelectListItem(){Text = "Eylül", Value ="0"},
                new SelectListItem(){Text = "Hale", Value ="1"},
                new SelectListItem(){Text = "Dilşan", Value ="2"}
            };

            return View();
        }


    }
}
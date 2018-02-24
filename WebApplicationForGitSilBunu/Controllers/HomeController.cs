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

        //sfdsfdsfd dasdas  dfsdgsd dsfsdfdsfs 
    }
}
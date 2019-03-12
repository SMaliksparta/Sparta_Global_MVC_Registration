using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimalRegistration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AnimalAbout()
        {
            ViewBag.Message = "about the animal page.";

            return View();
        }

        public ActionResult AnimalFacts()
        {
            ViewBag.Message = "animal fact page.";

            return View();
        }
    }
}
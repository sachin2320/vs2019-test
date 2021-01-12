using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationWithVs2019.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Auto deploy with git and jenkins";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. deployed automatically";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace efcWeb.Controllers
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

        public ActionResult Start()
        {
            return null;
        }

        public ActionResult Stop()
        {
            return null;
        }

        public ActionResult Reverse()
        {
            return null;
        }

        public ActionResult GetFrequency()
        {
            return null;
        }

        public ActionResult SetFrequency(double newFrequency)
        {
            return null;
        }

        public ActionResult Status()
        {
            return null;
        }


    }
}
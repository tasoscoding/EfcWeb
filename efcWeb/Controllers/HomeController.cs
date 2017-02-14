using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace efcWeb.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client;
        public HomeController()
        {
            client = new HttpClient();
        }
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

        public async System.Threading.Tasks.Task<ActionResult> Start()
        {
            var values = new Dictionary<string, string>
            {
                {"command", "start" }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://localhost:64870/api/Operations", content);
            var responseString = await response.Content.ReadAsStringAsync();
            return View();
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
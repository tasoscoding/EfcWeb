using efcWeb.CoreClasses;
using efcWeb.CoreClasses.Engines;
using System;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class OperationsController : ApiController
    {
        private IEngine engine;
        public OperationsController()
        {
            engine = new VegaDrive("/dev/ttyUSB0", 1);
        }

        [HttpGet]
        public IHttpActionResult Action(string command) {
            if (command == "start")
                engine.Start();
            return Ok();
        }
    }
}

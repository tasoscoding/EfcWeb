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
        public HttpResponseMessage Start() {
            engine.Start();
            return Request.CreateResponse(System.Net.HttpStatusCode.OK);
        }
    }
}

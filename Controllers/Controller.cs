using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [ApiController]
    public class Controller : ControllerBase
    {

        [HttpGet]
        [Route("/")]
        public Payload GetString() {
            return new Payload(DateTime.Now, Dns.GetHostName(), "Hello, World");
        }

    }
}

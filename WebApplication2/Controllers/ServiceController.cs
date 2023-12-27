using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class ServiceController : ApiController
    {
        // GET: Service

        public class Greet
        {
            public string Message { get; set; }
        }

        public IHttpActionResult createService()
        {
            return Ok( new Greet() { 
                Message = "Hello World"
            } );
        }
    }
}
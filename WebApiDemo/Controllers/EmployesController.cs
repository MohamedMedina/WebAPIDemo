using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class EmployesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Mohamed Mokhtar", " Mohamed Medina" };
        }
    }
}

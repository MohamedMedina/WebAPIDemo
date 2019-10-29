using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class CustomersController : ApiController
    {

        public IEnumerable<Models.Customer> Get()
        {

            List<Models.Customer> Customers = new List<Controllers.Models.Customer>();
           Customers.Add(new Controllers.Models.Customer() { Id = 1, Name = "Mohamed", Country = "Egypt" });
            Customers.Add(new Controllers.Models.Customer() { Id = 2, Name = "Mona", Country = "Egypt" });
           Customers.Add(new Controllers.Models.Customer() { Id = 3, Name = "ali", Country = "Egypt" });
            return Customers.ToList();
        }
    }
}

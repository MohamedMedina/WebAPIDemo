using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Controllers.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
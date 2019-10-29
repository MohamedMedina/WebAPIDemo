using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class IdemiaController : ApiController

    {
           public IEnumerable<Models.idemia> Get()
            {

                List<Models.idemia> idm = new List<Controllers.Models.idemia>();
                idm.Add(new Controllers.Models.idemia() { id = 1, team = "Car", title = "abbasia" });
                idm.Add(new Controllers.Models.idemia() { id = 2, team = "idf", title = "sheraton" });
                idm.Add(new Controllers.Models.idemia() { id = 3, team = "ghg", title = "hurguhada" });
                return idm.ToList();
            }
       
       
    }
}

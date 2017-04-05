using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebServicesAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ServicesController : ApiController
    {
        [HttpDelete]
        public string DeleteItem(int id)
        {
            return "done";
        }
    }
}
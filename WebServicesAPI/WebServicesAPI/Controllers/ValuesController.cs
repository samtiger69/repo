using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServicesAPI.Models;

namespace WebServicesAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(db.Items.ToList());
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Item value)
        {
            db.Items.Add(value);
            db.SaveChanges();
        }

        // PUT api/values/5
        public void Put([FromBody]Item value)
        {
            db.Entry(value).State = EntityState.Modified;
            db.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

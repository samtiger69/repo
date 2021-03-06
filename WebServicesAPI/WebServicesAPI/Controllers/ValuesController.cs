﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebServicesAPI.Models;

namespace WebServicesAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(db.Items.ToList());
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Ok(db.Items.FirstOrDefault(m => m.Id == id));
        }

        // POST api/valuess
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
        [HttpDelete]
        public string Delete(int id)
        {
            try
            {
                db.Items.Remove(db.Items.FirstOrDefault(m => m.Id == id));
                db.SaveChanges();
                return "Succeeded";
            }
            catch(Exception ex)
            {
                return "Failed";
            }
        }
    }
}

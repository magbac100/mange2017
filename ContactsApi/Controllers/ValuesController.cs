using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactsApi.Models;
namespace ContactsApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/value
        public IEnumerable<string> Get()
        {
            return new string[] { "Sanna", "Magnus" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            person p = new person();
            string pa = p.pers(id);
            return pa;
            //string pa = "lass";
            //return pa;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

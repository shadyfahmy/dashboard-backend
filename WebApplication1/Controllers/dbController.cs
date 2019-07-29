using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;

namespace WebApplication1.Controllers
{
    public class dbController : ApiController
    {

        DBHandler handler;

        public dbController()
        {
            handler = new DBHandler();
        }

        // GET: api/db
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/db/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/db
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/db/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/db/5
        public void Delete(int id)
        {
        }

        [Route("api/DB/GetTest/{id:long}")]
        [HttpGet]
        public DataTable GetTest(long id)
        {
            return handler.GetTest(id);
        }

        [Route("api/DB/GetTest1")]
        [HttpGet]
        public DataTable GetTest1()
        {
            return handler.GetTest1();
        }




        [Route("api/DB/GetCairo")]
        [HttpGet]
        public DataTable GetCairo()
        {
            return handler.GetCairo();
        }
        [Route("api/DB/GetAlex")]
        [HttpGet]
        public DataTable getAlex()
        {
            return handler.GetAlex();
        }
        [Route("api/DB/GetMatrouh")]
        [HttpGet]
        public DataTable GetMatrouh()
        {
            return handler.GetMatrouh();
        }
        [Route("api/DB/GetGiza")]
        [HttpGet]
        public DataTable GetGiza()
        {
            return handler.GetGiza();
        }

    }
}

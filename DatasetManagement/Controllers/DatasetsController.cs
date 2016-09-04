using DatasetManagement.BL;
using DatasetManagement.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatasetManagement.Controllers
{
    public class DatasetsController : ApiController
    {
        private DatasetRepository _DatasetRepo;
        public DatasetsController()
        {
            _DatasetRepo = new DatasetRepository();
        }
        // GET: api/Dataset
        public IHttpActionResult Get()
        {
            var items= _DatasetRepo.Get();

            return Ok(items);
        }

        // GET: api/Dataset/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Dataset
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Dataset/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Dataset/5
        public void Delete(int id)
        {
        }
    }
}

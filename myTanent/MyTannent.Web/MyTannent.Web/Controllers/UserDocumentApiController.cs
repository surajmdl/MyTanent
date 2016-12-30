using MyTanent.DataModel.Model;
using MyTanent.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MyTannent.Web.Controllers
{
    public class UserDocumentApiController : ApiController
    {
        private readonly IUserRepo repository;

        //Inject the DataAccessRepository using Construction Injection 
        public UserDocumentApiController(IUserRepo repo)
        {
            this.repository = repo;
        }

        public UserDocumentApiController() { }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult Post(TanentDocumentsModel model)
        {
            repository.SaveDocuments(model);
            return Ok(model);
        }
    }
}
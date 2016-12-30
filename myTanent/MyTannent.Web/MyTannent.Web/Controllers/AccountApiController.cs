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
    public class AccountApiController : ApiController
    {
        private readonly IUserRepo repository;

        //Inject the DataAccessRepository using Construction Injection 
        public AccountApiController(IUserRepo repo)
        {
            this.repository = repo;
        }

        public AccountApiController() { }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/User/5
        [ResponseType(typeof(UserModel))]
        public IHttpActionResult Get(string id)
        {
            var item = repository.GetUserByUID(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
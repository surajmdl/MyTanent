using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MyTanent.Repository.IRepository;
using MyTanent.DataModel.Model;
using MyTannent.Web.ViewModel;

namespace MyTannent.Web.Controllers
{
    public class UserApiController : ApiController
    {
        private readonly IUserRepo repository;

        //Inject the DataAccessRepository using Construction Injection 
        public UserApiController(IUserRepo repo)
        {
            this.repository = repo;
        }

        public UserApiController() { }

        // GET api/User
        [Route("api/UserApi/GetAllUsers")]
        [ResponseType(typeof(IEnumerable<UserModel>))]
        public IHttpActionResult GetAllUsers(Guid id)
        {
            var list = repository.GetAllById(id);
            return Ok(list.AsEnumerable<UserModel>());
        }

        // GET api/User/5
        [ResponseType(typeof(UserModel))]
        [Route("api/UserApi/GetUser")]
        public IHttpActionResult GetUser(Guid id)
        {
            var item = repository.Get(id);
            item.State = repository.GetStateBySID(Convert.ToInt32(item.State));
            item.City = repository.GetCityByCID(Convert.ToInt32(item.City));

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // GET api/User/5
        [ResponseType(typeof(UserModel))]
        [Route("api/UserApi/GetUserProfile")]
        public IHttpActionResult GetUserProfile(Guid id)
        {
            var item = repository.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // GET api/User/5
        [ResponseType(typeof(TanentDocumentsModel))]
        [Route("api/UserApi/GetUserDocuments")]
        public IHttpActionResult GetUserDocuments(Guid id)
        {
            var item = repository.GetUserDocuments(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // GET api/User/GetCities/5
        [ResponseType(typeof(CityModel))]
        [Route("api/UserApi/GetCities")]
        public IHttpActionResult GetCities(int id)
        {
            var item = repository.GetCities(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // GET api/User/GetCities/5
        [ResponseType(typeof(StateModel))]
        [Route("api/UserApi/GetStates")]
        public IHttpActionResult GetStates(int id)
        {
            var item = repository.GetStates(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // GET api/User/GetStateBySID/5
        [ResponseType(typeof(string))]
        [Route("api/UserApi/GetStateBySID")]
        public IHttpActionResult GetStateBySID(int id)
        {
            var item = repository.GetStateBySID(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // GET api/User/GetCityByCID/5
        [ResponseType(typeof(string))]
        [Route("api/UserApi/GetCityByCID")]
        public IHttpActionResult GetCityByCID(int id)
        {
            var item = repository.GetCityByCID(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        // POST api/User
        [ResponseType(typeof(UserModel))]
        // [Route("api/UserApi/PostUser")]
        public IHttpActionResult Post(UserModel model)
        {
            repository.Post(model);
            return Ok(model);
        }

        // PUT api/User/5
        [ResponseType(typeof(void))]
        //  [Route("api/UserApi/UpdateUser")]
        public IHttpActionResult Put(UserModel model)
        {
            repository.Put(model);
            return Ok(model);
        }

        //// DELETE api/User/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult Delete(int id)
        //{
        //    repository.Delete(id);
        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // DELETE api/User/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Delete(Guid id)
        {
            repository.DeleteUser(id);
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}

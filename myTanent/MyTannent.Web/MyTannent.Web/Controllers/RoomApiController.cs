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
    public class RoomApiController : ApiController
    {
        private readonly IRoomRepo repository;

        //Inject the DataAccessRepository using Construction Injection 
        public RoomApiController(IRoomRepo repo)
        {
            this.repository = repo;
        }

        public RoomApiController() { }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "test";
        //}

        // GET api/User
        [Route("api/RoomApi/GetAllRoomsByUid")]
        [ResponseType(typeof(IEnumerable<RoomModel>))]
        public IHttpActionResult GetAllRoomsByUid(Guid id)
        {
            var list = repository.GetRoomByUID(id);
            return Ok(list.AsEnumerable<RoomModel>());
        }

        // GET api/Room/5
        [ResponseType(typeof(RoomModel))]
        [Route("api/RoomApi/GetAllRoomsByFloor")]
        public IHttpActionResult GetAllRoomsByFloor(int fid, Guid id)
        {
            var item = repository.GetAllRoomsByFloor(fid, id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                return Ok(item);
            }
        }

        [Route("api/RoomApi/GetRoomByRoomId")]
        [ResponseType(typeof(RoomModel))]
        public IHttpActionResult GetRoomByRoomId(Guid id)
        {
            var roomModel = repository.GetByRoomID(id);
            return Ok(roomModel);
        }

        // POST api/RoomApi
        [ResponseType(typeof(RoomModel))]
        public IHttpActionResult Post(RoomModel model)
        {
            repository.Post(model);
            return Ok(model);
        }

        // PUT api/Room/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(Guid id, RoomModel rm)
        {
            repository.Put(id, rm);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE api/<controller>/5
       [ResponseType(typeof(void))]
        public IHttpActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
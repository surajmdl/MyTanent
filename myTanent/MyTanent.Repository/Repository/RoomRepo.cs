using MyTanent.Assembler;
using MyTanent.DataModel.Datamodel;
using MyTanent.DataModel.Model;
using MyTanent.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.Repository.Repository
{
    public class RoomRepo : IRoomRepo
    {
        mytanentEntities entities = new mytanentEntities();
        RoomAssembler assembler = new RoomAssembler();

        /// <summary>
        /// Get rooms by UserId
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public IEnumerable<RoomModel> GetRoomByUID(Guid uid)
        {
            var rooms = (from c in entities.tblRooms.Where(x => x.UserId == uid).OrderBy(x=> x.FloorNumber).ToList() select c);
            return assembler.EntityToModelList(rooms);
        }
        public RoomModel GetAllRoomsByFloor(int fid, Guid uid)
        {
            var lstRoom = (from c in entities.tblRooms.Where(x => x.UserId == uid && x.FloorNumber == fid && x.Status == true).OrderBy(x => x.RoomNumber) select c).ToList();
            var roomList = assembler.EntityToModelList(lstRoom);
            RoomModel roomModel = new RoomModel();
            roomModel.lstRooms = roomList;
            return roomModel;
        }

        public void Post(RoomModel entity)
        {
            entities.tblRooms.Add(assembler.ModelToEntity(entity));
            entities.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var roomsModel = entities.tblRooms.Find(id);
            if (roomsModel != null)
            {
                entities.tblRooms.Remove(roomsModel);
                entities.SaveChanges();
            }
        }

        public IEnumerable<RoomModel> Get()
        {
            throw new NotImplementedException();
        }

        public RoomModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public RoomModel GetByRoomID(Guid rid)
        {
            return assembler.EntityToModel(entities.tblRooms.Where(x => x.Id == rid).FirstOrDefault());
        }


        public void Put(Guid id, RoomModel roomModel)
        {

            var entity = entities.tblRooms.Where(x => x.Id == id).FirstOrDefault();
            entity.Status = (entity.Status == true) ? false : true;
            entities.SaveChanges();
        }


        public void Put(RoomModel entity)
        {
            throw new NotImplementedException();
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

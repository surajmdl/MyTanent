using MyTanent.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.Repository.IRepository
{
   public interface IRoomRepo : IDataAccessRepo<RoomModel, int>
    {
       IEnumerable<RoomModel> GetRoomByUID(Guid uid);
       RoomModel GetAllRoomsByFloor(int fid, Guid uid);
       RoomModel GetByRoomID(Guid rid);
       void Put(Guid id, RoomModel entity);
       void Delete(Guid id);
    }
}

using MyTanent.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.DataModel.Model
{
  public  class RoomModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int? RoomNumber { get; set; }
        public int? FloorNumber { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedOn { get; set; }

        public List<RoomModel> lstRooms { get; set; }

      //  public virtual tblUser tblUser { get; set; }
    }
}

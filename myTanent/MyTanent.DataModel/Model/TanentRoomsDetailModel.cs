using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.DataModel.Model
{
   public class TanentRoomsDetailModel
    {
        public Guid Id { get; set; }
        public string RoomNumber { get; set; }
        public Guid TanentId { get; set; }
        public string SecurityRentPaidAmount { get; set; }

       // public virtual tblUser tblUser { get; set; }
    }
}

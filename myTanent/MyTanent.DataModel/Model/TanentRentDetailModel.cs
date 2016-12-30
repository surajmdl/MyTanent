using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.DataModel.Model
{
    public class TanentRentDetailModel
    {
        public Guid Id { get; set; }
        public Guid TanentId { get; set; }
        public string RoomRentAmount { get; set; }
        public string ElectricityAmount { get; set; }
        public string MaintananceAmount { get; set; }
        public string OtherAmount { get; set; }
        public string PreviousAmount { get; set; }
        public string DiscountAmount { get; set; }
        public string TotalPayableAmount { get; set; }
        public string TotalPaidAmount { get; set; }
        public string RemainingAmount { get; set; }
        public DateTime? PaidDate { get; set; }

      //  public virtual tblUser tblUser { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyTanent.DataModel.Datamodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTanentRentDetail
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> TanentId { get; set; }
        public string RoomRentAmount { get; set; }
        public string ElectricityAmount { get; set; }
        public string MaintananceAmount { get; set; }
        public string OtherAmount { get; set; }
        public string PreviousAmount { get; set; }
        public string DiscountAmount { get; set; }
        public string TotalPayableAmount { get; set; }
        public string TotalPaidAmount { get; set; }
        public string RemainingAmount { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
    
        public virtual tblUser tblUser { get; set; }
    }
}

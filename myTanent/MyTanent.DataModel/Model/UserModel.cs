using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.DataModel.Model
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string EmailId { get; set; }
        public string UserId { get; set; }
        public string password { get; set; }
        public string UserType { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public string PermanentAddress { get; set; }
        public string UserPhoto { get; set; }
        public string AllotedRoomNo { get; set; }
        public string AllotedFloorNo { get; set; }
        public bool RememberMe { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public bool Status { get; set; }

        //public UserModel userModel { get; set; }
        //  public TanentDocumentsModel documents { get; set; }
        public StateModel stateModel { get; set; }
        public CityModel cityModel { get; set; }

        //public List<SelectListItem> lstFloors = new List<SelectListItem>();
        //public List<SelectListItem> lstRooms = new List<SelectListItem>();
        //public List<SelectListItem> lstUserType = new List<SelectListItem>();
        //public List<SelectListItem> lstStates = new List<SelectListItem>();
        //public List<SelectListItem> lstCity = new List<SelectListItem>();


    }
}

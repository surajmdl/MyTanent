using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTanent.DataModel.Model;

namespace MyTannent.Web.ViewModel
{
    public class UserViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Display(Name = "Mobile Number")]
        public string Mobile1 { get; set; }
        [Display(Name = "Alternate Phone Number")]
        public string Mobile2 { get; set; }
        [Display(Name = "Email Id")]
        public string EmailId { get; set; }
        [Display(Name = "User Name")]
        public string UserId { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "User Type")]
        public string UserType { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Locality")]
        public string Locality { get; set; }
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }
        [Display(Name = "Profile Photo")]
        public string UserPhoto { get; set; }
        [Display(Name = "Alloted Room Number")]
        public string AllotedRoomNo { get; set; }
        [Display(Name = "Alloted Floor Number")]
        public string AllotedFloorNo { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Age")]
        public string Age { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        public bool Status { get; set; }

        public int TotalRows { get; set; }
        public int PageSize { get; set; }
        public string SearchText { get; set; }
        public int PageNo { get; set; }
        public int TotalPageNo { get; set; }
        public IEnumerable<UserViewModel> UserList { get; set; }

        public TanentDocumentsModel userDocModel { get; set; }
        public UserModel userModel { get; set; }
        public StateModel stateModel { get; set; }
        public CityModel cityModel { get; set; }
        public RoomModel roomModel { get; set; }

        public List<SelectListItem> lstFloors = new List<SelectListItem>();
        public List<SelectListItem> lstRooms = new List<SelectListItem>();
        public List<SelectListItem> lstUserType = new List<SelectListItem>();
        public List<SelectListItem> lstStates = new List<SelectListItem>();
        public List<SelectListItem> lstCity = new List<SelectListItem>();


        /// <summary>
        /// bind all the floors for loggedin Users
        /// </summary>
        public void bindFloorDDL()
        {
            lstFloors.Add(new SelectListItem { Text = "Select a floor", Value = "0" });
            for (int i = 1; i <= 10; i++)
            {
                string text = "Floor " + i;
                lstFloors.Add(new SelectListItem { Text = text, Value = i.ToString() });
            }
        }

        /// <summary>
        /// bind all the Rooms based on floor for loggedin Users
        /// </summary>
        public void bindRoomsDDL()
        {
            for (int i = 1; i <= 20; i++)
            {
                //string text = i+(i == 1 ? " Room" : " Rooms");
                string text = "Room " + i;
                lstRooms.Add(new SelectListItem { Text = text, Value = i.ToString() });
            }
        }

        public void bindRoomsDDL(List<RoomModel> rooms)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            rooms.ToList().ForEach(s =>
            {
                items.Add(new SelectListItem()
                {
                    Text = s.RoomNumber.ToString(),
                    Value = s.RoomNumber.ToString()
                });
            });
            this.lstRooms = items;
        }

        /// <summary>
        /// bind all the User Types
        /// </summary>
        public void bindUserTypeDDL()
        {
            lstUserType.Add(new SelectListItem { Text = "Select", Value = "" });
            lstUserType.Add(new SelectListItem { Text = UsersType.HouseOwner.ToString(), Value = UsersType.HouseOwner.ToString() });
            lstUserType.Add(new SelectListItem { Text = UsersType.Tanent.ToString(), Value = UsersType.Tanent.ToString() });
        }

        public void bindStateDDL(List<StateModel> states)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            states.ToList().ForEach(s =>
            {
                items.Add(new SelectListItem()
                {
                    Text = s.StateName.ToString(),
                    Value = s.id.ToString()
                });
            });
            this.lstStates = items;
        }

        public void bindCityDDL(List<CityModel> city)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            city.ToList().ForEach(s =>
            {
                items.Add(new SelectListItem()
                {
                    Text = s.CityName.ToString(),
                    Value = s.id.ToString()
                });
            });
            this.lstCity = items;
        }


    }

    public enum UsersType { HouseOwner, Tanent };

    public class LoginViewModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Username is required")]
        public string UserId { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

    }

    public class UserDocumentsUploadFilesResult
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public string Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTanent.DataModel.Model;

namespace MyTannent.Web.ViewModel
{
    public class RoomViewModel
    {
        [Key]
        public System.Guid Id { get; set; }
        public System.Guid UserId { get; set; }

        [Required]
        public int? RoomNumber { get; set; }
        public int? FloorNumber { get; set; }

        public bool Status { get; set; }
        public DateTime? CreatedOn { get; set; }

        public List<RoomModel> listRooms { get; set; }

        public List<SelectListItem> lstFloors = new List<SelectListItem>();

        public int TotalRows { get; set; }
        public int PageSize { get; set; }
        public string SearchText { get; set; }
        public int PageNo { get; set; }
        public int TotalPageNo { get; set; }

        public void bindFloorDDL()
        {
            for (int i = 1; i <= 10; i++)
            {
                //string text = i+(i == 1 ? " Room" : " Rooms");
                string text = "Floor " + i;
                lstFloors.Add(new SelectListItem { Text = text, Value = i.ToString() });
            }
        }


    }
}
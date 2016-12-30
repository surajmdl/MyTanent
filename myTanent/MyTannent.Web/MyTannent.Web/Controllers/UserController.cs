using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyTanent.DataModel.Model;
using MyTannent.Web.Models;
using System.Web.Http.Description;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MyTanent.Repository.Repository;
using MyTannent.Web.ViewModel;
using System.IO;

namespace MyTannent.Web.Controllers
{
    public class UserController : BaseController
    {
        HttpClient client;
        string url = "http://localhost:9900/api/UserApi";
        string Roomurl = "http://localhost:9900/api/RoomApi";
        string docUrl = "http://localhost:9900/api/UserDocumentApi";
        string baseUrl = "http://localhost:9900";

        //The HttpClient Class, this will be used for performing HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        public UserController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public ActionResult Register()
        {
            UserViewModel vmodel = new UserViewModel();
            vmodel.bindUserTypeDDL();
            ViewData["ddlUserType"] = vmodel.lstUserType;
            return View(vmodel);
        }

        [HttpPost, ValidateInput(false)]
        public async Task<ActionResult> Register(UserViewModel model)
        {
            model.CreatedOn = DateTime.Now.ToString();
            model.Id = Guid.NewGuid();
            model.UserId = model.Mobile1;
            HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url, model);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["RegisterSuccessMsg"] = "Registration successfull. Please login with your credentials.";
                return RedirectToAction("Login", "Account");
            }
            return RedirectToAction("Error");
        }

        public async Task<ActionResult> Profile(Guid id)
        {
            UserViewModel viewMOdel = new UserViewModel();
            TanentDocumentsModel docModel = new TanentDocumentsModel();
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/GetUser/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                viewMOdel = JsonConvert.DeserializeObject<UserViewModel>(responseData);
                viewMOdel.bindStateDDL(viewMOdel.stateModel.stateList);

                if (!string.IsNullOrEmpty(viewMOdel.State))
                {
                    viewMOdel.bindCityDDL(viewMOdel.cityModel.cityList);
                }

                HttpResponseMessage DocResponseMessage = await client.GetAsync(url + "/GetUserDocuments/" + id);
                if (DocResponseMessage.IsSuccessStatusCode)
                {
                    var DocResponseData = DocResponseMessage.Content.ReadAsStringAsync().Result;
                    docModel = JsonConvert.DeserializeObject<TanentDocumentsModel>(DocResponseData);
                    viewMOdel.userDocModel = docModel;
                }
                if (!string.IsNullOrEmpty(viewMOdel.UserPhoto))
                {
                    viewMOdel.UserPhoto = viewMOdel.UserPhoto.Replace("~", baseUrl);
                }
                return View(viewMOdel);
            }
            return View("Error");
        }

        public async Task<ActionResult> ProfileView(Guid id)
        {
            UserViewModel viewMOdel = new UserViewModel();
            TanentDocumentsModel docModel = new TanentDocumentsModel();
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/GetUser/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                viewMOdel = JsonConvert.DeserializeObject<UserViewModel>(responseData);
                viewMOdel.State = viewMOdel.State; // need change
                viewMOdel.City = viewMOdel.City; // need change
                HttpResponseMessage DocResponseMessage = await client.GetAsync(url + "/GetUserDocuments/" + id);
                if (DocResponseMessage.IsSuccessStatusCode)
                {
                    var DocResponseData = DocResponseMessage.Content.ReadAsStringAsync().Result;
                    docModel = JsonConvert.DeserializeObject<TanentDocumentsModel>(DocResponseData);
                    viewMOdel.userDocModel = docModel;
                }
                if (!string.IsNullOrEmpty(viewMOdel.UserPhoto))
                {
                    viewMOdel.UserPhoto = viewMOdel.UserPhoto.Replace("~", baseUrl);
                }

                return View(viewMOdel);
            }
            return View("Error");
        }

        [HttpPost]
        public async Task<ActionResult> Profile(UserViewModel viewMOdel, HttpPostedFileBase[] files, HttpPostedFileBase profileImg)
        {
            //HttpPostedFileBase file = Request.Files["ImageData"];
            var r = new List<UserDocumentsUploadFilesResult>();
            viewMOdel.userDocModel = new TanentDocumentsModel();
            viewMOdel.userDocModel.userDocumentList = new List<TanentDocumentsModel>();
            viewMOdel.userModel = new UserModel();

            #region Upload Files
            foreach (HttpPostedFileBase hpf in files)
            {
                TanentDocumentsModel docModel = new TanentDocumentsModel();
                //Checking file is available to save.  
                if (hpf != null)
                {
                    if (hpf.ContentLength == 0)
                        continue;

                    string path = "~/Content/Documents/";
                    string customFileName = Guid.NewGuid() + Path.GetExtension(hpf.FileName);
                    string savedFileName = path + customFileName;
                    string savedFileName2 = Path.Combine(Server.MapPath(path), customFileName);
                    hpf.SaveAs(savedFileName2); // Save the file
                    docModel.Id = Guid.NewGuid();
                    docModel.UserId = Convert.ToString(viewMOdel.Id);
                    docModel.Documents = savedFileName;
                    viewMOdel.userDocModel.userDocumentList.Add(docModel);
                    r.Add(new UserDocumentsUploadFilesResult()
                    {
                        Name = customFileName,
                        Length = hpf.ContentLength,
                        Type = hpf.ContentType
                    });
                }
            }

            if (profileImg != null)
            {
                string path = "~/Content/ProfilePic/";
                if (profileImg.ContentLength == 0)
                {
                    // viewMOdel.UserPhoto = "" ;
                }
                else
                {
                    string imgName = Guid.NewGuid() + Path.GetExtension(profileImg.FileName);
                    string fullPathWithFileName = path + imgName;

                    string path2 = Path.Combine(Server.MapPath(path), imgName);
                    profileImg.SaveAs(path2);

                    // profileImg.SaveAs(Server.MapPath(fullPathWithFileName));
                    //profileImg.SaveAs(HttpContext.Server.MapPath(fullPathWithFileName));
                    viewMOdel.UserPhoto = fullPathWithFileName;
                }
            }

            #endregion

            #region UserModel Data
            viewMOdel.userModel.Id = viewMOdel.Id;
            viewMOdel.userModel.Firstname = viewMOdel.Firstname;
            viewMOdel.userModel.Lastname = viewMOdel.Lastname;
            viewMOdel.userModel.Mobile1 = viewMOdel.Mobile1;
            viewMOdel.userModel.Mobile2 = viewMOdel.Mobile2;
            viewMOdel.userModel.EmailId = viewMOdel.EmailId;
            viewMOdel.userModel.Country = viewMOdel.Country;
            viewMOdel.userModel.State = viewMOdel.State;
            viewMOdel.userModel.City = viewMOdel.City;
            viewMOdel.userModel.Locality = viewMOdel.Locality;
            viewMOdel.userModel.PermanentAddress = viewMOdel.PermanentAddress;
            viewMOdel.userModel.password = viewMOdel.password;
            viewMOdel.userModel.UserPhoto = viewMOdel.UserPhoto;
            viewMOdel.userModel.UserType = viewMOdel.UserType;
            viewMOdel.userModel.AllotedRoomNo = viewMOdel.AllotedRoomNo;
            viewMOdel.userModel.AllotedFloorNo = viewMOdel.AllotedFloorNo;
            #endregion

            HttpResponseMessage responseMessage = await client.PutAsJsonAsync(url, viewMOdel.userModel);
            if (responseMessage.IsSuccessStatusCode)
            {
                HttpResponseMessage DocResponseMessage = await client.PostAsJsonAsync(docUrl, viewMOdel.userDocModel);
                if (DocResponseMessage.IsSuccessStatusCode)
                {
                    TempData["RegisterSuccessMsg"] = "Data has been modified.";
                }
            }

            return RedirectToAction("ProfileView", new { id = viewMOdel.Id });
        }

        public async Task<ActionResult> AddRoom()
        {
            RoomViewModel vmodel = new RoomViewModel();
            vmodel.bindFloorDDL();
            ViewData["ddlFloors"] = vmodel.lstFloors;
            return View(vmodel);
        }

        [HttpPost]
        public async Task<ActionResult> AddRoom(RoomViewModel vmodel)
        {
            if (ModelState.IsValid)
            {
                vmodel.Id = Guid.NewGuid();
                Guid userId = Guid.Parse(Session["Id"].ToString());
                vmodel.UserId = userId;// loggedin user id
                vmodel.CreatedOn = DateTime.Now;
                HttpResponseMessage responseMessage = await client.PostAsJsonAsync(Roomurl, vmodel);
                if (responseMessage.IsSuccessStatusCode)
                {
                    vmodel.bindFloorDDL();
                    ViewData["ddlFloors"] = vmodel.lstFloors;
                    TempData["AddRoomSuccessMsg"] = "New Room Added Successfully.";
                    return View(vmodel);
                }
                return RedirectToAction("Error");
            }
            else
            {
                vmodel.bindFloorDDL();
                ViewData["ddlFloors"] = vmodel.lstFloors;
                return View(vmodel);
            }

        }

        public async Task<ActionResult> Rooms(int page = 1, string sort = "ID", string sortDir = "ASC", string searchText = "")
        {
            const int pageSize = 5;
            var totalRows = 0;
            int totalPage = 0;

            RoomViewModel vmodel = new RoomViewModel();
            vmodel.listRooms = new List<RoomModel>();
            vmodel.bindFloorDDL();
            ViewData["ddlFloors"] = vmodel.lstFloors;
            Guid userId = Guid.Parse(Session["Id"].ToString());
            HttpResponseMessage responseMessage = await client.GetAsync(Roomurl + "/GetAllRoomsByUid/" + userId);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                vmodel.listRooms = JsonConvert.DeserializeObject<List<RoomModel>>(responseData);

                totalRows = vmodel.listRooms.Count;
                totalPage = (totalRows / pageSize) + ((totalRows % pageSize) > 0 ? 1 : 0);
                vmodel.TotalRows = totalRows;
                vmodel.PageSize = pageSize;
                vmodel.PageNo = page;
                vmodel.TotalPageNo = totalPage;

            }
            return View(vmodel);
        }

        public async Task<JsonResult> GetCityByStateID(string id)
        {
            List<SelectListItem> CityList = new List<SelectListItem>();
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/GetCities/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var City = JsonConvert.DeserializeObject<CityModel>(responseData);
                City.cityList.ForEach(x =>
                {
                    CityList.Add(new SelectListItem { Text = x.CityName, Value = x.id.ToString() });
                });
                return Json(CityList, JsonRequestBehavior.AllowGet);
            }
            return Json("Error", JsonRequestBehavior.AllowGet);
        }

    }
}

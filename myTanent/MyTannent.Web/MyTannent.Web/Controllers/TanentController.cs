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
    public class TanentController : Controller
    {
        HttpClient client;
        string TanentUrl = "http://localhost:9900/api/TanentApi";
        string url = "http://localhost:9900/api/UserApi";
        string docUrl = "http://localhost:9900/api/UserDocumentApi";
        string baseUrl = "http://localhost:9900";

        //The HttpClient Class, this will be used for performing HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        public TanentController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        //
        // GET: /Tanent/
        public async Task<ActionResult> Index(int page = 1, string sort = "ID", string sortDir = "ASC", string searchText = "")
        {
            const int pageSize = 5;
            var totalRows = 0;
            int totalPage = 0;
            Guid id = Guid.Parse(Session["Id"].ToString());
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/GetAllUsers/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var Users = JsonConvert.DeserializeObject<List<UserViewModel>>(responseData);

                totalRows = Users.Count;
                totalPage = (totalRows / pageSize) + ((totalRows % pageSize) > 0 ? 1 : 0);
                var data = new UserViewModel()
                {
                    TotalRows = totalRows,
                    PageSize = pageSize,
                    PageNo = page,
                    TotalPageNo = totalPage,
                    UserList = Users
                };
                return View(data);
            }
            return View("Error");
        }

        private static Random random = new Random();
        public static string GenerateString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpGet]
        public async Task<ActionResult> AddTanent()
        {
            // Guid userId = Guid.Parse(Session["Id"].ToString()); // loggedin userid
            int countryId = 1; // india country id
            UserViewModel vmodel = new UserViewModel();
            TanentDocumentsModel docModel = new TanentDocumentsModel();
            StateModel smodel = new StateModel();
            smodel.stateList = new List<StateModel>();
            HttpResponseMessage responseMessage = await client.GetAsync(url + "/GetStates/" + countryId);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                vmodel.stateModel = JsonConvert.DeserializeObject<StateModel>(responseData);
                vmodel.bindStateDDL(vmodel.stateModel.stateList);
            }
            vmodel.UserType = "Tanent";
            vmodel.bindFloorDDL();
            vmodel.bindRoomsDDL();
            ViewData["ddlFloors"] = vmodel.lstFloors;
            ViewData["ddlRooms"] = vmodel.lstRooms;
            return View(vmodel);
        }


        [HttpPost]
        public async Task<ActionResult> AddTanent(UserViewModel viewMOdel, HttpPostedFileBase[] files, HttpPostedFileBase profileImg)
        {
            Guid userId = Guid.Parse(Session["Id"].ToString());

            var r = new List<UserDocumentsUploadFilesResult>();
            viewMOdel.userDocModel = new TanentDocumentsModel();
            viewMOdel.userDocModel.userDocumentList = new List<TanentDocumentsModel>();
            viewMOdel.userModel = new UserModel();
            viewMOdel.CreatedOn = DateTime.Now.ToString();
            viewMOdel.CreatedBy = userId.ToString(); // Landlord loggedin Id
            viewMOdel.Id = Guid.NewGuid();
            viewMOdel.UserId = viewMOdel.Mobile1;
            viewMOdel.password = GenerateString(5);
            viewMOdel.Status = true;
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
            viewMOdel.userModel.UserId = viewMOdel.UserId;
            viewMOdel.userModel.password = viewMOdel.password;
            viewMOdel.userModel.UserPhoto = viewMOdel.UserPhoto;
            viewMOdel.userModel.UserType = viewMOdel.UserType;
            viewMOdel.userModel.AllotedRoomNo = viewMOdel.AllotedRoomNo;
            viewMOdel.userModel.AllotedFloorNo = viewMOdel.AllotedFloorNo;
            viewMOdel.userModel.CreatedBy = viewMOdel.CreatedBy;
            viewMOdel.userModel.CreatedOn = viewMOdel.CreatedOn;
            viewMOdel.userModel.Status = viewMOdel.Status;

            #endregion



            HttpResponseMessage responseMessage = await client.PostAsJsonAsync(url, viewMOdel.userModel);
            if (responseMessage.IsSuccessStatusCode)
            {
                HttpResponseMessage DocResponseMessage = await client.PostAsJsonAsync(docUrl, viewMOdel.userDocModel);
                if (DocResponseMessage.IsSuccessStatusCode)
                {
                    TempData["TanentRegisterSuccessMsg"] = "New Tanent Added Successfully. Userid and Password sent to Tanent Mobile Number.";
                }
            }
            return RedirectToAction("Index");
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

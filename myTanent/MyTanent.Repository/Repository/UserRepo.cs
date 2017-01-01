using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTanent.Repository.IRepository;
using MyTanent.DataModel.Datamodel;
using MyTanent.DataModel.Model;
using MyTanent.Assembler;
using System.Data.Entity.Validation;

namespace MyTanent.Repository.Repository
{
    public class UserRepo : IUserRepo
    {
        mytanentEntities entities = new mytanentEntities();
        UserAssembler assembler = new UserAssembler();
        CommonAssembler commonAssembler = new CommonAssembler();

        public IEnumerable<UserModel> Get()
        {
            var usrModel = entities.tblUsers.ToList();
            return assembler.EntityToModelList(usrModel);
        }

        public IEnumerable<UserModel> GetAllById(Guid id)
        {
            string userid = id.ToString();
            var usrModel = (from c in entities.tblUsers.Where(x => x.CreatedBy == userid).OrderBy(x => x.CreatedOn) select c).ToList();
            return assembler.EntityToModelList(usrModel);
        }

        public UserModel Get(Guid id)
        {
            ///Get States
            var lstState = (from c in entities.tblStates.Where(x => x.IsActive == true).OrderBy(x => x.StateName) select c).ToList();
            var stateList = commonAssembler.StateEntityToModelList(lstState);

            ///Get Main User Data
            var result = assembler.EntityToModel(entities.tblUsers.Find(id));

            ///Get City
            if (!string.IsNullOrEmpty(result.State))
            {
                int stateId = Convert.ToInt32(result.State); // Get StateId for corresponding City
                var lstCity = (from c in entities.tblCities.Where(x => x.StateId == stateId && x.IsActive == true).OrderBy(x => x.CityName) select c).ToList();
                var cityList = commonAssembler.CityEntityToModelList(lstCity);
                result.cityModel = new CityModel();
                result.cityModel.cityList = cityList;
            }

            ///Bind States and City 
            result.stateModel = new StateModel();
            result.stateModel.stateList = stateList;

            return result;
        }
        public TanentDocumentsModel GetUserDocuments(Guid id)
        {
            TanentDocumentsModel model = new TanentDocumentsModel();
            model.userDocumentList = new List<TanentDocumentsModel>();
            var list = (from c in entities.tblTanentDocuments.Where(x => x.UserId == id) select c).ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                TanentDocumentsModel Tmodel = new TanentDocumentsModel();
                Tmodel.Id = list[i].Id;
                Tmodel.UserId = list[i].UserId.ToString();
                Tmodel.Documents = list[i].Documents;
                model.userDocumentList.Add(Tmodel);
            }
            return model;
        }

        public CityModel GetCities(int id)
        {
            var lstCity = (from c in entities.tblCities.Where(x => x.StateId == id && x.IsActive == true).OrderBy(x => x.CityName) select c).ToList();
            var cityList = commonAssembler.CityEntityToModelList(lstCity);
            CityModel cityModel = new CityModel();
            cityModel.cityList = cityList;
            return cityModel;
        }

        public StateModel GetStates(int id)
        {
            var lstState = (from c in entities.tblStates.Where(x => x.CountryId == id && x.IsActive == true).OrderBy(x => x.StateName) select c).ToList();
            var stateList = commonAssembler.StateEntityToModelList(lstState);
            StateModel stateModel = new StateModel();
            stateModel.stateList = stateList;
            return stateModel;
        }

        public UserModel GetUserByUID(string uid)
        {
            return assembler.EntityToModel(entities.tblUsers.Where(x => x.UserId == uid).FirstOrDefault());
        }

        public void Post(UserModel entity)
        {
            entities.tblUsers.Add(assembler.ModelToEntity(entity));
            entities.SaveChanges();
        }

        public void SaveDocuments(TanentDocumentsModel model)
        {
            for (int i = 0; i < model.userDocumentList.Count; i++)
            {
                try
                {
                    entities.tblTanentDocuments.Add(assembler.ModelToEntityForDocuments(model.userDocumentList[i]));
                    entities.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    //foreach (var eve in e.EntityValidationErrors)
                    //{
                    //    string a = eve.Entry.Entity.GetType().Name.ToString();
                    //    foreach (var ve in eve.ValidationErrors)
                    //    {
                    //        string c = ve.PropertyName.ToString();
                    //        string d = ve.ErrorMessage.ToString();
                    //    }
                    //}
                    throw;
                }

            }
        }

        public void Put(UserModel entity)
        {
            var usrModel = entities.tblUsers.Find(entity.Id);
            if (usrModel != null)
            {
                //usrModel.Id = entity.Id;
                usrModel.Firstname = entity.Firstname;
                usrModel.Lastname = entity.Lastname;
                usrModel.Mobile1 = entity.Mobile1;
                usrModel.Mobile2 = entity.Mobile2;
                usrModel.EmailId = entity.EmailId;
                usrModel.Country = entity.Country;
                usrModel.State = entity.State;
                usrModel.City = entity.City;
                usrModel.Locality = entity.Locality;
                usrModel.PermanentAddress = entity.PermanentAddress;
                usrModel.password = entity.password;
                usrModel.UserPhoto = entity.UserPhoto;
               // usrModel.UserType = entity.UserType;
                usrModel.AllotedRoomNo = entity.AllotedRoomNo;
                usrModel.AllotedFloorNo = entity.AllotedFloorNo;
                entities.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var usrModel = entities.tblUsers.Find(id);
            if (usrModel != null)
            {
                entities.tblUsers.Remove(usrModel);
                entities.SaveChanges();
            }
        }

        public UserModel GetUserByUserName(string userName)
        {
            //var user = assembler.AssembleEntityToUserModel(entities.tblUsers.Where(m => m.UserName == userName).FirstOrDefault());
            //if (user != null)
            //{
            //    return user;
            //}
            //else
            //{
            return null;
            //}
        }

        public List<UserModel> GetUsers()
        {
            var list = entities.tblUsers.ToList();
            // return assembler.AssembleEntityToUserModelList(list);
            return null;
        }

        public UserModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteUser(Guid uid)
        {
            var usrModel = entities.tblUsers.Find(uid);
            var result = 1;
            if (usrModel != null)
            {
                var docModel = entities.tblTanentDocuments.Where(x=> x.UserId== uid).ToList();
                foreach (var item in docModel)
                {
                    entities.tblTanentDocuments.Remove(item);
                }
                entities.tblUsers.Remove(usrModel);
                result = entities.SaveChanges();
                return result;
            }
            return result;
        }


        public string GetStateBySID(int id)
        {
            return entities.tblStates.Find(id).StateName;
        }

        public string GetCityByCID(int id)
        {
            return entities.tblCities.Find(id).CityName;
        }

        public string GetCountryByConID(int conId)
        {
            throw new NotImplementedException();
        }
    }
}

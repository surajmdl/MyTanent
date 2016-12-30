using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTanent.DataModel.Model;

namespace MyTanent.Repository.IRepository
{
   public interface IUserRepo : IDataAccessRepo<UserModel, int>
    {
       // List<TopicsModel> GetTopics();
        //void AddTopic(TopicsModel model);
       UserModel Get(Guid id);
       UserModel GetUserByUID(string uid);
       CityModel GetCities(int id);
       void SaveDocuments(TanentDocumentsModel model);
       TanentDocumentsModel GetUserDocuments(Guid id);
       IEnumerable<UserModel> GetAllById(Guid id);
       StateModel GetStates(int id);
       int DeleteUser(Guid uid);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTanent.DataModel.Datamodel;
using MyTanent.DataModel.Model;
using AutoMapper;

namespace MyTanent.Assembler
{
   public class UserAssembler
    {
        public tblUser ModelToEntity(UserModel model)
        {
            return Mapper.Map<UserModel, tblUser>(model);        
        }

        public UserModel EntityToModel(tblUser model)
        {
            return Mapper.Map<tblUser, UserModel>(model);
        }

        public IEnumerable<tblUser> ModelToEntityList(List<UserModel> model)
        {
           // return Mapper.Map<List<UserModel>, IEnumerable<tblUser>>(model);
            return null;
        }

        public List<UserModel> EntityToModelList(IEnumerable<tblUser> model)
        {
            return Mapper.Map<IEnumerable<tblUser>, List<UserModel>>(model);
        }

        public tblTanentDocument ModelToEntityForDocuments(TanentDocumentsModel model)
        {
            return Mapper.Map<TanentDocumentsModel, tblTanentDocument>(model);
        }

    }
}

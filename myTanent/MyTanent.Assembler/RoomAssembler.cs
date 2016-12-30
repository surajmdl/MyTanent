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
   public class RoomAssembler
    {
        public tblRoom ModelToEntity(RoomModel model)
        {
            return Mapper.Map<RoomModel, tblRoom>(model);

        }

        public RoomModel EntityToModel(tblRoom model)
        {
            return Mapper.Map<tblRoom, RoomModel>(model);
        }

        public IEnumerable<tblRoom> ModelToEntityList(List<RoomModel> model)
        {
            // return Mapper.Map<List<RoomModel>, IEnumerable<tblRoom>>(model);
            return null;
        }

        public List<RoomModel> EntityToModelList(IEnumerable<tblRoom> model)
        {
            return Mapper.Map<IEnumerable<tblRoom>, List<RoomModel>>(model);
        }

    }
}

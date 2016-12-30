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
    public class CommonAssembler
    {
        public IEnumerable<tblState> StateModelToEntityList(List<StateModel> model)
        {
            return Mapper.Map<List<StateModel>, IEnumerable<tblState>>(model);
        }

        public List<StateModel> StateEntityToModelList(IEnumerable<tblState> model)
        {
            return Mapper.Map<IEnumerable<tblState>, List<StateModel>>(model);
        }

        public IEnumerable<tblCity> CityModelToEntityList(List<CityModel> model)
        {
            return Mapper.Map<List<CityModel>, IEnumerable<tblCity>>(model);
        }

        public List<CityModel> CityEntityToModelList(IEnumerable<tblCity> model)
        {
            return Mapper.Map<IEnumerable<tblCity>, List<CityModel>>(model);
        }

        //public IEnumerable<tblState> StateModelToEntityList(List<StateModel> model)
        //{
        //    return Mapper.Map<List<StateModel>, IEnumerable<tblState>>(model);
        //}

        //public List<StateModel> StateEntityToModelList(IEnumerable<tblState> model)
        //{
        //    return Mapper.Map<IEnumerable<tblState>, List<StateModel>>(model);
        //}
    }
}

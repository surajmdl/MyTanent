using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.DataModel.Model
{
    public class StateModel
    {
        public int id { get; set; }
        public string StateName { get; set; }
        public int? CountryId { get; set; }
        public bool? IsActive { get; set; }

        public List<StateModel> stateList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.DataModel.Model
{
    public class CityModel
    {
        public int id { get; set; }
        public string CityName { get; set; }
        public int? StateId { get; set; }
        public bool? IsActive { get; set; }

        public List<CityModel> cityList { get; set; }
    }
}

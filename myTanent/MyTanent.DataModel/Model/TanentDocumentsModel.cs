using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTanent.DataModel.Model
{
   public class TanentDocumentsModel
    {
        public Guid Id { get; set; }
        public string Documents { get; set; }
        public string UserId { get; set; }

        public List<TanentDocumentsModel> userDocumentList { get; set; }

        //public virtual tblUser tblUser { get; set; }
    }
}

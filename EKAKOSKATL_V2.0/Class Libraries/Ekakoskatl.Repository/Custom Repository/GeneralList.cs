using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekakoskatl.Repository.Custom_Repository
{
    public class GeneralList
    {
        public int GeneralID { get; set; }
        public Guid? GeneralGUID { get; set; }
        public string GeneralName { get; set; }

        public GeneralList(int generalID, string generalName, Nullable<Guid> generalGUID = null)
        {
            GeneralID = generalID;
            GeneralName = generalName;
            GeneralGUID = generalGUID;
        }
    }
}

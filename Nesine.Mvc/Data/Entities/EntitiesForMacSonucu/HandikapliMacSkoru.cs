using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nesine.Mvc.Data.Entities
{
    public class HandikapliMacSkoru : BaseEntity
    {
        public string HandicapTur { get; set; }    //  1:0/0:1/0:2 olabilir.
        public decimal Hms1 { get; set; }
        public decimal HmsX { get; set; }
        public decimal Hms2 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nesine.Mvc.Data
{
    public abstract class BaseEntity
    {
        public virtual int BetId { get; set; }    
        public virtual string BetName { get; set; }
        public virtual int EnAzOynanabilecekMacSayisi { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nesine.Mvc.Data.Entities
{
    public class MacSonucu
    {
        public MacSonuc MacSonuc { get; set; }
        public CifteSans CifteSans { get; set; }
        public HandikapliMacSkoru HandikapliMacSkoru { get; set; }
        public IlkYariVeMacSonucu IlkYariVeMacSonucu { get; set; }
        public MacSonucuVeBirBucukAltUst MacSonucuVeBirBucukAltUst { get; set; }
        public MacSonucuVeIkiBucukAltUst MacSonucuVeIkiBucukAltUst { get; set; }
        public MacSonucuVeUcBucukAltUst MacSonucuVeUcBucukAltUst { get; set; }
        public MacSonucuVeDortBucukAltUst MacSonucuVeDortBucukAltUst { get; set; }
    }
}

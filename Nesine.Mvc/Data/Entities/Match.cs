using Nesine.Mvc.Data.Entities.EntitiesForGol;
using Nesine.Mvc.Data.Entities.EntitiesForMacSkoru;
using Nesine.Mvc.Data.Entities.EntitiesForMacSonucuAltUst;
using Nesine.Mvc.Data.Entities.EntitiesForOlaylar;
using Nesine.Mvc.Data.Entities.EntitiesForTarafAltUst;
using Nesine.Mvc.Data.Entities.EntitiesForToplamGol;
using Nesine.Mvc.Data.Entities.EntitiesForYariAltUst;
using Nesine.Mvc.Data.Entities.EntitiesForYariSonucu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nesine.Mvc.Data.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public bool CanliBahisOynanabilir { get; set; }
        public bool NesinedeCanliYayinlanacak { get; set; }
        public string MacDurum { get; set; }    // baslamadı, oynanıyor, bitti    => MacDurum Bitti olanlar ekranda gozukmucek
        public int MactaGecenDakika { get; set; }     //Mac baslamadı ise 0 dakika mac bitmis ise 90 + uzatmalar seklinde kayıtlı tutulacak
        public string LeftTeamName { get; set; }
        public int? LeftTeamScore { get; set; }     //mac baslamadıgında degerı null olucak
        public int? RightTeamScore { get; set; }    //mac baslamadıgında degerı null olucak
        public DateTime MacZamanı { get; set; }     //Mac gunu ve saati ayrı ayrı gerekli olacak
        public MacSonucu MacSonucu { get; set; }
        public YariSonucu YariSonucu { get; set; }
        public YariAltUst YariAltUst { get; set; }
        public Gol Gol { get; set; }
        public Olaylar Olaylar { get; set; }
        public MacSkoru MacSkoru { get; set; }
        public MacSonucuAltUst MacSonucuAltUst { get; set; }
        public TarafAltUst TarafAltUst { get; set; }
        public ToplamGol ToplamGol { get; set; }
    }
}

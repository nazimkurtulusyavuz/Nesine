using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nesine.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Nesine.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)    // todo: database enjecte edilecek.
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var liglerWithMatches = db.Leagues.Include(x => x.Matches).Where(match => match.MacDurum =! Bitti).ThenInclude(x => x.Gol)         //Tum maclarda where sartı olması gerekıyor
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSkoru)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.MacSonuc)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.CifteSans)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.HandikapliMacSkoru)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.IlkYariVeMacSonucu)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.MacSonucuVeBirBucukAltUst)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.MacSonucuVeIkiBucukAltUst)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.MacSonucuVeUcBucukAltUst)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucu).ThenInclude(x => x.MacSonucuVeDortBucukAltUst)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.MacSonucuAltUst)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.Olaylar)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.TarafAltUst)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.ToplamGol)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.YariAltUsr)
            //                                  .Include(x => x.Matches).ThenInclude(x => x.YariSonucu)
            return View(/*liglerWithMatches*/);       // View'de datatable kullan - @model List<League> bekleyecek. 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;
using static RS1_Ispit_asp.net_core.ViewModels.AjaxIndexVM;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class AjaxController : Controller
    {
        public AjaxController(MojContext db)
        {
            this.db = db;
        }
        public MojContext db { get; }
        public IActionResult Index(int TkmID)
        {
            AjaxIndexVM model = new AjaxIndexVM
            {
                TakmID = TkmID,
                Zakljucano = db.Takmicenje.Where(x=>x.TakmicenjeID==TkmID).Select(s=>s.Zakljucaj).FirstOrDefault(),
                podaci = db.TakmicenjeUcesnik.Where(x=>x.TakmicenjeID==TkmID).Select(s=> new RowAjax { 
                    bodovi = s.Bodovi,
                    BrDnevnik = s.OdjeljenjeStavka.BrojUDnevniku,
                    Odjeljenje = s.OdjeljenjeStavka.Odjeljenje.Oznaka,
                    Pristupio = s.Pristupio,
                    TakmicenjeUcesnikID = s.TakmicenjeUcesnikID
                }).ToList()
            };
            return PartialView(model);
        }
        public IActionResult UcenikJePristupio(int TkmUcID)
        {
            var tkm = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == TkmUcID).Select(x=>x.TakmicenjeID).FirstOrDefault();
            var ucenik = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == TkmUcID).FirstOrDefault();
            ucenik.Pristupio = false;
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultati?TkmID=" + tkm);
        }
        public IActionResult UcenikNijePristupio(int TkmUcID)
        {
            var tkm = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == TkmUcID).Select(x => x.TakmicenjeID).FirstOrDefault();
            var ucenik = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == TkmUcID).FirstOrDefault();
            ucenik.Pristupio = true;
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultati?TkmID=" + tkm);
        }
        public IActionResult DodajUcesnika(int TkmID)
        {
            var tkm = db.Takmicenje.Where(x => x.TakmicenjeID == TkmID).FirstOrDefault();
            var ucenici = db.DodjeljenPredmet.Where(x => x.PredmetId == tkm.PredmetID &&
                x.ZakljucnoKrajGodine == 5).Select(x => x.OdjeljenjeStavka);
            AjaxUcesnikVM model = new AjaxUcesnikVM
            {
                TakmID = TkmID,
                bodovi = 0,
                Ucesnici = ucenici.Select(s=> new SelectListItem { 
                    Text = s.Odjeljenje.Oznaka + "-" + s.Ucenik.ImePrezime +
                    "-" + s.BrojUDnevniku,
                    Value = s.Id.ToString()
                }).ToList(),
                UcesnikID = 0
            };
            return PartialView(model);
        }
        public IActionResult Snimi(AjaxUcesnikVM podaci)
        {
            TakmicenjeUcesnik newUcesnik = new TakmicenjeUcesnik
            {
                Bodovi = podaci.bodovi,
                OdjeljenjeStavkaID = podaci.UcesnikID,
                Pristupio = true,
                TakmicenjeID = podaci.TakmID, 
            };
            db.TakmicenjeUcesnik.Add(newUcesnik);
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultati?TkmID=" + podaci.TakmID);
        }
        public IActionResult Uredi(int TkmUcID)
        {
            AjaxUrediVM model = new AjaxUrediVM
            {
                UcesnikID = TkmUcID,
                Ucesnik = db.TakmicenjeUcesnik.Where(x=>x.TakmicenjeUcesnikID==TkmUcID).Select(x=>
                    x.OdjeljenjeStavka.Odjeljenje.Oznaka + "-" + x.OdjeljenjeStavka.Ucenik.ImePrezime + "-" + 
                    x.OdjeljenjeStavka.BrojUDnevniku).FirstOrDefault()
            };
            return PartialView(model);
        }
        public IActionResult SnimiUredi(AjaxUrediVM podaci)
        {
            var tkm = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == podaci.UcesnikID).Select(x => x.TakmicenjeID).FirstOrDefault();
            var ucenik = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == podaci.UcesnikID).FirstOrDefault();
            ucenik.Bodovi = podaci.bodovi;
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultati?TkmID=" + tkm);
        }
        public IActionResult UpdateBodova(int UcesnikID, int bod)
        {
            var tkm = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == UcesnikID).Select(x => x.TakmicenjeID).FirstOrDefault();
            var ucenik = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeUcesnikID == UcesnikID).FirstOrDefault();
            ucenik.Bodovi = bod;
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultati?TkmID=" + tkm);
        }
    }
    
}

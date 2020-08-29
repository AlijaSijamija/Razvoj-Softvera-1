using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;
using static RS1_Ispit_asp.net_core.ViewModels.AjaxPrikazVM;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class AjaxController : Controller
    {
        public AjaxController(MojContext db)
        {
            this.db = db;
        }
        public MojContext db { get; }
        public IActionResult UcesniciTakmicenja(int tkmID)
        {
            AjaxPrikazVM model = new AjaxPrikazVM
            {
                TakmicenjeID = tkmID,
                Zakljucano = db.Takmicenje.Where(t=>t.TakmicenjeID==tkmID).Select(s=>s.Zakljucano).FirstOrDefault(),
                redovi = db.TakmicenjeUcesnik.Where(t => t.TakmicenjeID == tkmID).Select(s => new Row
                {
                    TakmicenjeUcesnikID = s.TakmicenjeUcesnikID,
                    Bodovi =s.Bodovi.ToString() ?? "X",
                    BrUDnevniku = s.OdjeljenjeStavka.BrojUDnevniku,
                    Odjeljenje = s.OdjeljenjeStavka.Odjeljenje.Oznaka,
                    Pristupio = s.IsPristupio
                }).ToList()
            };
            return PartialView(model);
        }
        public IActionResult UcesnikNijePrisutpio(int ucesnikID)
        {
            var ucesnik = db.TakmicenjeUcesnik.Find(ucesnikID);
            ucesnik.IsPristupio = false;
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultat?tkmID=" + ucesnik.TakmicenjeID);
        }
        public IActionResult UcesnikJePristupio(int ucesnikID)
        {
            var ucesnik = db.TakmicenjeUcesnik.Find(ucesnikID);
            ucesnik.IsPristupio = true;
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultat?tkmID=" + ucesnik.TakmicenjeID);
        }
        public IActionResult DodajUcesnika(int tkmID)
        {
            AjaxDodajVM model = new AjaxDodajVM
            {
                TakmicenjeID = tkmID,
                bodovi = 0,
                Ucenici = db.OdjeljenjeStavka.Include(x=>x.Odjeljenje).Select(s=> new SelectListItem {
                    Value = s.UcenikId.ToString(),
                    Text = (s.Odjeljenje.Oznaka + "-" + s.Ucenik.ImePrezime).ToString()
                }).ToList()
            };
            return PartialView(model);
        }
        public IActionResult Snimi(AjaxDodajVM podaci)
        {
            var ListaUcesnika = db.TakmicenjeUcesnik.Where(t => t.TakmicenjeID == podaci.TakmicenjeID).
                Select(s => s.OdjeljenjeStavka.UcenikId).ToList();
            int br = 0;
            foreach(var x in ListaUcesnika)
            {
                if (x == podaci.UcenikID) br++;
            }
            if (br == 0)
            {
                TakmicenjeUcesnik newUcesnik = new TakmicenjeUcesnik
                {
                    TakmicenjeID = podaci.TakmicenjeID,
                    Bodovi = podaci.bodovi,
                    IsPristupio = true,
                    OdjeljenjeStavkaID = db.OdjeljenjeStavka.Where(o => o.UcenikId == podaci.UcenikID)
                    .Select(s => s.Id).FirstOrDefault()
                };
                db.TakmicenjeUcesnik.Add(newUcesnik);
            }
            else
            {
                var ucesnik = db.TakmicenjeUcesnik.Where(t=>t.OdjeljenjeStavka.UcenikId==podaci.UcenikID).FirstOrDefault();
                ucesnik.Bodovi = podaci.bodovi;
                ucesnik.IsPristupio = true;
            }
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultat?tkmID=" + podaci.TakmicenjeID);
        }
        public IActionResult Uredi(int ucesnikID)
        {
            AjaxDodajVM model = new AjaxDodajVM
            {
                TakmicenjeID = db.TakmicenjeUcesnik.Where(t=>t.TakmicenjeUcesnikID==ucesnikID).Select(s=>s.TakmicenjeID).FirstOrDefault(),
                bodovi = 0,
                Ucenici = db.OdjeljenjeStavka.Select(s => new SelectListItem
                {
                    Value = s.UcenikId.ToString(),
                    Text = s.Odjeljenje.Oznaka + "-" + s.Ucenik.ImePrezime
                }).ToList(),
                UcenikID = db.TakmicenjeUcesnik.Find(ucesnikID).TakmicenjeUcesnikID
            };
            return PartialView("DodajUcesnika", model);
        }
        public IActionResult UpdateBod(int ucesnikID,int bodovi)
        {
            var ucesnik = db.TakmicenjeUcesnik.Find(ucesnikID);
            ucesnik.Bodovi = bodovi;
            ucesnik.IsPristupio = true;
            db.SaveChanges();
            return Redirect("/Takmicenje/Rezultat?tkmID=" + ucesnik.TakmicenjeID);
        }
    }
}

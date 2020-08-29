using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;
using static RS1_Ispit_asp.net_core.ViewModels.AjaxPrikazVM;
using static RS1_Ispit_asp.net_core.ViewModels.ONIndexVM;
using static RS1_Ispit_asp.net_core.ViewModels.ONPrikazVM;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class OdrzanaNastavaController : Controller
    {
        public OdrzanaNastavaController(MojContext db)
        {
            this.db = db;
        }
        public MojContext db { get; }
        public IActionResult Index()
        {
            ONIndexVM model = new ONIndexVM
            {
                podaci = db.Nastavnik.Select(s=> new RowIndex { 
                    NastavnikaID = s.Id,
                    Nastavnik = s.Ime + " " + s.Prezime,
                    Skola = db.Odjeljenje.Where(o=>o.RazrednikID==s.Id).Select(o=>o.Skola.Naziv).FirstOrDefault()
                }).ToList()
            };
            return View(model);
        }
        public IActionResult Prikaz(int NastavnikID)
        {
            ONPrikazVM model = new ONPrikazVM
            {
                NastavnikID = NastavnikID,
                podaci = db.MaturskiIspit.Where(m => m.NastavnikID == NastavnikID).Select(s => new RowPrikaz
                {
                    MaturskiIspitID = s.MaturskiIspitID,
                    Datum = s.Datum,
                    Predmet = s.Predmet.Naziv,
                    Skola = s.Skola.Naziv,
                    Ucenici = db.MaturskiIspitUcesnik.Where(u=>u.MaturskiIspitID==s.MaturskiIspitID).Select(n=> new SelectListItem
                    {
                        Text = n.OdjeljenjeStavka.Ucenik.ImePrezime,
                        Value = n.OdjeljenjeStavka.Ucenik.Id.ToString()
                    }).ToList()
                }).ToList()
            };
            return View(model);
        }
        public  IActionResult Uredi(int MaturskiID)
        {
            var ispit = db.MaturskiIspit.Include(x=>x.Predmet).Where(x => x.MaturskiIspitID == MaturskiID).FirstOrDefault();
            ONUrediVM model =  new ONUrediVM
            {
                MaturskiIspitID = ispit.MaturskiIspitID,
                Datum = ispit.Datum,
                PredmetID = ispit.PredmetID,
                Predmet = ispit.Predmet.Naziv,
                Napomena = ispit.Napomena
            };
            return View(model);
        }
        public IActionResult SnimiUredi(ONUrediVM podaci)
        {
            var ispit = db.MaturskiIspit.Find(podaci.MaturskiIspitID);
            ispit.Napomena = podaci.Napomena;
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Uredi?MaturskiID=" + podaci.MaturskiIspitID);
        }
        public IActionResult Dodaj(int nastavnikId)
        {
            ONDodajVM model = new ONDodajVM
            {
                NastavnikID = nastavnikId,
                Nastavnik = db.Nastavnik.Where(x=>x.Id==nastavnikId).Select(s=>s.Ime + " " + s.Prezime).FirstOrDefault(),
                Predmeti = db.Predmet.Select(s=> new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Naziv
                }).ToList(),
                Skole = db.Skola.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Naziv
                }).ToList(),
                SkolskaGodina = db.SkolskaGodina.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Naziv
                }).ToList(),
            };
            return View(model);
        }
        public IActionResult Snimi(ONDodajVM podaci)
        {
            MaturskiIspit newIspit = new MaturskiIspit
            {
                PredmetID = podaci.PredmetID,
                Datum = podaci.Datum,
                NastavnikID = podaci.NastavnikID,
                SkolaID = podaci.SkolaID,
                SkolskaGodinaID = podaci.SkolskaGodinaID
                
            };
            db.MaturskiIspit.Add(newIspit);
            var ucesnici = db.OdjeljenjeStavka.Include(x => x.Odjeljenje).Where(x => x.Odjeljenje.Razred == 4);
            foreach (var x in ucesnici)
            {
                if (db.DodjeljenPredmet.Where(d => d.OdjeljenjeStavkaId == x.Id).Count(s => s.ZakljucnoKrajGodine == 1) == 0)
                {
                    MaturskiIspitUcesnik newUcesnik = new MaturskiIspitUcesnik
                    {
                        MaturskiIspit = newIspit,
                        Pristupio = false,
                        Uslov = true,
                        OdjeljenjeStavkaID = x.Id,
                        ProsjekOcjena = db.DodjeljenPredmet.Where(d => d.OdjeljenjeStavkaId == x.Id).Average(s=>s.ZakljucnoKrajGodine),
                        Bodovi =0
                        
                    };
                    db.MaturskiIspitUcesnik.Add(newUcesnik);
                }
            }
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Prikaz?NastavnikID=" + podaci.NastavnikID);
        }
        public IActionResult AjaxPrikaz(int IspitID)
        {
            AjaxPrikazVM model = new AjaxPrikazVM
            {
                MaturskiIspitID = IspitID,
                podaci = db.MaturskiIspitUcesnik.Include(x=>x.OdjeljenjeStavka).ThenInclude(x=>x.Ucenik).
                Where(x => x.MaturskiIspitID == IspitID).Select(s => new RowAjax { 
                    Bodovi = s.Bodovi,
                    Prisupio = s.Pristupio,
                    ProsjekOcjena = s.ProsjekOcjena,
                    Ucenik = s.OdjeljenjeStavka.Ucenik.ImePrezime,
                    UcesnikID = s.MaturskiIspitUcesnikID
                }).ToList()
            };
            return PartialView(model);
        }
        public IActionResult AjaxUredi(int ucenikID)
        {
            var ispit = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == ucenikID).Select(x => x.MaturskiIspit).FirstOrDefault();
            AjaxUrediVM model = new AjaxUrediVM
            {
                UcesnikID = ucenikID,
                Ucesnik = db.MaturskiIspitUcesnik.Include(x=>x.OdjeljenjeStavka).ThenInclude(x=>x.Ucenik).
                Where(x=>x.MaturskiIspitUcesnikID==ucenikID).Select(s=>s.OdjeljenjeStavka.Ucenik.ImePrezime).FirstOrDefault(),
                nastavnikID = ispit.NastavnikID
            };
            return PartialView(model);
        }
        public IActionResult AjaxSnimi(AjaxUrediVM podaci)
        {
            var ucesnik = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == podaci.UcesnikID).FirstOrDefault();
            ucesnik.Bodovi = podaci.bodovi;
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Prikaz?NastavnikID=" + podaci.nastavnikID);
        }
        public IActionResult UcenikJePristupio(int Id)
        {
            var ispitID = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == Id).Select(s => s.MaturskiIspitID).FirstOrDefault();
            var ucenik = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == Id).FirstOrDefault();
            ucenik.Pristupio = false;
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Uredi?MaturskiID=" + ispitID);
        }
        public IActionResult UcenikJeOdustan(int Id)
        {
            var ispitID = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == Id).Select(s => s.MaturskiIspitID).FirstOrDefault();
            var ucenik = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == Id).FirstOrDefault();
            ucenik.Pristupio = true;
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Uredi?MaturskiID=" + ispitID);
        }
        public IActionResult Bodovi(int ucesnikID,int bodovi)
        {
            var ispitID = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == ucesnikID).
                Select(s => s.MaturskiIspitID).FirstOrDefault();
            var ucenik = db.MaturskiIspitUcesnik.Where(x => x.MaturskiIspitUcesnikID == ucesnikID).FirstOrDefault();
            ucenik.Bodovi = bodovi;
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Uredi?MaturskiID=" + ispitID);
        }
    }
}

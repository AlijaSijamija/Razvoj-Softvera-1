using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;
using RS1_Ispit_asp.net_core.EF;
using RS1_Ispit_asp.net_core.EntityModels;
using RS1_Ispit_asp.net_core.ViewModels;
using static RS1_Ispit_asp.net_core.ViewModels.ONDetaljiUcesnikVM;
using static RS1_Ispit_asp.net_core.ViewModels.ONDetaljiVM;
using static RS1_Ispit_asp.net_core.ViewModels.ONIndexVM;
using static RS1_Ispit_asp.net_core.ViewModels.ONPrikazVM;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class OdrzanaNastavaController : Controller
    {
        public OdrzanaNastavaController (MojContext db)
        {
            this.db = db;
        }
        public MojContext db { get; }
        public IActionResult Index()
        {
            ONIndexVM model = new ONIndexVM
            {
                podaci = db.Nastavnik.Select(s=> new Row
                {
                    NastavnikID = s.Id,
                    Nastavnik = s.Ime + " " + s.Prezime,
                    BrCasova = db.OdrzanCas.Where(x=>x.NastavnikID==s.Id).Count()
                }).ToList()
            };
            return View(model);
        }
        public IActionResult Prikaz(int NastavnikID)
        {
            ONPrikazVM model = new ONPrikazVM
            {
                NastavnikID = NastavnikID,
                Podaci = db.OdrzanCas.Where(x => x.NastavnikID == NastavnikID).Select(s => new RowPrikaz
                {
                    OdrzaniCasID = s.OdrzanCasID,
                    Datum = s.Datum,
                    NastavnikID = NastavnikID,
                    Predmet = s.Predmet.Naziv,
                    SkGodinaOdjeljenje = s.Odjeljenje.SkolskaGodina.Naziv + " " + s.Odjeljenje.Oznaka,
                    Skola = s.Skola.Naziv,
                    Ucenici = db.OdrzanCasDetalji.Where(x => x.OdrzanCasID == s.OdrzanCasID && x.Prisutan==false).Select(x => new SelectListItem
                    {
                        Value = x.OdjeljenjeStavka.UcenikId.ToString(),
                        Text= x.OdjeljenjeStavka.Ucenik.ImePrezime
                    }).ToList()
                }).ToList()
            };
            return View(model);
        }
        public IActionResult Dodaj(int nastavnikID)
        {
            ONDodajVM model = new ONDodajVM
            {
               NastavnikID = nastavnikID,
               Nastavnik = db.Nastavnik.Where(x=>x.Id==nastavnikID).Select(s=> s.Ime + " " + s.Prezime).FirstOrDefault(),
               Odjeljenja = db.Odjeljenje.Select(s=> new SelectListItem
               {
                   Value = s.Id.ToString(),
                   Text = s.Oznaka
               }).ToList(),
               Predmeti = db.Predmet.Select(s => new SelectListItem
               {
                   Value = s.Id.ToString(),
                   Text = s.Naziv
               }).ToList(),
               Skole = db.Skola.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Naziv
                }).ToList(),
               
            };
            return View(model);
        }
        public IActionResult Snimi(ONDodajVM podaci)
        {
            OdrzanCas newCas = new OdrzanCas
            {
                Datum = podaci.Datum,
                NastavnikID = podaci.NastavnikID,
                OdjeljenjeID = podaci.OdjeljenjeID,
                PredmetID = podaci.PredmetID,
                SadrzajCasa = podaci.sadrzaj,
                SkolaID = podaci.SkolaID
            };
            db.OdrzanCas.Add(newCas);
            var ucenici = db.OdjeljenjeStavka.Where(x => x.OdjeljenjeId == podaci.OdjeljenjeID &&
            x.Odjeljenje.SkolaID == podaci.SkolaID);
            foreach(var x in ucenici)
            {
                OdrzanCasDetalji newDetalj = new OdrzanCasDetalji
                {
                    Prisutan = false,
                    OpravdanoOdsutan = false,
                    OdrzanCas = newCas,
                    OdjeljenjeStavkaID = x.Id,
                };
                db.OdrzanCasDetalji.Add(newDetalj);
            }
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Prikaz?NastavnikID="+ podaci.NastavnikID);
        }
        public IActionResult Obrisi(int ID)
        {
            var NastavnikID = db.OdrzanCas.Where(x => x.OdrzanCasID == ID).Select(s => s.NastavnikID);
            var Detalj = db.OdrzanCasDetalji.Where(x => x.OdrzanCasID == ID);
            foreach(var x in Detalj)
            {
                db.OdrzanCasDetalji.Remove(x);
            }
            var cas= db.OdrzanCas.Where(x => x.OdrzanCasID == ID).SingleOrDefault();
            db.OdrzanCas.Remove(cas);
            db.SaveChanges();
            return Redirect("/OdrzanaNastava/Prikaz?NastavnikID=" + NastavnikID);
        }
        public IActionResult Detalji(int ID)
        {
            var cas = db.OdrzanCas.Include(x=>x.Skola).Include(x=>x.Odjeljenje).Include(x=>x.Predmet)
                .Where(x => x.OdrzanCasID == ID).FirstOrDefault();
            ONDetaljiVM model = new ONDetaljiVM
            {
                OdrzanCasID = ID,
                Datum = cas.Datum,
                Sadrzaj = cas.SadrzajCasa,
                SkOdljenjePredmet = cas.Skola.Naziv + "|" + cas.Odjeljenje.Oznaka + "|" + cas.Predmet.Naziv,

            };
            return View(model);
        }
        public IActionResult DetaljiUcesnici(int ID)
        {
            var cas = db.OdrzanCas.Include(x => x.Skola).Include(x => x.Odjeljenje).Include(x => x.Predmet)
                .Where(x => x.OdrzanCasID == ID).FirstOrDefault();
            ONDetaljiUcesnikVM model = new ONDetaljiUcesnikVM
            {
                OdrzanCasID = ID,
                podaci = db.OdrzanCasDetalji.Where(o => o.OdrzanCasID == ID).Select(s => new RowDetalj
                {
                    Ocjena = s.Ocjena,
                    OdrzanCasUcesnikID = s.OdrzanCasDetaljiID,
                    OpravdanoOdsutan = s.OpravdanoOdsutan,
                    Prisutan = s.Prisutan,
                    Ucenik = s.OdjeljenjeStavka.Ucenik.ImePrezime
                }).ToList()
            };
            return PartialView(model);
        }
        public IActionResult UcenikJeOdsutan(int id)
        {
            var ucenik = db.OdrzanCasDetalji.Where(o=>o.OdrzanCasDetaljiID==id).FirstOrDefault();
            ucenik.Prisutan = false;
            db.SaveChanges();
            return Redirect("Detalji?ID=" + ucenik.OdrzanCasID);
        }
        public IActionResult UcenikJePrisutan(int id)
        {
            var ucenik = db.OdrzanCasDetalji.Where(o => o.OdrzanCasDetaljiID == id).FirstOrDefault();
            ucenik.Prisutan = true;
            db.SaveChanges();
            return Redirect("Detalji?ID=" + ucenik.OdrzanCasID);
        }
        public IActionResult Ocjena(int id)
        {
            ONOcjenaVM model = new ONOcjenaVM
            {
                ONUcesnikID = id,
                ONUcesnik = db.OdrzanCasDetalji.Include(x=>x.OdjeljenjeStavka).ThenInclude(x=>x.Ucenik).
                Where(x=>x.OdrzanCasDetaljiID==id).Select(s=>s.OdjeljenjeStavka.Ucenik.ImePrezime).FirstOrDefault(),
                OCasID = db.OdrzanCasDetalji.Where(x=>x.OdrzanCasDetaljiID==id).Select(x=>x.OdrzanCasID).FirstOrDefault(),
                Ocjena = db.OdrzanCasDetalji.Where(x => x.OdrzanCasDetaljiID == id).Select(x => x.Ocjena).FirstOrDefault()
            };
            return View(model);
        }
        public IActionResult SnimiOcjena(ONOcjenaVM podaci)
        {
            var ucesnik = db.OdrzanCasDetalji.Where(x => x.OdrzanCasDetaljiID == podaci.ONUcesnikID).FirstOrDefault();
            ucesnik.Ocjena = podaci.Ocjena;
            db.SaveChanges();
            return Redirect("Detalji?ID=" + podaci.OCasID);
        }
        public IActionResult Odsutan(int id)
        {
            ONOdsutanVM model = new ONOdsutanVM{
                ONUcesnikID=id,
                ONUcesnik = db.OdrzanCasDetalji.Include(x => x.OdjeljenjeStavka).ThenInclude(x => x.Ucenik).
                Where(x => x.OdrzanCasDetaljiID == id).Select(s => s.OdjeljenjeStavka.Ucenik.ImePrezime).FirstOrDefault(),
                OCasID = db.OdrzanCasDetalji.Where(x => x.OdrzanCasDetaljiID == id).Select(x => x.OdrzanCasID).FirstOrDefault(),
                
            };
            return View(model);
        }
        public IActionResult SnimiOdsutan(ONOdsutanVM podaci)
        {
            var ucesnik = db.OdrzanCasDetalji.Where(x => x.OdrzanCasDetaljiID == podaci.ONUcesnikID).FirstOrDefault();
            ucesnik.Napomena = podaci.Napomena;
            ucesnik.OpravdanoOdsutan = podaci.Odsutan;
            db.SaveChanges();
            return Redirect("Detalji?ID=" + podaci.OCasID);
        }
    }
}

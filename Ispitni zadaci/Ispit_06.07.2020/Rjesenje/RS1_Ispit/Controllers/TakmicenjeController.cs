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
using static RS1_Ispit_asp.net_core.ViewModels.TakmicenjeIndexVM;

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class TakmicenjeController : Controller
    {
        public TakmicenjeController(MojContext db)
        {
            this.db = db;
        }
        public MojContext db { get; }
        public IActionResult Index(int SkolaID=0)
        {
            TakmicenjeIndexVM model;
            if (SkolaID == 0)
            {
                model = new TakmicenjeIndexVM
                {
                    Skole = db.Skola.Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = s.Naziv
                    }).ToList(),
                    podaci = db.Takmicenje.Select(s => new RowIndex
                    {
                        Datum = s.Datum,
                        Predmet = s.Predmet.Naziv,
                        Razred = s.Razred,
                        Skola = s.Skola.Naziv,
                        takmID = s.TakmicenjeID,
                        NajUcesnik = db.TakmicenjeUcesnik.
                            Where(x => x.TakmicenjeID == s.TakmicenjeID).OrderByDescending(x => x.Bodovi)
                            .Select(x => x.OdjeljenjeStavka.Odjeljenje.Skola.Naziv + "|" +
                            x.OdjeljenjeStavka.Odjeljenje.Oznaka + "|" + x.OdjeljenjeStavka.Ucenik.ImePrezime).FirstOrDefault()
                    }).ToList()
                };
            }
            else
            {
                model = new TakmicenjeIndexVM
                {
                    SkolaID = SkolaID,
                    Skole = db.Skola.Select(s => new SelectListItem
                    {
                        Value = s.Id.ToString(),
                        Text = s.Naziv,
                    }).ToList(),
                    podaci = db.Takmicenje.Where(x=>x.SkolaID==SkolaID).Select(s => new RowIndex
                    {
                        Datum = s.Datum,
                        Predmet = s.Predmet.Naziv,
                        Razred = s.Razred,
                        Skola = s.Skola.Naziv,
                        takmID = s.TakmicenjeID,
                        NajUcesnik = db.TakmicenjeUcesnik.Include(x => x.OdjeljenjeStavka).ThenInclude(x => x.Odjeljenje)
                            .ThenInclude(x => x.Skola).Include(x => x.OdjeljenjeStavka).ThenInclude(x => x.Ucenik).
                            Where(x => x.TakmicenjeID == s.TakmicenjeID).OrderByDescending(x => x.Bodovi)
                            .Select(x => x.OdjeljenjeStavka.Odjeljenje.Skola.Naziv + "|" +
                            x.OdjeljenjeStavka.Odjeljenje.Oznaka + "|" + x.OdjeljenjeStavka.Ucenik.ImePrezime).FirstOrDefault()
                    }).ToList()
                };
            }
            return View(model);
        }
        public IActionResult Dodaj(int skID)
        {
            TakmicenjeDodajVM model = new TakmicenjeDodajVM
            {
                SkolaID = skID,
                Datum = DateTime.Now,
                skola = db.Skola.Where(x=>x.Id==skID).Select(x=>x.Naziv).FirstOrDefault(),
                Predmeti = db.Predmet.Select(s=> new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Naziv
                }).ToList()
            };
            return View(model);
        }
        public IActionResult Snimi(TakmicenjeDodajVM podaci)
        {
            Takmicenje newTakm = new Takmicenje
            {
                Datum = podaci.Datum,
                PredmetID = podaci.PredmetID,
                SkolaID = podaci.SkolaID,
                Zakljucaj = false,
                Razred = db.Odjeljenje.Where(x=>x.SkolaID==podaci.SkolaID).Select(x=>x.Razred).FirstOrDefault(),
                
            };
            db.Takmicenje.Add(newTakm);
            var ucenici = db.DodjeljenPredmet.Where(x => x.PredmetId == podaci.PredmetID && 
                x.ZakljucnoKrajGodine == 5).Select(x => x.OdjeljenjeStavka);
            foreach(var x in ucenici)
            {
                if (db.DodjeljenPredmet.Where(s => s.OdjeljenjeStavkaId == x.Id).Average(s => s.ZakljucnoKrajGodine) > 4)
                {
                    TakmicenjeUcesnik newUcesnik = new TakmicenjeUcesnik
                    {
                        Bodovi=0,
                        OdjeljenjeStavkaID = x.Id,
                        Pristupio = false,
                        Takmicenje=newTakm,      
                    };
                    db.TakmicenjeUcesnik.Add(newUcesnik);
                }
            }
            db.SaveChanges();
            return Redirect("Index?SkolaID=" + podaci.SkolaID);
        }
        public IActionResult Rezultati(int TkmID)
        {
            TakmicenjeRezultatiVM model = db.Takmicenje.Where(x => x.TakmicenjeID == TkmID).Select(s => new TakmicenjeRezultatiVM
            {
                Datum = s.Datum,
                Razred = s.Razred,
                TakmicenjeID = s.TakmicenjeID,
                Zakljucaj = s.Zakljucaj,
                SkolaID = s.SkolaID,
                Skola = s.Skola.Naziv,
                Predmet = s.Predmet.Naziv
            }).FirstOrDefault();
            return View(model);
        }
        public IActionResult Zakljucaj(int TkmID)
        {
            var takmicenje = db.Takmicenje.Where(x => x.TakmicenjeID == TkmID).FirstOrDefault();
            takmicenje.Zakljucaj = true;
            db.SaveChanges();
            return Redirect("Rezultati?TkmID=" + TkmID);
        }
    }
}

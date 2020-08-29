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

namespace RS1_Ispit_asp.net_core.Controllers
{
    public class TakmicenjeController : Controller
    {
        public TakmicenjeController(MojContext db)
        {
            this.db = db;
        }
        public MojContext db { get; }
        public IActionResult Index()
        {
            TakmicenjeOdaberiVM model = new TakmicenjeOdaberiVM
            {
                Skole = db.Skola.Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Naziv,
                }).ToList(),
                
            };
            return View(model);
        }
        public IActionResult Prikaz(TakmicenjeOdaberiVM podaci)
        {
            TakmicenjePrikazVM model = new TakmicenjePrikazVM
            {
                Razred = podaci.Razred,
                SkolaDomacinID = podaci.SkolaID,
                SkolaDomacin = db.Skola.Where(s => s.Id == podaci.SkolaID).Select(s => s.Naziv).FirstOrDefault(),
            };
            if (podaci.Razred == 0)
            {
                model.Redovi = db.Takmicenje.Where(x => x.SkolaDomacinID == podaci.SkolaID).Select(t => new TakmicenjePrikazVM.Row
                {
                    Datum = t.Datum,
                    Predmet = db.Predmet.Where(p => p.Id == t.PredmetID).Select(s => s.Naziv).FirstOrDefault(),
                    Razred = t.Razred,
                    TakmicenjeID = t.TakmicenjeID,
                    NisuPristupili = db.TakmicenjeUcesnik.Where(u => u.TakmicenjeID == t.TakmicenjeID).Count(x => x.IsPristupio == false),
                    NajboljiUcesnik = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeID == t.TakmicenjeID).
                    OrderByDescending(x => x.Bodovi).Select(x => x.OdjeljenjeStavka.Odjeljenje.Skola.Naziv + " | "
                    + x.OdjeljenjeStavka.Odjeljenje.Oznaka + " | " + x.OdjeljenjeStavka.Ucenik.ImePrezime).FirstOrDefault()
                }).ToList();
            }
            else
            {
                model.Redovi = db.Takmicenje.Where(x => x.SkolaDomacinID == podaci.SkolaID && x.Razred==podaci.Razred).Select(t => new TakmicenjePrikazVM.Row
                {
                    Datum = t.Datum,
                    Predmet = db.Predmet.Where(p => p.Id == t.PredmetID).Select(s => s.Naziv).FirstOrDefault(),
                    Razred = podaci.Razred,
                    TakmicenjeID = t.TakmicenjeID,
                    NisuPristupili = db.TakmicenjeUcesnik.Where(u => u.TakmicenjeID == t.TakmicenjeID).Count(x => x.IsPristupio == false),
                    NajboljiUcesnik = db.TakmicenjeUcesnik.Where(x => x.TakmicenjeID == t.TakmicenjeID).
                    OrderByDescending(x => x.Bodovi).Select(x => x.OdjeljenjeStavka.Odjeljenje.Skola.Naziv + " | "
                    + x.OdjeljenjeStavka.Odjeljenje.Oznaka + " | " + x.OdjeljenjeStavka.Ucenik.ImePrezime).FirstOrDefault()
                }).ToList();
            }
            return View(model);
        }
        public IActionResult Dodaj(int skolaID)
        {
            TakmicenjeDodajVM model = new TakmicenjeDodajVM
            {
                SkolaID = skolaID,
                Skola = db.Skola.Where(s=>s.Id == skolaID).Select(s=>s.Naziv).FirstOrDefault(),
                Predmeti = db.Predmet.Select(p=> new SelectListItem { 
                    Text = p.Naziv,
                    Value = p.Id.ToString()
                }).ToList()
            };
            return View(model);
        }
        public IActionResult Snimi (TakmicenjeDodajVM podaci)
        {
            Takmicenje newTakm = new Takmicenje
            {
                SkolaDomacinID = podaci.SkolaID,
                PredmetID = podaci.PredmetID,
                Datum = podaci.Datum,
                Razred = podaci.Razred,
                Zakljucano = false,
            };
            db.Takmicenje.Add(newTakm);

            var ucesnici = db.DodjeljenPredmet.Where(x => x.PredmetId == podaci.PredmetID && 
            x.ZakljucnoKrajGodine == 5).ToList();
            foreach (var x in ucesnici)
            {
                if (db.DodjeljenPredmet.Where(y => y.Id == x.Id).Average(y => y.ZakljucnoKrajGodine) > 4)
                {
                    TakmicenjeUcesnik newTU = new TakmicenjeUcesnik
                    {
                        Takmicenje = newTakm,
                        IsPristupio = false,
                        Bodovi = 0,
                        OdjeljenjeStavkaID = x.OdjeljenjeStavkaId,
                    };
                    db.TakmicenjeUcesnik.Add(newTU);
                }
            }
            db.SaveChanges();
            return Redirect("Index");
        }
        public IActionResult Rezultat(int tkmID)
        {
            var takmicenje = db.Takmicenje.Find(tkmID);
            TakmicenjeRezultatVM model = new TakmicenjeRezultatVM
            {
                TakmicenjeID = tkmID,
                Datum = takmicenje.Datum,
                Predmet = db.Predmet.Find(takmicenje.PredmetID).Naziv,
                Razred = takmicenje.Razred,
                SkolaDomacin = db.Skola.Find(takmicenje.SkolaDomacinID).Naziv,
                Zakljucaj = takmicenje.Zakljucano,
                SkolaDomacinID = takmicenje.SkolaDomacinID
            };
            return View(model);
        }
        public IActionResult Zakljucaj(int tkmID)
        {
            var takmicenje = db.Takmicenje.Find(tkmID);
            takmicenje.Zakljucano = true;
            db.SaveChanges();
            return RedirectToAction("Rezultat", new { tkmID });
        }
    }
}

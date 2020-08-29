using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class ONDodajVM
    {
        public int NastavnikID { get; set; }
        public string Nastavnik { get; set; }
        public DateTime Datum { get; set; }
        public int SkolaID { get; set; }
        public int PredmetID { get; set; }
        public int OdjeljenjeID { get; set; }
        public List<SelectListItem> Skole { get; set; }
        public List<SelectListItem> Predmeti { get; set; }
        public List<SelectListItem> Odjeljenja { get; set; }
        public string sadrzaj { get; set; }
    }
}

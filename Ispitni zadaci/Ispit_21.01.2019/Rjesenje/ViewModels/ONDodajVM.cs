using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class ONDodajVM
    {
        public List<SelectListItem> Skole { get; set; }
        public int SkolaID { get; set; }
        public int NastavnikID { get; set; }
        public string Nastavnik { get; set; }
        public int SGID { get; set; }
        public string SG { get; set; }
        public DateTime Datum { get; set; }
        public List<SelectListItem> Predmeti { get; set; }
        public int PredmetID { get; set; }
        public List<SelectListItem> SkolskaGodina { get; set; }
        public int SkolskaGodinaID { get; set; }
    }
}

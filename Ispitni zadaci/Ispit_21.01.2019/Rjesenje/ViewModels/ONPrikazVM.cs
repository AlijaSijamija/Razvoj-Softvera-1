using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class ONPrikazVM
    {
        public int NastavnikID { get; set; }
        public int SkolskaGodinaID { get; set; }
        public List<RowPrikaz> podaci { get; set; }
        public class RowPrikaz
        {
            public int MaturskiIspitID { get; set; }
            public DateTime Datum { get; set; }
            public string Skola { get; set; }
            public string Predmet { get; set; }
            public List<SelectListItem> Ucenici { get; set; }
        }
    }
}

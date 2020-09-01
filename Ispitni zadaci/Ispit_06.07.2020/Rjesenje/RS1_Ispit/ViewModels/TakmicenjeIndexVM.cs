using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class TakmicenjeIndexVM
    {
        public int SkolaID { get; set; }
        public List<SelectListItem> Skole { get; set; }
        public List<RowIndex> podaci { get; set; }
        public class RowIndex
        {
            public int takmID { get; set; }
            public string Skola { get; set; }
            public int Razred { get; set; }
            public DateTime Datum { get; set; }
            public string Predmet { get; set; }
            public string NajUcesnik { get; set; }

        }
    }
}

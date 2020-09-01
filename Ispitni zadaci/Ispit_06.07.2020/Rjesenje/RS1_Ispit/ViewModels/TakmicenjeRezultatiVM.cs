using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class TakmicenjeRezultatiVM
    {
        public int SkolaID { get; set; }
        public string Skola { get; set; }
        public string Predmet { get; set; }
        public int Razred { get; set; }
        public DateTime Datum { get; set; }
        public bool Zakljucaj { get; set; }
        public int TakmicenjeID { get; set; }

    }
}

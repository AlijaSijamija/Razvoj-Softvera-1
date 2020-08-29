using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class Takmicenje
    {
        public int TakmicenjeID { get; set; }
        public Skola SkolaDomacin { get; set; }
        public int SkolaDomacinID { get; set; }
        public Predmet Predmet { get; set; }
        public int PredmetID { get; set; }
        public DateTime Datum { get; set; }

        public int Razred { get; set; }
        public bool Zakljucano { get; set; }

    }
}

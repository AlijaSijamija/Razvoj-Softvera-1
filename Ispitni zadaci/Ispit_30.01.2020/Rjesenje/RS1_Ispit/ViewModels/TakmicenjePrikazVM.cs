using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class TakmicenjePrikazVM
    {
        public int SkolaDomacinID { get; set; }
        public string SkolaDomacin { get; set; }
        public int Razred { get; set; }
        public List<Row> Redovi { get; set; }
        public class Row
        {
            public int TakmicenjeID { get; set; }
            public string Predmet { get; set; }
            public int Razred { get; set; }
            public DateTime Datum { get; set; }
            public int NisuPristupili { get; set; }
            public string NajboljiUcesnik { get; set; }
        }
    }
}

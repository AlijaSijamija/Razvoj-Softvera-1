using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class ONIndexVM
    {
        public List<Row> podaci { get; set; }
        public class Row
        {
            public string Nastavnik { get; set; }
            public int BrCasova { get; set; }
            public int NastavnikID { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class ONIndexVM
    {
        public List<RowIndex> podaci { get; set; }
        public class RowIndex
        {
            public string Skola { get; set; }
            public int NastavnikaID { get; set; }
            public string Nastavnik { get; set; }
        }
    }
}

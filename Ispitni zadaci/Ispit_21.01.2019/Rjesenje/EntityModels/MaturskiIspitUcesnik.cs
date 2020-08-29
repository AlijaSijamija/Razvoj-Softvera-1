using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class MaturskiIspitUcesnik
    {
        public int MaturskiIspitUcesnikID { get; set; }
        public int MaturskiIspitID { get; set; }
        public MaturskiIspit MaturskiIspit { get; set; }
        public int Bodovi { get; set; }
        public bool Uslov { get; set; }
        public bool Pristupio { get; set; }
        public double ProsjekOcjena { get; set; }
        public OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class OdrzanCasDetalji
    {
        public int OdrzanCasDetaljiID { get; set; }
        public OdrzanCas OdrzanCas { get; set; }
        public int OdrzanCasID { get; set; }
        public bool OpravdanoOdsutan { get; set; }
        public bool Prisutan { get; set; }
        public int Ocjena { get; set; }
        public string Napomena { get; set; }
        public OdjeljenjeStavka OdjeljenjeStavka { get; set; }
        public int OdjeljenjeStavkaID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class ONDetaljiUcesnikVM
    {
        public int OdrzanCasID { get; set; }
        public List<RowDetalj> podaci { get; set; }
        public class RowDetalj
        {
            public int OdrzanCasUcesnikID { get; set; }
            public string Ucenik { get; set; }
            public int Ocjena { get; set; }
            public bool Prisutan { get; set; }
            public bool OpravdanoOdsutan { get; set; }

        }
    }
}

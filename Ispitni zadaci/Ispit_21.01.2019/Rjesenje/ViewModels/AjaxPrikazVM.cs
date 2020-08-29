using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class AjaxPrikazVM
    {
        public int MaturskiIspitID { get; set; }
        public List<RowAjax> podaci { get; set; }
        public class RowAjax
        {
            public int UcesnikID { get; set; }
            public string Ucenik { get; set; }
            public double ProsjekOcjena { get; set; }
            public bool Prisupio { get; set; }
            public int Bodovi { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class AjaxIndexVM
    {
        public int TakmID { get; set; }
        public bool Zakljucano { get; set; }
        public List<RowAjax> podaci { get; set; }
        public class RowAjax
        {
            public int TakmicenjeUcesnikID { get; set; }
            public string Odjeljenje { get; set; }
            public int BrDnevnik { get; set; }
            public bool Pristupio { get; set; }
            public int bodovi { get; set; }

        }
    }
}

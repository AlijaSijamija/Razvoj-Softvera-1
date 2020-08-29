using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class AjaxPrikazVM
    {
        public int TakmicenjeID { get; set; }
        public List<Row> redovi { get; set; }
        public bool Zakljucano { get; set; }
        public class Row
        {
            public int TakmicenjeUcesnikID { get; set; }
            public string Odjeljenje { get; set; }
            public int BrUDnevniku { get; set; }
            public bool Pristupio { get; set; }
            public string Bodovi { get; set; }
        }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_asp.net_core.ViewModels
{
    public class AjaxDodajVM
    {
        public int TakmicenjeID { get; set; }
        public List<SelectListItem> Ucenici { get; set; }
        public int UcenikID { get; set; }
        public int bodovi { get; set; }
    }
}

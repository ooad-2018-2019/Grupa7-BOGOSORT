using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Narudzba
    {
        [ScaffoldColumn(false)]
        public int NarudzbaID { get; set; }
        public int KlijentID { get; set; }
        public virtual Klijent Klijent { get; set; }
        public String PocetnaLokacija { get; set; }
        public String OdredisnaLokacija { get; set; }
        public DateTime DateTime { get; set; }

    }
}

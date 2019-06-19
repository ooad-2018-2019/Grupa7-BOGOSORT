using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class OcjenaVozaca
    {

        [ScaffoldColumn(false)]
        public int OcjenaVozacaID { get; set; }

       
        public int? VozacID { get; set; }
        [ForeignKey("VozacID")]
        public virtual Vozac Vozac { get; set; }

        public int? KlijentID { get; set; }
        [ForeignKey("KlijentID")]
        public virtual Klijent Klijent { get; set; }

        public int? VoznjaID { get; set; }
        [ForeignKey("VoznjaID")]
        public virtual Voznja Voznja { get; set; }

        public int Ocjena { get; set;  }

        public String Komentar { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Voznja
    {
        [ScaffoldColumn(false)]
        public int VoznjaID { get; set; }

     
        public int? VozacID { get; set; }

        public int NarudzbaID { get; set; }

        public int Aktivna { get; set; }
        [ForeignKey("VozacID")]
        public virtual Vozac Vozac { get; set; }

        public virtual Narudzba Narudzba { get; set; }

    }
}

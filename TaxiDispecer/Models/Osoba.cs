using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{

    public abstract class Osoba
    {
        [ScaffoldColumn(false)]
        public int OsobaID { get; set; }
    
        public string Ime { get; set; }
       
        public string Prezime { get; set; }
       
        public DateTime DateTime { get; set; }

        [StringLength(13)]
        public string JMBG { get; set; }
    
     
        public string EMail { get; set; }

        public String Sifra { get; set; }

        public String Username { get; set; }

    }
}

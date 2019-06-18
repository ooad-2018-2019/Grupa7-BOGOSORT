using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public enum Spol
    {
        Muski,
        Zenski
    }

    public class Osoba
    {
        public int ID { get; set; }
    
        public string Ime { get; set; }
       
        public string Prezime { get; set; }
       
        public DateTime? DatumRodjenja { get; set; }
      
        public string JMBG { get; set; }
    
        public Spol Spol { get; set; }
     
        public string EMail { get; set; }

    }
}

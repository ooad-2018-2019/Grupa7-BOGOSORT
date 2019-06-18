using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Narudzba
    {
        public int Id { get; set; }
        public int IdKlijenta { get; set; }
        public String PocetnaLokacija { get; set; }
        public String OdredisnaLokacija { get; set; }
        public int VrijemeCekanja { get; set; }

    }
}

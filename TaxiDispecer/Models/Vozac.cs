using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Vozac : Osoba
    {
        public String BrojTransakcijskogRacuna { get; set; }

        public String BrojUgovora { get; set;  }

        public String BrojLicence { get; set; }

    }
}

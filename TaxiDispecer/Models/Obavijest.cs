using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Obavijest
    {
        public int ID { get; set; }
        public int IdPosiljaoca { get; set; }
        public int IdPrimaoca { get; set; }

        public String TextPoruke { get; set; }
    }
}

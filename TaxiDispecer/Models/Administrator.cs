using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Administrator
    {
        [ScaffoldColumn(false)]
        public int AdministratorID { get; set; }

        public int Username { get; set; }
        public int Password { get; set; }

        public int PermissionLevel { get; set; }
    }
}

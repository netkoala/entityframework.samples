using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples.Models
{
    class Car : Product
    {
        public string Make { get; set; }

        public int Year { get; set; }

        public string ExteriorColor { get; set; }

        public string InteriorColor { get; set; }
    }
}

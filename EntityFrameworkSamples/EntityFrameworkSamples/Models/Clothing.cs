using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples.Models
{
    class Clothing : Product
    {
        public string Style { get; set; }

        public string Color { get; set; }

        public string Material { get; set; }
    }
}

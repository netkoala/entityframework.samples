using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples.Models
{
    abstract class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double UnitPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSamples.Models
{
    class GoodsContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public DbSet<CellPhone> CellPhones { get; set; }

        public DbSet<Clothing> Clothing { get; set; }

        public DbSet<SerialNumber> SerialNumbers { get; set; }

        public GoodsContext()
            : base("GoodsContext") // connectionString's name
        {
        }
    }
}

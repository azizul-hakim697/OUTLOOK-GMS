using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class GMSContext:DbContext
    {
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Salary> Salaries{ get; set; }
    }
}

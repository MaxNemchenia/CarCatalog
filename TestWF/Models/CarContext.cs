using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestWF.Models
{
    public class CarContext:DbContext
    {
        public CarContext()
            : base("DbConnection")
        { }

        public DbSet<Producer> Producers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }
}
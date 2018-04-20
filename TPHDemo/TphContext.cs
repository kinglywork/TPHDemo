using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHDemo
{
    public class TphContext : DbContext
    {
        public TphContext()
            : base("name=TphContext")
        {

        }

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Map<Dog>(m => m.Requires("Type").HasValue("DOG"))
                .Map<Cat>(m => m.Requires("Type").HasValue("CAT"));
        }
    }
}

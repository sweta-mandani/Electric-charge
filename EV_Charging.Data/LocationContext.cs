using EV_Charging.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV_Charging.Data
{
    class LocationContext: DbContext
    {
        
        
            public LocationContext() : base("name =LocationContext")
            {
            }

            public DbSet<Location1> Movies { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Location1>().MapToStoredProcedures();
            }

        }
    }



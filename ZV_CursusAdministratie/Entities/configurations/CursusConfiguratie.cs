using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ZV_CursusAdministratie.Entities.configurations
{
    public class CursusConfiguratie
    {
        public void Configure(DbModelBuilder modelBuilder)
        {
            var m = modelBuilder.Entity<Cursus>();
            m.ToTable("Cursus");
            m.HasKey(c => c.Id);
            m.Property(c => c.Titel)
                .HasMaxLength(300);
            m.Property(c => c.Code)
                .HasMaxLength(10);
        }
    }
}
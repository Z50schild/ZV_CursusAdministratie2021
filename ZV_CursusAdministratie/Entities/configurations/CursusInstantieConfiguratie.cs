using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ZV_CursusAdministratie.Entities.configurations
{
    public class CursusInstantieConfiguratie
    {
        public void Configure(DbModelBuilder modelBuilder)
        {
            var m = modelBuilder.Entity<CursusInstantie>();
            m.ToTable("CursusInstanties");
            m.HasKey(ci => ci.Id);
            m.HasRequired(ci => ci.Cursus)
                .WithMany(c => c.CursusInstanties)
                .HasForeignKey(ci => ci.CursusId);
            
        }

    }
}
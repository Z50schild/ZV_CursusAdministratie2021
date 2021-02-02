using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ZV_CursusAdministratie.Entities;

namespace ZV_CursusAdministratie.Context
{
    public class CursusAdminContext : DbContext
    {
        public CursusAdminContext() : base("CursusAdminConnectString")
        {
        }

        public static CursusAdminContext Create()
        {
            return new CursusAdminContext();
        }

        public DbSet<Cursus> Cursus { get; set; }
        public DbSet<CursusInstantie> CursusInstanties { get; set; }
    }
}
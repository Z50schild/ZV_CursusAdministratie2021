namespace ZV_CursusAdministratie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using ZV_CursusAdministratie.Context;
    using ZV_CursusAdministratie.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<CursusAdminContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CursusAdminContext context)
        {
            context.Cursus.AddOrUpdate(x => x.Id,
                new Cursus() { Id = 1, Titel = "C# Programmeren", Code = "CNETIN", Duur = 5 }
                );

            context.CursusInstanties.AddOrUpdate(x => x.Id,
                new CursusInstantie() { Id = 1, CursusId = 1, Startdatum = new DateTime(2018, 09, 24) }
                );


        }
    }
}

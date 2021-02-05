using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ZV_CursusAdministratie.Context;
using ZV_CursusAdministratie.Entities;

namespace ZV_CursusAdministratie.Repositories
{
    public class UploadFileRepository :IUploadFileRepository
    {
        private CursusAdminContext context;
        protected readonly DbSet<Cursus> setCursus;
        protected readonly DbSet<CursusInstantie> setCursusInstantie;

        public UploadFileRepository(CursusAdminContext datacontext)
        {
            context = datacontext;
            setCursus = context.Set<Cursus>();
            setCursusInstantie = context.Set<CursusInstantie>();
        }

        public bool CursusExists(string tekst)
        {
            return context.Cursus.Any(c => c.Titel.ToUpper() == tekst.ToUpper());
        }

        public bool CursusInstantieExists(DateTime datum, string tekst)
        {
            return context.CursusInstanties.Any(c => c.Startdatum == datum && c.Cursus.Titel.ToUpper() == tekst.ToUpper());
        }

        public Cursus GetCursus(string tekst )
        {
            return context.Cursus.First(c => c.Titel.ToUpper() == tekst.ToUpper());
        }

        public void InsertCursus(Cursus cursus)
        {
            setCursus.Add(cursus);
        }

        public void InsertCursusInstantie(CursusInstantie cursusInstantie)
        {
            setCursusInstantie.Add(cursusInstantie);
        }

        public void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch
            { Debug.WriteLine("Onbekende error bij save to database"); }
        }
    }
}
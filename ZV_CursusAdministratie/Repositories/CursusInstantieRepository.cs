using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ZV_CursusAdministratie.Context;
using ZV_CursusAdministratie.Entities;

namespace ZV_CursusAdministratie.Repositories
{
    public class CursusInstantieRepository: ICursusInstantieRepository
    {
        private CursusAdminContext context;

        public CursusInstantieRepository(CursusAdminContext datacontext)
        {
            context = datacontext;
        }

        public IEnumerable<CursusInstantie> GetAllCursusInstanties()
        {
            return context.CursusInstanties.Include(c => c.Cursus).ToList();
        }
    }
}
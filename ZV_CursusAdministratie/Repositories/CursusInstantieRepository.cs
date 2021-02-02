using System.Collections.Generic;
using System.Linq;
using ZV_CursusAdministratie.Context;
using ZV_CursusAdministratie.Entities;

namespace ZV_CursusAdministratie.Repositories
{
    public class CursusInstantieRepository: ICursusInstantieRepository
    {
        private CursusAdminContext db;

        public CursusInstantieRepository(CursusAdminContext db)
        {
            this.db = db;
        }

        public IEnumerable<CursusInstantie> GetAllCursusInstanties()
        {
            return db.CursusInstanties.ToList();
        }
    }
}
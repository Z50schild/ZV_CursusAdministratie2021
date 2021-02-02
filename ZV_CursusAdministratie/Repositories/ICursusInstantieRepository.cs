using System.Collections.Generic;
using ZV_CursusAdministratie.Entities;

namespace ZV_CursusAdministratie.Repositories
{
    public interface ICursusInstantieRepository
    {
        IEnumerable<CursusInstantie> GetAllCursusInstanties();
    }
}
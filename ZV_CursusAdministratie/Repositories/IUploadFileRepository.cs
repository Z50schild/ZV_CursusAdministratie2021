using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZV_CursusAdministratie.Entities;

namespace ZV_CursusAdministratie.Repositories
{
    public interface IUploadFileRepository
    {
        bool CursusExists(string tekst);
        bool CursusInstantieExists(DateTime datum, string tekst);
        Cursus GetCursus(string tekst);
        void InsertCursus(Cursus cursus);
        void InsertCursusInstantie(CursusInstantie cursusInstantie);


    }
}
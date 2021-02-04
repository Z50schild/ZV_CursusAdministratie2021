using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZV_CursusAdministratie.Context;

namespace ZV_CursusAdministratie.Repositories
{
    public class UploadFileRepository :IUploadFileRepository
    {
        private CursusAdminContext context;

        public UploadFileRepository(CursusAdminContext datacontext)
        {
            context = datacontext;
        }


    }
}
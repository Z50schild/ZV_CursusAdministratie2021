using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ZV_CursusAdministratie.Context;
using ZV_CursusAdministratie.Repositories;

namespace ZV_CursusAdministratie.Controllers
{
    public class UploadFileController : ApiController
    {
        private IUploadFileRepository uploadFileRepository;

        public UploadFileController()
        {
            this.uploadFileRepository = new UploadFileRepository(new CursusAdminContext());
        }

        public UploadFileController(IUploadFileRepository uploadFileRepository)
        {
            this.uploadFileRepository = uploadFileRepository;
        }



        [HttpPost]
        [Route("api/UploadFile")]
        public IHttpActionResult UploadFile()
        {
            throw new NotImplementedException();
        }
    }
}
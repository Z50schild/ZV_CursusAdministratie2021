using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

        [HttpGet]
        [Route("api/UploadFile")]
        public IHttpActionResult whatever() {
            return Ok();
        }

        [HttpPost]
        [Route("api/UploadFile")]
        public IHttpActionResult UploadFile()
        {
            var httpContext = HttpContext.Current;

            if (httpContext.Request.Files.Count > 0)
            {
                for ( int i=0; i< httpContext.Request.Files.Count; i++)
                {
                    HttpPostedFile httpPostedFile = httpContext.Request.Files[i];
                    if(httpPostedFile != null)
                    {
                        try
                        {
                            // Open the text file using a stream reader.
                            using (var sr = new StreamReader(httpPostedFile.InputStream))
                            {
                                // Read the stream as a string, and write the string to the console.
                                Debug.WriteLine(sr.ReadToEnd());
                            }
                        }
                        catch (IOException e)
                        {
                            Debug.WriteLine("The file could not be read:");
                            Debug.WriteLine(e.Message);
                        }
                    }
                }
            }
            return Ok();
        }
    }
}
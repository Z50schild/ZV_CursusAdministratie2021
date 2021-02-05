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
using ZV_CursusAdministratie.Entities;
using ZV_CursusAdministratie.Exceptions;
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
            var httpContext = HttpContext.Current;

            if (httpContext.Request.Files.Count > 0)
            {
                for (int i = 0; i < httpContext.Request.Files.Count; i++)
                {
                    HttpPostedFile httpPostedFile = httpContext.Request.Files[i];
                    if (httpPostedFile != null)
                    {
                        try
                        {
                            using (var sr = new StreamReader(httpPostedFile.InputStream))
                            {
                                string readText = sr.ReadToEnd();
                                try { 
                                    string[] cursusInstantieSeperator = new string[] { "\r\n\r\n" };
                                    string[] result;
                                    result = readText.Split(cursusInstantieSeperator, StringSplitOptions.None);
                                    foreach (string cursusinstantie in result)
                                    {

                                        string[] lineSeperator = new string[] { "\r\n" };
                                        string[] lineResult = cursusinstantie.Split(lineSeperator, StringSplitOptions.None);
                                        var dictionary = new Dictionary<string, string>();
                                        foreach (string line in lineResult)
                                        {
                                            string[] propertySeperator = new string[] { ":" };
                                            string[] lineElement = line.Split(propertySeperator, StringSplitOptions.None);
                                            dictionary.Add(lineElement.ElementAt(0).Trim(), lineElement.ElementAt(1).Trim());
                                        }

                                        if (!uploadFileRepository.CursusInstantieExists(DateTime.Parse(dictionary["Startdatum"]), dictionary["Titel"]))
                                        {
                                            CursusInstantie cursusinst = new CursusInstantie();
                                            cursusinst.Startdatum = DateTime.Parse(dictionary["Startdatum"]);
                                            if (uploadFileRepository.CursusExists(dictionary["Titel"]))
                                            {
                                                cursusinst.Cursus = uploadFileRepository.GetCursus(dictionary["Titel"]);
                                            }
                                            else
                                            {
                                                cursusinst.Cursus = new Cursus();
                                                cursusinst.Cursus.Titel = dictionary["Titel"];
                                                cursusinst.Cursus.Duur = Int32.Parse(dictionary["Duur"]);
                                                cursusinst.Cursus.Code = dictionary["CursusCode"];
                                            }
                                        }
                                    }
                                    Debug.WriteLine("x");
                                }
                                catch
                                { throw new FileToObjectException("Bestand voldoet niet aan formaat"); }
                            }
                        }
                        catch (FileToObjectException e)
                        {
                            Debug.WriteLine(e.Message);
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
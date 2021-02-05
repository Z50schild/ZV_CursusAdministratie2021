using System.Collections.Generic;
using System.Web.Http;
using ZV_CursusAdministratie.Context;
using ZV_CursusAdministratie.Entities;
using ZV_CursusAdministratie.Repositories;

namespace ZV_CursusAdministratie.Controllers
{
    public class CursusInstantieController : ApiController
    {
        private ICursusInstantieRepository cursusInstantieRepository;

        public CursusInstantieController()
        {
            this.cursusInstantieRepository = new CursusInstantieRepository(new CursusAdminContext());
        }

        public CursusInstantieController(ICursusInstantieRepository cursusInstantieRepository)
        {
            this.cursusInstantieRepository = cursusInstantieRepository;
        }

        [HttpGet]
        [Route("api/CursusInstantie")]
        public IEnumerable<CursusInstantie> GetAllCursusInstanties()
        {
            var product = cursusInstantieRepository.GetAllCursusInstanties();

            return product;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZV_CursusAdministratie.Entities
{
    public class Cursus
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Code { get; set; }

        public int Duur { get; set; }

        public List<CursusInstantie> CursusInstanties { get; set; }

    }
}
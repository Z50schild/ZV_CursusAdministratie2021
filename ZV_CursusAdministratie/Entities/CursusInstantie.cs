using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZV_CursusAdministratie.Entities
{
    public class CursusInstantie
    {
        public int Id { get; set; }
        [DisplayFormat (ApplyFormatInEditMode = true, DataFormatString = "0:dd/MM/yyyy")]
        public DateTime Startdatum { get; set; }
        public Cursus Cursus { get; set; }
        public int CursusId { get; set; }
    }
}
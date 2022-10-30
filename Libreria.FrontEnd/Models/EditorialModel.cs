using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Libreria.FrontEnd.Models
{
    public class EditorialModel
    {

        public int Id { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Nombre no peude ser en blanco")]
        public string Nombre { get; set; }
        [DisplayName("Sede")]
        [Required(ErrorMessage = "Sede no peude ser en blanco")]
        public string Sede { get; set; }
    }
}
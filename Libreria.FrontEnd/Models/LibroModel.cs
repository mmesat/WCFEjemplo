using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Libreria.FrontEnd.Models
{
    public class LibroModel
    {
        public int EditorialesId { get; set; }
        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Titulo no peude ser en blanco")]
        public string Titulo { get; set; }
        [DisplayName("Sinopsis")]
        [Required(ErrorMessage = "Sinopsis no peude ser en blanco")]
        public string Sinopsis { get; set; }
        [DisplayName("Numero Paginas")]
        public string Npaginas { get; set; }
    }
}
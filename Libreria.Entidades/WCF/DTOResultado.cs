using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.Entidades.WCF
{
    /// <summary>
    /// entidad standart de respuesta
    /// </summary>
    public class DTOResultado
    {
        public Enums.CodigoRespuesta Codigo { get; set; }
        public string Mensaje { get; set; }
        public string ErrorDePila { get; set; }
    }
}

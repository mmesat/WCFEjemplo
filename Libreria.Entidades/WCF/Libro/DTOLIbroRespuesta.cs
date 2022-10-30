using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Libreria.Entidades.WCF.Libro
{
    /// <summary>
    /// Dto libro con respuesta standart
    /// </summary>
    public class DTOLIbroRespuesta
    {
        [DataMember]
        public List<DTOLibroCuerpo> Cuerpo { get; set; }
        public DTOResultado Resultado { get; set; }
    }
}

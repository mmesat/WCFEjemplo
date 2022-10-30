using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Libreria.Entidades.WCF.Editorial
{
    /// <summary>
    /// Entidad Editorial con respeuta standart
    /// </summary>
    public class DTOEdiitorialRespuesta
    {
        [DataMember]
        public List<DTOEditorialCuerpo> Cuerpo { get; set; }
        public DTOResultado Resultado { get; set; }
    }
}

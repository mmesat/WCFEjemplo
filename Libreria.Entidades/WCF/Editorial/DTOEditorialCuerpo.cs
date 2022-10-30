using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.Entidades.WCF.Editorial
{
    /// <summary>
    /// Entidad del cuerpo editorial
    /// </summary>
    public class DTOEditorialCuerpo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sede { get; set; }
    }
}

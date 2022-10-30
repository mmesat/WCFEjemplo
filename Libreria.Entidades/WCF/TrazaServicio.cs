using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.Entidades.WCF
{
    /// <summary>
    /// Entidad de traza
    /// </summary>
    public class TrazaServicio
    {
        public string Operacion { get; set; }

        public string Solicitud { get; set; }

        public string Respuesta { get; set; }

        public string DetalleDeExcepcion { get; set; }

        public DateTime FechaEjecucion { get; set; }

        public string IpUsuario { get; set; }
    }
}

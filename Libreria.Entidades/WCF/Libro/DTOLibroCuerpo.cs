using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.Entidades.WCF.Libro
{
    /// <summary>
    /// DTO libros
    /// </summary>
    public class DTOLibroCuerpo
    {
        public int ISBN { get; set; }
        public int EditorialesId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string Npaginas { get; set; }
    }
}
using HerramientasComunes;
using Libreria.Datos;
using Libreria.Entidades;
using Libreria.Entidades.WCF;
using Libreria.Entidades.WCF.Editorial;
using Libreria.Entidades.WCF.Libro;
using System;

namespace Libreria.Negocios
{
    /// <summary>
    /// Clase de liberias de negocios
    /// </summary>
    public class LibreriaCN
    {
        LibreriaCAD LibreriaCAD;
        public LibreriaCN()
        {
            LibreriaCAD = new LibreriaCAD();
        }
        /// <summary>
        /// Capa de negocio obtencion de editorial
        /// </summary>
        /// <returns></returns>
        public DTOEdiitorialRespuesta ObtenerEditorial()
        {
            DTOEdiitorialRespuesta res = new DTOEdiitorialRespuesta();
            DTOResultado resultado = new DTOResultado();
            res.Cuerpo = LibreriaCAD.ObtenerEditorial();
            resultado.Codigo = Enums.CodigoRespuesta.OK;
            resultado.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.OK);
            res.Resultado = resultado;
            return res;
        }
        /// <summary>
        /// Capa de negocio insercion libro
        /// </summary>
        /// <param name="Libro"></param>
        /// <returns></returns>
        public DTOResultado AgregarLibro(DTOLibroCuerpo Libro)
        {
            DTOResultado resultado = new DTOResultado();

            LibreriaCAD.AgregarLibro(Libro);
            resultado.Codigo = Enums.CodigoRespuesta.OK;
            resultado.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.OK);
            return resultado;
        }
        /// <summary>
        /// capa de negocio insercion editorial
        /// </summary>
        /// <param name="Editorial"></param>
        /// <returns></returns>
        public DTOResultado AgregarEditorial(DTOEditorialCuerpo Editorial)
        {
            DTOResultado resultado = new DTOResultado();

            LibreriaCAD.AgregarEditorial(Editorial);
            resultado.Codigo = Enums.CodigoRespuesta.OK;
            resultado.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.OK);
            return resultado;
        }
    }
}

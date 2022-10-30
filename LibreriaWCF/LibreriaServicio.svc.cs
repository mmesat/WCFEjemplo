using HerramientasComunes;
using Libreria.Entidades;
using Libreria.Entidades.WCF;
using Libreria.Entidades.WCF.Editorial;
using Libreria.Entidades.WCF.Libro;
using Libreria.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibreriaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "LibreriaServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione LibreriaServicio.svc o LibreriaServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    /// <summary>
    /// En esta clase se reciben los datos ya sea de entrada o de salida de los diferentes metodos que se exponene atravez del servicio web.
    /// </summary>
    public class LibreriaServicio : ILibreriaServicio
    {
        /// <summary>
        /// Exposicion metodo de agegar eeditorial
        /// </summary>
        /// <param name="Editorial"></param>
        /// <returns></returns>
        public DTOResultado AgregarEditorial(DTOEditorialCuerpo Editorial)
        {
            DTOResultado res = new DTOResultado();
            TrazaServicio traza = new TrazaServicio();
            try
            {
                #region Trace
                traza.Operacion = MethodBase.GetCurrentMethod().Name;
                traza.FechaEjecucion = DateTime.Now;
                #endregion

                LibreriaCN libreriaCN = new LibreriaCN();
                res = libreriaCN.AgregarEditorial(Editorial);

                #region Traza
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion
            }
            catch (Exception ex)
            {
                res.Codigo = Enums.CodigoRespuesta.InternalServiceError;
                res.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.InternalServiceError);
                res.ErrorDePila = ex.Message + " - " + ex.StackTrace;
                traza.DetalleDeExcepcion = ex.Message + " - " + ex.StackTrace;
                #region Trace
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion

            }
            finally
            {
                GuardarLog(traza);
            }

            return res;
        }
        /// <summary>
        /// Exposision metodo para agregar libro
        /// </summary>
        /// <param name="Libro"></param>
        /// <returns></returns>
        public DTOResultado AgregarLibro(DTOLibroCuerpo Libro)
        {
            DTOResultado res = new DTOResultado();
            TrazaServicio traza = new TrazaServicio();
            try
            {
                #region Trace
                traza.Operacion = MethodBase.GetCurrentMethod().Name;
                traza.FechaEjecucion = DateTime.Now;
                #endregion

                LibreriaCN libreriaCN = new LibreriaCN();
                res = libreriaCN.AgregarLibro(Libro);

                #region Traza
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion
            }
            catch (Exception ex)
            {
                res.Codigo = Enums.CodigoRespuesta.InternalServiceError;
                res.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.InternalServiceError);
                res.ErrorDePila = ex.Message + " - " + ex.StackTrace;
                traza.DetalleDeExcepcion = ex.Message + " - " + ex.StackTrace;
                #region Trace
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion

            }
            finally
            {
                GuardarLog(traza);
            }

            return res;
        }

        /// <summary>
        /// Exposicion metodo de  consultar editorial
        /// </summary>
        /// <returns></returns>
        public DTOEdiitorialRespuesta ObtenerEditorial()
        {
            DTOEdiitorialRespuesta resEditorial = new DTOEdiitorialRespuesta();
            TrazaServicio traza = new TrazaServicio();
            try
            {
                #region Trace
                traza.Operacion = MethodBase.GetCurrentMethod().Name;
                traza.FechaEjecucion = DateTime.Now;
                #endregion

                LibreriaCN libreriaCN = new LibreriaCN();
                resEditorial = libreriaCN.ObtenerEditorial();

                #region Traza
                traza.Respuesta = Herramientas.Serialize(resEditorial);
                #endregion
            }
            catch (Exception ex)
            {
                DTOResultado res = new DTOResultado();
                res.Codigo = Enums.CodigoRespuesta.InternalServiceError;
                res.Mensaje = Herramientas.GetEnumDescription<Enums.CodigoRespuesta>(Enums.CodigoRespuesta.InternalServiceError);
                res.ErrorDePila = ex.Message + " - " + ex.StackTrace;
                traza.DetalleDeExcepcion = ex.Message + " - " + ex.StackTrace;
                resEditorial.Resultado = res;
                #region Trace
                traza.Respuesta = Herramientas.Serialize(res);
                #endregion

            }
            finally
            {
                GuardarLog(traza);
            }
            return resEditorial; 
        }

        private void GuardarLog(TrazaServicio traza)
        {
            //Metodo utilziado para guardar traza en diferentes opciones dependiendo la implementacion, ya sea en un servicio web alterno o directsamente en base de datos, incluseve en archivos planos.
        }
    }
}

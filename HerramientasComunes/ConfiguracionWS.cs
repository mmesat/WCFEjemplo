using System;
using System.Configuration;

namespace HerramientasComunes
{
    public class ConfiguracionWS
    {
        /// <summary>
        /// Validacion cadena de conexion
        /// </summary>
        /// <returns></returns>
        public static string ObtewnerCadenaDeConexion()
        {
            var valor = ConfigurationManager.ConnectionStrings["Conexion"];

            if (valor == null)
            {
                throw new Exception("Conexion a Base de datos no configurada.");
            }

            return valor.ToString();
        }
    }
}

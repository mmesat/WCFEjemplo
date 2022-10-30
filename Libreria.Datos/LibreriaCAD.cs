using Dapper;
using HerramientasComunes;
using Libreria.Entidades.WCF.Editorial;
using Libreria.Entidades.WCF.Libro;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace Libreria.Datos
{
    public class LibreriaCAD
    {
        /// <summary>
        /// Acceso a datos consulta editorial
        /// </summary>
        /// <returns></returns>
        public List<DTOEditorialCuerpo> ObtenerEditorial()
        {
            List<DTOEditorialCuerpo> Cuerpo = null;
            using (SqlConnection conexion = new SqlConnection(ConfiguracionWS.ObtewnerCadenaDeConexion()))
            {
                Cuerpo = conexion.Query<DTOEditorialCuerpo>("dbo.SP_ObtenerEditorial", transaction: null, buffered: false, commandTimeout: null, commandType: CommandType.StoredProcedure).ToList();
            }
            return Cuerpo;
        }
        /// <summary>
        /// Acceso a datos isnercion del libro se usa el DTO libro para isnertar
        /// </summary>
        /// <param name="libro"></param>
        public void AgregarLibro(DTOLibroCuerpo libro)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Titulo", libro.Titulo);
            parameters.Add("@Sinopsis", libro.Sinopsis);
            parameters.Add("@NPaginas", libro.Npaginas);
            parameters.Add("@EditorialId", libro.EditorialesId);
            using (SqlConnection conexion = new SqlConnection(ConfiguracionWS.ObtewnerCadenaDeConexion()))
            {
                conexion.Execute("dbo.AgregarLibro", param: parameters, transaction: null, commandTimeout: null, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Acceso a datos inserccion de editorial parametro DTO editorial como entrada
        /// </summary>
        /// <param name="editorial"></param>
        public void AgregarEditorial(DTOEditorialCuerpo editorial)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Nombre", editorial.Nombre);
            parameters.Add("@Sede", editorial.Sede);
            using (SqlConnection conexion = new SqlConnection(ConfiguracionWS.ObtewnerCadenaDeConexion()))
            {
                conexion.Execute("dbo.AgregarEditorial", param: parameters, transaction: null, commandTimeout: null, commandType: CommandType.StoredProcedure);
            }
        }
    }
}

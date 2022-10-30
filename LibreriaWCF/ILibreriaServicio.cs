using Libreria.Entidades.WCF;
using Libreria.Entidades.WCF.Editorial;
using Libreria.Entidades.WCF.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibreriaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ILibreriaServicio" en el código y en el archivo de configuración a la vez.
    /// <summary>
    /// Interfaces del servicio
    /// </summary>
    [ServiceContract]
    public interface ILibreriaServicio
    {
        [OperationContract]
        DTOResultado AgregarEditorial(DTOEditorialCuerpo Editorial);
        [OperationContract]
        DTOResultado AgregarLibro(DTOLibroCuerpo Libro);
        [OperationContract]
        DTOEdiitorialRespuesta ObtenerEditorial();
    }
}

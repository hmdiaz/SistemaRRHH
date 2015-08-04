using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BAL;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISistemaRRHHServices" in both code and config file together.
    [ServiceContract]
    public interface ISistemaRRHHServices
    {
        #region Carga de catálogos
        [OperationContract]
        List<Catalogo> CargarCatalogoWCF(string listado);
        [OperationContract]
        List<Catalogo> CargarCatalogoDependienteWCF(string listado, string id);
        #endregion        
    }
}

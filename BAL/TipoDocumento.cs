using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class TipoDocumento
    {
        // Id del Tipo de Documento
        [DataMember]
        public int TipoDocumentoID { get; set; }

        // Nombre del Tipo de Documento
        [DataMember]
        public string NombreTipoDocumento { get; set; }
    }
}

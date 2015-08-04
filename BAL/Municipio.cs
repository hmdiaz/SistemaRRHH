using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class Municipio
    {
        // Id del Municipio
        [DataMember]
        public int MunicipioID { get; set; }

        // Nombre del Municipio
        [DataMember]
        public string NombreMunicipio { get; set; }        
    }
}

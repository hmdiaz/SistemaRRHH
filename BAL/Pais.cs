using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class Pais
    {
        // Id del Pais
        [DataMember]
        public int PaisID { get; set; }

        // Nombre del Pais
        [DataMember]
        public string NombrePais { get; set; }
    }
}

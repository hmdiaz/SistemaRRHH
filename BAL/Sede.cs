using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class Sede
    {
        // Id de la Sede
        [DataMember]
        public int SedeID { get; set; }

        // Nombre de la Sede
        [DataMember]
        public string NombreSede { get; set; }
    }
}

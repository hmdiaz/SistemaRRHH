using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class Cargo
    {
        // Id del Cargo
        [DataMember]
        public int CargoID { get; set; }

        // Nombre del Cargo
        [DataMember]
        public string NombreCargo { get; set; }
    }
}

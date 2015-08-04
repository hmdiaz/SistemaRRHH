using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class Area
    {
        // Id del Area
        [DataMember]
        public int AreaID { get; set; }

        // Nombre del Area
        [DataMember]
        public string NombreArea { get; set; }
    }
}

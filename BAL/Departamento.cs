using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class Departamento
    {
        // Id del Departamento
        [DataMember]
        public int DepartamentoID { get; set; }

        // Nombre del Departamento
        [DataMember]
        public string NombreDepartamento { get; set; }
    }
}

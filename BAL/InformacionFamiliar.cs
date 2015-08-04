using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class InformacionFamiliar
    {
        // Id 
        [DataMember]
        public int InformacionFamiliarID { get; set; }

        // Nombres del Integrante
        [DataMember]
        public string Nombres { get; set; }

        // Apellidos del Integrante
        [DataMember]
        public string Apellidos { get; set; }

        // Fecha de Nacimiento del Integrante
        [DataMember]
        public DateTime FechaNacimiento { get; set; }

        // Ocupación del Integrante
        [DataMember]
        public string Ocupacion { get; set; }

        // Id del Parentesco
        [DataMember]
        public int ParentescoID { get; set; }

        // Nombre Parentesco del Integrante
        [DataMember]
        public string NombreParentesco { get; set; }

        // Edad del Integrante
        [DataMember]
        public int Edad { get; set; }

        // Id del Usuario
        [DataMember]
        public int UsuarioID { get; set; }

        // Id del Empleado
        [DataMember]
        public int EmpleadoID { get; set; }
    }
}
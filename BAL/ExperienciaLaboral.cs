using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class ExperienciaLaboral
    {
        // Id 
        [DataMember]
        public int ExperienciaLaboralID { get; set; }

        // Empresa donde laboró
        [DataMember]
        public string Empresa { get; set; }

        // Cargo desempeñado
        [DataMember]
        public string Cargo { get; set; }

        // Funciones desempeñadas
        [DataMember]
        public string Funciones { get; set; }
        
        // Fecha en que Ingresó a la empresa
        [DataMember]
        public DateTime FechaIngreso { get; set; }

        // Fecha en que se retiró de la empresa
        [DataMember]
        public DateTime FechaRetiro { get; set; }

        // Sector en el que laboró
        [DataMember]
        public string NombreSector { get; set; }

        // Area de Trabajo
        [DataMember]
        public string NombreAreaTrabajo { get; set; }

        // Municipio donde laboró
        [DataMember]
        public string Municipio { get; set; }

        // Departamento donde laboró
        [DataMember]
        public string Departamento { get; set; }

        // Id del Empleado
        [DataMember]
        public int EmpleadoID { get; set; }

        // Id del Usuario
        [DataMember]
        public int UsuarioID { get; set; }
    }
}
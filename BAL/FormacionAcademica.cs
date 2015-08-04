using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class FormacionAcademica
    {
        // Id 
        [DataMember]
        public int FormacionAcademicaID { get; set; }

        // Institucion donde Realizó el Estudio el Empleado
        [DataMember]
        public string Institucion { get; set; }

        // Titulo Obtenido por el Empleado
        [DataMember]
        public string TituloObtenido { get; set; }

        // ID del Nivel Formacion
        [DataMember]
        public int NivelFormacionID { get; set; }

        // Nombre del Nivel de Formacion
        [DataMember]
        public string NombreNivelFormacion { get; set; }

        // Fecha en que Inició el Estudio
        [DataMember]
        public DateTime FechaInicio { get; set; }

        // Fecha en que Finalizó el Estudio
        [DataMember]
        public DateTime? FechaFinalizacion { get; set; }

        // Municipio
        [DataMember]
        public string Municipio { get; set; }

        // Departamento
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
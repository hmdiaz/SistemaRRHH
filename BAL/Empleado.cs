using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BAL
{
    [DataContract]
    public class Empleado
    {
        /// <summary>
        /// Id del Usuario
        /// </summary>
        [DataMember]
        public int UsuarioID { get; set; }

        /// <summary>
        /// Primer Nombre del Empleado
        /// </summary>
        [DataMember]
        public string PrimerNombre { get; set; }

        /// <summary>
        /// Segundo Nombre del Empleado
        /// </summary>
        [DataMember]
        public string SegundoNombre { get; set; }

        /// <summary>
        /// Primer Apellido del Empleado
        /// </summary>
        [DataMember]
        public string PrimerApellido { get; set; }

        /// <summary>
        /// Segundo Apellido del Empleado
        /// </summary>
        [DataMember]
        public string SegundoApellido { get; set; }

        /// <summary>
        ///  Id del Tipo de Documento
        /// </summary>
        [DataMember]
        public int TipoDocumentoID { get; set; }

        /// <summary>
        /// Documento de Identidad del Empleado
        /// </summary>
        [DataMember]
        public string Documento { get; set; }

        /// <summary>
        /// Número de Empleado
        /// </summary>
        [DataMember]
        public string NumeroEmpleado { get; set; }

        /// <summary>
        /// Id del Cargo del Empleado
        /// </summary>
        [DataMember]
        public int CargoID { get; set; }

        /// <summary>
        /// Nombre del Cargo
        /// </summary>
        [DataMember]
        public string NombreCargo { get; set; }

        /// <summary>
        /// Id del Area
        /// </summary>
        [DataMember]
        public int AreaID { get; set; }

        /// <summary>
        /// Nombre del Área
        /// </summary>
        [DataMember]
        public string NombreArea { get; set; }

        /// <summary>
        /// Nombre de Usuario del Empleado
        /// </summary>
        [DataMember]
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Correo Electronico Institucional del Empleado
        /// </summary>
        [DataMember]
        public string CorreoElectronico { get; set; }

        /// <summary>
        /// Correo Electronico Personal del Empleado
        /// </summary>
        [DataMember]
        public string CorreoElectronicoPersonal { get; set; }
        
        /// <summary>
        /// Fecha de Activación del Empleado
        /// </summary>
        [DataMember]
        public DateTime FechaActivacion { get; set; }

        /// <summary>
        /// Id del Empleado
        /// </summary>
        [DataMember]
        public int EmpleadoID { get; set; }

        /// <summary>
        /// Fecha de Nacimiento del Empleado
        /// </summary>
        [DataMember]
        public DateTime FechaNacimiento { get; set; }

        /// <summary>
        /// Dirección de Residencia del Empleado
        /// </summary>
        [DataMember]
        public string DireccionResidencia { get; set; }

        /// <summary>
        /// Barrio donde Reside el Empleado
        /// </summary>
        [DataMember]
        public string Barrio { get; set; }

        /// <summary>
        /// Teléfono Fijo del Empleado
        /// </summary>
        [DataMember]
        public string TelefonoFijo { get; set; }

        /// <summary>
        /// Celular del Empleado
        /// </summary>
        [DataMember]
        public string CelularPersonal { get; set; }

        /// <summary>
        /// Celular del Empleado
        /// </summary>
        [DataMember]
        public string CelularCorporativo { get; set; }

        /// <summary>
        /// Grupo Sanguineo del Empleado
        /// </summary>
        [DataMember]
        public string GrupoSanguineo { get; set; }

        /// <summary>
        /// Estado Civil del Empleado
        /// </summary>
        [DataMember]
        public string EstadoCivil { get; set; }

        /// <summary>
        /// Id del Municipio
        /// </summary>
        [DataMember]
        public int MunicipioID { get; set; }

        /// <summary>
        /// Id del Departamento
        /// </summary>
        [DataMember]
        public int DepartamentoID { get; set; }

        /// <summary>
        /// Id del País
        /// </summary>
        [DataMember]
        public int PaisID { get; set; }

        /// <summary>
        /// Foto del Empleado
        /// </summary>
        [DataMember]
        public byte[] FotoEmpleado { get; set; }

        /// <summary>
        /// Estado Civil del Empleado
        /// </summary>
        [DataMember]
        public string NombreSede { get; set; }

        /// <summary>
        /// Nombre del Municipio de la Sede
        /// </summary>
        [DataMember]
        public string MunicipioSede { get; set; }

        /// <summary>
        /// Nombre del Departamento de la Sede
        /// </summary>
        [DataMember]
        public string DepartamentoSede { get; set; }

        /// <summary>
        /// Nombre del País de la Sede
        /// </summary>
        [DataMember]
        public string PaisSede { get; set; }

        /// <summary>
        /// Id del Municipio
        /// </summary>
        [DataMember]
        public int SedeID { get; set; }

        /// <summary>
        /// Id del Municipio de la Sede
        /// </summary>
        [DataMember]
        public int MunicipioSedeID { get; set; }

        /// <summary>
        /// Id del Departamento de la Sede
        /// </summary>
        [DataMember]
        public int DepartamentoSedeID { get; set; }

        /// <summary>
        /// Id del País de la Sede
        /// </summary>
        [DataMember]
        public int PaisSedeID { get; set; }

        /// <summary>
        /// Total de Registros
        /// </summary>
        [DataMember]
        public int TotalRegistros { get; set; }
    }
}

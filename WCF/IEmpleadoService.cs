using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BAL;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpleadoService" in both code and config file together.
    [ServiceContract]
    public interface IEmpleadoService
    {
        [OperationContract]
        List<Empleado> ObtenerEmpleadoByUsuarioID(int UsuarioID);

        [OperationContract]
        int ActualizarInformacionUsuario(int UsuarioID, string PrimerNombre, string SegundoNombre, string PrimerApellido, 
                   string SegundoApellido, int TipoDocumentoID, string Documento, int CargoID, DateTime FechaNacimiento,
                   string DireccionResidencia, string Barrio, string TelefonoFijo, string CelularPersonal, string CelularCorporativo,
                   string CorreoPersonal, string CorreoCorporativo, string GrupoSanguineo, string EstadoCivil, int MunicipioID, 
                   int SedeID);

        [OperationContract]
        List<InformacionFamiliar> ObtenerInformacionFamiliarEmpleadoByUsuarioID(int UsuarioID);

        [OperationContract]
        List<ExperienciaLaboral> ObtenerExperienciaLaboralEmpleadoByUsuarioID(int UsuarioID);

        [OperationContract]
        int GuardarInformacionFamiliar(int EmpleadoID, string Nombres, string Apellidos, string Ocupacion, DateTime FechaNacimiento, 
                 int ParentescoID);

        [OperationContract]
        List<FormacionAcademica> ObtenerFormacionAcademicaEmpleadoByUsuarioID(int UsuarioID);

        [OperationContract]
        int GuardarInformacionAcademica(int EmpleadoID, string Institucion, string TituloObtenido, 
                                        int NivelFormacionID, DateTime FechaInicio, DateTime? FechaFinalizacion, int MunicipioID);

        [OperationContract]
        int GuardarExperienciaLaboral(int EmpleadoID, string Empresa, int SectorID, int AreaTrabajoID,
                                      string Cargo, DateTime FechaIngreso, DateTime FechaRetiro,
                                      string Funciones, int MunicipioID);

        [OperationContract]
        List<Empleado> ObtenerEmpleados(int NoPagina, int NoRegistros, string Login, string NumeroEmpleado, string Cedula, string PrimerApellido, 
                                        string SegundoApellido, string Nombres, int AreaID, int CargoID);

        [OperationContract]
        int EliminarInformacionFamiliarEmpleadoByID(int InformacionFamiliarID);

        [OperationContract]
        int EliminarFormacionAcademicaEmpleadoByID(int FormacionAcademicaID);

        [OperationContract]
        int EliminarExperienciaLaboralEmpleadoByID(int ExperienciaLaboralID);
    }
}

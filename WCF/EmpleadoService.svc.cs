using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BAL;
using DAL;
using System.Diagnostics;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmpleadoService" in code, svc and config file together.
    public class EmpleadoService : IEmpleadoService
    {
        public List<Empleado> ObtenerEmpleadoByUsuarioID(int UsuarioID)
        {
            List<Empleado> listado = new List<Empleado>();
            try
            {
                listado = new EmpleadoDAL().ObtenerEmpleadoByUsuarioID(UsuarioID);
            }
            catch (Exception ex)
            {
                //if (!EventLog.SourceExists("SistemaRRHH App"))
                //    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                //EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return listado;
        }

        public int ActualizarInformacionUsuario(int UsuarioID, string PrimerNombre, string SegundoNombre,
                   string PrimerApellido, string SegundoApellido, int TipoDocumentoID,
                   string Documento, int CargoID, DateTime FechaNacimiento,
                   string DireccionResidencia, string Barrio, string TelefonoFijo,
                   string CelularPersonal, string CelularCorporativo,
                   string CorreoPersonal, string CorreoCorporativo, string GrupoSanguineo,
                   string EstadoCivil, int MunicipioID, int SedeID) 
        {
                       int n = 0;
                       try
                       {
                           n = new EmpleadoDAL().ActualizarInformacionUsuario(UsuarioID, PrimerNombre, SegundoNombre,
                           PrimerApellido, SegundoApellido, TipoDocumentoID,
                           Documento, CargoID, FechaNacimiento,
                           DireccionResidencia, Barrio, TelefonoFijo,
                           CelularPersonal, CelularCorporativo,
                           CorreoPersonal, CorreoCorporativo, GrupoSanguineo, EstadoCivil, MunicipioID, SedeID);
                       }
                       catch (Exception ex) {
                           if (!EventLog.SourceExists("SistemaRRHH App"))
                               EventLog.CreateEventSource("SistemaRRHH App", "Application");

                           EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
                       }

                       return n;
        
        }

        public int GuardarInformacionFamiliar(int EmpleadoID, string Nombres, string Apellidos, 
                                              string Ocupacion, DateTime FechaNacimiento, int ParentescoID) 
        {
            int n = 0;
            try
            {
                n = new EmpleadoDAL().GuardarInformacionFamiliar(EmpleadoID, Nombres, Apellidos, Ocupacion, FechaNacimiento, ParentescoID);
            }
            catch (Exception ex) 
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return n;
        }

        public List<InformacionFamiliar> ObtenerInformacionFamiliarEmpleadoByUsuarioID(int UsuarioID) 
        {
            List<InformacionFamiliar> listado = new List<InformacionFamiliar>();
            try
            {
                listado = new EmpleadoDAL().ObtenerInformacionFamiliarEmpleadoByUsuarioID(UsuarioID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return listado;
        }

        public List<FormacionAcademica> ObtenerFormacionAcademicaEmpleadoByUsuarioID(int UsuarioID) 
        {
            List<FormacionAcademica> listado = new List<FormacionAcademica>();
            try
            {
                listado = new EmpleadoDAL().ObtenerFormacionAcademicaEmpleadoByUsuarioID(UsuarioID);
            }
            catch (Exception ex) 
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return listado;
        }

        public List<ExperienciaLaboral> ObtenerExperienciaLaboralEmpleadoByUsuarioID(int UsuarioID)
        {
            List<ExperienciaLaboral> listado = new List<ExperienciaLaboral>();
            try
            {
                listado = new EmpleadoDAL().ObtenerExperienciaLaboralEmpleadoByUsuarioID(UsuarioID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return listado;
        }

        public int GuardarInformacionAcademica(int EmpleadoID, string Institucion, string TituloObtenido, 
                                               int NivelFormacionID, DateTime FechaInicio, DateTime? FechaFinalizacion, 
                                               int MunicipioID)
        {
            int n = 0;
            try
            {
                n = new EmpleadoDAL().GuardarInformacionAcademica(EmpleadoID, Institucion, TituloObtenido, NivelFormacionID, FechaInicio, FechaFinalizacion, MunicipioID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return n;
        }

        public int GuardarExperienciaLaboral(int EmpleadoID, string Empresa, int SectorID, int AreaTrabajoID,
                                             string Cargo, DateTime FechaIngreso, DateTime FechaRetiro,
                                             string Funciones, int MunicipioID)
        {
            int n = 0;
            try
            {
                n = new EmpleadoDAL().GuardarExperienciaLaboral(EmpleadoID, Empresa, SectorID, AreaTrabajoID,
                                             Cargo, FechaIngreso, FechaRetiro, Funciones, MunicipioID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return n;
        }

        public List<Empleado> ObtenerEmpleados(int NoPagina, int NoRegistros, string Login, string NumeroEmpleado, string Cedula, string PrimerApellido, 
                                               string SegundoApellido, string Nombres, int AreaID, int CargoID)
        {
            List<Empleado> listado = new List<Empleado>();
            try
            {
                listado = new EmpleadoDAL().ObtenerEmpleados(NoPagina, NoRegistros, Login, NumeroEmpleado, Cedula, PrimerApellido, 
                                                             SegundoApellido, Nombres, AreaID, CargoID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return listado;
        }

        public int EliminarInformacionFamiliarEmpleadoByID(int InformacionFamiliarID)
        {
            int n = 0;
            try
            {
                n = new EmpleadoDAL().EliminarInformacionFamiliarEmpleadoByID(InformacionFamiliarID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return n;
        }

        public int EliminarFormacionAcademicaEmpleadoByID(int FormacionAcademicaID)
        {
            int n = 0;
            try
            {
                n = new EmpleadoDAL().EliminarFormacionAcademicaEmpleadoByID(FormacionAcademicaID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return n;
        }

        public int EliminarExperienciaLaboralEmpleadoByID(int ExperienciaLaboralID)
        {
            int n = 0;
            try
            {
                n = new EmpleadoDAL().EliminarExperienciaLaboralEmpleadoByID(ExperienciaLaboralID);
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("SistemaRRHH App"))
                    EventLog.CreateEventSource("SistemaRRHH App", "Application");

                EventLog.WriteEntry("SistemaRRHH App", string.Format("Error: {0}. StackTrace: {1}", ex.Message, ex.StackTrace), EventLogEntryType.Error);
            }
            return n;
        }
    }
}

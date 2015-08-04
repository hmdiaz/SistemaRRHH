using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BAL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class EmpleadoDAL
    {
        public List<Empleado> ObtenerEmpleadoByUsuarioID(int UsuarioID) {
            List<Empleado> listado = new List<Empleado>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[sps_GetEmpleadoUsuarioId]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                DataTable dataTable = new DataTable();
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pUsuarioID", SqlDbType.Int)).Value = UsuarioID;
                adaptador.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Empleado empleado = new Empleado()
                    {
                        UsuarioID = Int32.Parse(row["UsuarioID"].ToString()),
                        PrimerNombre = row["PrimerNombre"].ToString(),
                        SegundoNombre = row["SegundoNombre"].ToString(),
                        PrimerApellido = row["PrimerApellido"].ToString(),
                        SegundoApellido = row["SegundoApellido"].ToString(),
                        TipoDocumentoID = Int32.Parse(row["TipoDocumentoID"].ToString()),
                        Documento = row["Documento"].ToString(),
                        NumeroEmpleado = row["NumeroEmpleado"].ToString(),
                        CargoID = Int32.Parse(row["CargoID"].ToString()),
                        NombreUsuario = row["NombreUsuario"].ToString(),
                        CorreoElectronico = row["CorreoElectronico"].ToString(),
                        FechaActivacion = DateTime.Parse(row["FechaActivacion"].ToString()),
                        EmpleadoID = Int32.Parse(row["EmpleadoID"].ToString()),
                        FechaNacimiento = DateTime.Parse(row["FechaNacimiento"].ToString()),
                        DireccionResidencia = row["DireccionResidencia"].ToString(),
                        TelefonoFijo = row["TelefonoFijo"].ToString(),
                        CelularPersonal = row["CelularPersonal"].ToString(),
                        CelularCorporativo = row["CelularCorporativo"].ToString(),
                        CorreoElectronicoPersonal = row["CorreoElectronicoPersonal"].ToString(),
                        GrupoSanguineo = row["GrupoSanguineo"].ToString(),
                        EstadoCivil = row["EstadoCivil"].ToString(),
                        MunicipioID = Int32.Parse(row["MunicipioID"].ToString()),
                        DepartamentoID = Int32.Parse(row["DepartamentoID"].ToString()),
                        PaisID = Int32.Parse(row["PaisID"].ToString()),
                        Barrio = row["Barrio"].ToString(),
                        AreaID = Int32.Parse(row["AreaID"].ToString()),
                        NombreSede = row["NombreSede"].ToString(),
                        SedeID = Int32.Parse(row["SedeID"].ToString()),
                        MunicipioSedeID = Int32.Parse(row["MunicipioSedeID"].ToString()),
                        DepartamentoSedeID = Int32.Parse(row["DepartamentoSedeID"].ToString()),
                        PaisSedeID = Int32.Parse(row["PaisSedeID"].ToString()),
                        MunicipioSede = row["MunicipioSede"].ToString(),
                        DepartamentoSede = row["DepartamentoSede"].ToString(),
                        PaisSede = row["PaisSede"].ToString()
                    };

                    listado.Add(empleado);
                }
            }
            return listado;
        }

        public List<InformacionFamiliar> ObtenerInformacionFamiliarEmpleadoByUsuarioID(int UsuarioID)
        {
            List<InformacionFamiliar> listado = new List<InformacionFamiliar>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[sps_GetInformacionFamiliarEmpleado]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                DataTable dataTable = new DataTable();
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pUsuarioID", SqlDbType.Int)).Value = UsuarioID;
                adaptador.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    InformacionFamiliar info = new InformacionFamiliar()
                    {
                        InformacionFamiliarID = Int32.Parse(row["InformacionFamiliarID"].ToString()),
                        Nombres = row["Nombres"].ToString(),
                        Apellidos = row["Apellidos"].ToString(),
                        NombreParentesco = row["NombreParentesco"].ToString(),
                        FechaNacimiento = DateTime.Parse(row["FechaNacimiento"].ToString()),
                        Ocupacion = row["Ocupacion"].ToString(),
                        ParentescoID = Int32.Parse(row["ParentescoID"].ToString()),
                        Edad = Int32.Parse(row["Edad"].ToString()),
                        UsuarioID = Int32.Parse(row["UsuarioID"].ToString()),
                        EmpleadoID = Int32.Parse(row["EmpleadoID"].ToString())
                    };                    
                    listado.Add(info);
                }
            }
            return listado;
        }

        public List<FormacionAcademica> ObtenerFormacionAcademicaEmpleadoByUsuarioID(int UsuarioID)
        {
            List<FormacionAcademica> listado = new List<FormacionAcademica>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[sps_GetFormacionAcademicaEmpleado]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                DataTable dataTable = new DataTable();
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pUsuarioID", SqlDbType.Int)).Value = UsuarioID;
                adaptador.Fill(dataTable);
                DateTime? FechaFin = null;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (!row.IsNull("FechaFinalizacion"))
                    {
                        FechaFin = Convert.ToDateTime(row["FechaFinalizacion"]);
                    }
                    else 
                    {
                        FechaFin = null;
                    }

                    FormacionAcademica info = new FormacionAcademica()
                    {
                        FormacionAcademicaID = Int32.Parse(row["FormacionAcademicaID"].ToString()),
                        TituloObtenido = row["TituloObtenido"].ToString(),
                        Institucion = row["Institucion"].ToString(),
                        NombreNivelFormacion = row["NombreNivelFormacion"].ToString(),
                        FechaInicio = DateTime.Parse(row["FechaInicio"].ToString()),
                        FechaFinalizacion = FechaFin,
                        Municipio = row["Municipio"].ToString(),
                        Departamento = row["Departamento"].ToString(),
                        EmpleadoID = Int32.Parse(row["EmpleadoID"].ToString()),
                        UsuarioID = Int32.Parse(row["UsuarioID"].ToString())
                    };
                    listado.Add(info);
                }
            }
            return listado;
        }

        public List<ExperienciaLaboral> ObtenerExperienciaLaboralEmpleadoByUsuarioID(int UsuarioID)
        {
            List<ExperienciaLaboral> listado = new List<ExperienciaLaboral>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[sps_GetExperienciaLaboral]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                DataTable dataTable = new DataTable();
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pUsuarioID", SqlDbType.Int)).Value = UsuarioID;
                adaptador.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    ExperienciaLaboral info = new ExperienciaLaboral()
                    {
                        ExperienciaLaboralID = Int32.Parse(row["ExperienciaLaboralID"].ToString()),
                        Empresa = row["Empresa"].ToString(),
                        Cargo = row["Cargo"].ToString(),
                        FechaIngreso = DateTime.Parse(row["FechaIngreso"].ToString()),
                        FechaRetiro = DateTime.Parse(row["FechaRetiro"].ToString()),
                        Funciones = row["Funciones"].ToString(),
                        NombreSector = row["NombreSector"].ToString(),
                        NombreAreaTrabajo = row["NombreAreaTrabajo"].ToString(),  
                        Municipio = row["Municipio"].ToString(),
                        Departamento = row["Departamento"].ToString(),
                        EmpleadoID = Int32.Parse(row["EmpleadoID"].ToString()),
                        UsuarioID = Int32.Parse(row["UsuarioID"].ToString())
                    };
                    listado.Add(info);
                }
            }
            return listado;
        }

        public byte[] ObtenerFotoEmpleado(int EmpleadoID)
        {
            List<Empleado> listado = new List<Empleado>();
            byte[] foto = null;
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[sps_GetFotoEmpleado]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {                
                DataTable dataTable = new DataTable();
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pEmpleadoID", SqlDbType.Int)).Value = EmpleadoID;
                adaptador.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Empleado info = new Empleado()
                    {
                        FotoEmpleado = row["FotoEmpleado"] != null ? (byte[])row["FotoEmpleado"] : null
                    };
                    listado.Add(info);
                }                                
            }

            return foto = listado.FirstOrDefault().FotoEmpleado;
        }

        public int ActualizarInformacionUsuario(int UsuarioID, string PrimerNombre, string SegundoNombre, 
                   string PrimerApellido, string SegundoApellido, int TipoDocumentoID, 
                   string Documento, int CargoID, DateTime FechaNacimiento,
                   string DireccionResidencia, string Barrio, string TelefonoFijo, 
                   string CelularPersonal, string CelularCorporativo, string CorreoPersonal, string CorreoCorporativo,
                   string GrupoSanguineo, string EstadoCivil, int MunicipioID, int SedeID) {

                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spu_Empleado]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        # region Parámetros
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pUsuarioID", SqlDbType.Int)).Value = UsuarioID;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pPrimerNombre", SqlDbType.VarChar)).Value = PrimerNombre;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pSegundoNombre", SqlDbType.VarChar)).Value = SegundoNombre;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pPrimerApellido", SqlDbType.VarChar)).Value = PrimerApellido;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pSegundoApellido", SqlDbType.VarChar)).Value = SegundoApellido;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pTipoDocumentoID", SqlDbType.Int)).Value = TipoDocumentoID;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pDocumento", SqlDbType.VarChar)).Value = Documento;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCargoID", SqlDbType.Int)).Value = CargoID;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFechaNacimiento", SqlDbType.DateTime)).Value = FechaNacimiento;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pDireccionResidencia", SqlDbType.VarChar)).Value = DireccionResidencia;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pBarrio", SqlDbType.VarChar)).Value = Barrio;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pTelefonoFijo", SqlDbType.VarChar)).Value = TelefonoFijo;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCelularPersonal", SqlDbType.VarChar)).Value = CelularPersonal;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCelularCorporativo", SqlDbType.VarChar)).Value = CelularCorporativo;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pGrupoSanguineo", SqlDbType.VarChar)).Value = GrupoSanguineo;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pEstadoCivil", SqlDbType.VarChar)).Value = EstadoCivil;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCorreoElectronico", SqlDbType.VarChar)).Value = CorreoCorporativo;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCorreoElectronicoPersonal", SqlDbType.VarChar)).Value = CorreoPersonal;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pMunicipioID", SqlDbType.Int)).Value = MunicipioID;
                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pSedeID", SqlDbType.Int)).Value = SedeID;

                        SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                        retval.Direction = ParameterDirection.ReturnValue;
                        #endregion

                        adaptador.SelectCommand.Connection.Open();
                        adaptador.SelectCommand.ExecuteNonQuery();

                        return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);
                    }
        }

        public int GuardarInformacionFamiliar(int EmpleadoID, string Nombres, string Apellidos, string Ocupacion, DateTime FechaNacimiento, int ParentescoID) 
        {
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spi_InformacionFamiliar]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                # region Parámetros
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pEmpleadoID", SqlDbType.Int)).Value = EmpleadoID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pNombres", SqlDbType.VarChar)).Value = Nombres;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pApellidos", SqlDbType.VarChar)).Value = Apellidos;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pOcupacion", SqlDbType.VarChar)).Value = Ocupacion;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFechaNacimiento", SqlDbType.DateTime)).Value = FechaNacimiento;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pParentescoID", SqlDbType.Int)).Value = ParentescoID;

                SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                #endregion

                adaptador.SelectCommand.Connection.Open();
                adaptador.SelectCommand.ExecuteNonQuery();

                return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);
            }
        }

        public int GuardarInformacionAcademica(int EmpleadoID, string Institucion, string TituloObtenido, int NivelFormacionID, DateTime FechaInicio, DateTime? FechaFinalizacion, int MunicipioID)
        {
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spi_InformacionAcademica]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                # region Parámetros
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                //if (FechaFinalizacion == DateTime.MinValue)
                //{
                //    FechaFinalizacion = null;
                //}

                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pEmpleadoID", SqlDbType.Int)).Value = EmpleadoID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pInstitucion", SqlDbType.VarChar)).Value = Institucion;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pTituloObtenido", SqlDbType.VarChar)).Value = TituloObtenido;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pNivelFormacionID", SqlDbType.Int)).Value = NivelFormacionID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFechaInicio", SqlDbType.DateTime)).Value = FechaInicio;
                if (FechaFinalizacion != null)
                {
                    adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFechaFinalizacion", SqlDbType.DateTime)).Value = FechaFinalizacion;
                }
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pMunicipioID", SqlDbType.Int)).Value = MunicipioID;
                
                SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                #endregion

                adaptador.SelectCommand.Connection.Open();
                adaptador.SelectCommand.ExecuteNonQuery();

                return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);
            }
        }

        public int GuardarExperienciaLaboral(int EmpleadoID, string Empresa, int SectorID, int AreaTrabajoID, 
                                             string Cargo, DateTime FechaIngreso, DateTime FechaRetiro,
                                             string Funciones, int MunicipioID)
        {
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spi_ExperienciaLaboral]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                # region Parámetros
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pEmpleadoID", SqlDbType.Int)).Value = EmpleadoID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pEmpresa", SqlDbType.VarChar)).Value = Empresa;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pSectorID", SqlDbType.Int)).Value = SectorID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pAreaTrabajoID", SqlDbType.Int)).Value = AreaTrabajoID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pMunicipioID", SqlDbType.Int)).Value = MunicipioID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCargo", SqlDbType.VarChar)).Value = Cargo;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFechaIngreso", SqlDbType.DateTime)).Value = FechaIngreso;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFechaRetiro", SqlDbType.DateTime)).Value = FechaRetiro;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFunciones", SqlDbType.VarChar)).Value = Funciones;

                SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                #endregion

                adaptador.SelectCommand.Connection.Open();
                adaptador.SelectCommand.ExecuteNonQuery();

                return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);
            }
        }

        public int ActualizarFotoEmpleado(int EmpleadoID, byte[] FotoEmpleado)
        {
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spu_FotoEmpleado]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                # region Parámetros
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pEmpleadoID", SqlDbType.Int)).Value = EmpleadoID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFotoEmpleado", SqlDbType.VarBinary)).Value = FotoEmpleado;

                SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                #endregion

                adaptador.SelectCommand.Connection.Open();
                adaptador.SelectCommand.ExecuteNonQuery();

                return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);
            }
        }

        public List<Empleado> ObtenerEmpleados(int NoPagina, int NoRegistros, string Login, string NumeroEmpleado, string Cedula, string PrimerApellido, 
                                               string SegundoApellido, string Nombres, int AreaID, int CargoID)
        {
            List<Empleado> listado = new List<Empleado>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[sps_GetEmpleados]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                DataTable dataTable = new DataTable();
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pPagina", SqlDbType.Int)).Value = NoPagina;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pRegPorPagina", SqlDbType.Int)).Value = NoRegistros;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pLogin", SqlDbType.VarChar)).Value = Login;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pNumeroEmpleado", SqlDbType.VarChar)).Value = NumeroEmpleado;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCedula", SqlDbType.VarChar)).Value = Cedula;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pPrimerApellido", SqlDbType.VarChar)).Value = PrimerApellido;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pSegundoApellido", SqlDbType.VarChar)).Value = SegundoApellido;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pNombres", SqlDbType.VarChar)).Value = Nombres;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pAreaID", SqlDbType.Int)).Value = AreaID;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pCargoID", SqlDbType.Int)).Value = CargoID;
                adaptador.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Empleado empleado = new Empleado()
                    {
                        UsuarioID = Int32.Parse(row["UsuarioID"].ToString()),
                        EmpleadoID = Int32.Parse(row["EmpleadoID"].ToString()),
                        PrimerNombre = row["PrimerNombre"].ToString(),
                        SegundoNombre = row["SegundoNombre"].ToString(),
                        PrimerApellido = row["PrimerApellido"].ToString(),
                        SegundoApellido = row["SegundoApellido"].ToString(),
                        Documento = row["Documento"].ToString(),
                        NumeroEmpleado = row["NumeroEmpleado"].ToString(),
                        NombreCargo = row["Cargo"].ToString(),
                        NombreArea = row["Area"].ToString(),
                        TotalRegistros = Int32.Parse(row["TotalRegistros"].ToString())
                    };

                    listado.Add(empleado);
                }
            }
            return listado;
        }

        public int EliminarInformacionFamiliarEmpleadoByID(int InformacionFamiliarID)
        {
            List<InformacionFamiliar> listado = new List<InformacionFamiliar>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spd_InformacionFamiliar]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pInformacionFamiliarID", SqlDbType.Int)).Value = InformacionFamiliarID;
                SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;

                adaptador.SelectCommand.Connection.Open();
                adaptador.SelectCommand.ExecuteNonQuery();

                return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);

            }
        }

        public int EliminarFormacionAcademicaEmpleadoByID(int FormacionAcademicaID)
        {
            List<InformacionFamiliar> listado = new List<InformacionFamiliar>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spd_FormacionAcademica]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pFormacionAcademicaID", SqlDbType.Int)).Value = FormacionAcademicaID;
                SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;

                adaptador.SelectCommand.Connection.Open();
                adaptador.SelectCommand.ExecuteNonQuery();

                return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);

            }
        }

        public int EliminarExperienciaLaboralEmpleadoByID(int ExperienciaLaboralID)
        {
            List<InformacionFamiliar> listado = new List<InformacionFamiliar>();
            using (SqlDataAdapter adaptador = new SqlDataAdapter("[RRHH].[spd_ExperienciaLaboral]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
            {
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pExperienciaLaboralID", SqlDbType.Int)).Value = ExperienciaLaboralID;
                SqlParameter retval = adaptador.SelectCommand.Parameters.Add("@pRetorno", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;

                adaptador.SelectCommand.Connection.Open();
                adaptador.SelectCommand.ExecuteNonQuery();

                return Convert.ToInt32(adaptador.SelectCommand.Parameters["@pRetorno"].Value);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BAL;

namespace DAL
{
    public class CatalogoDAL
    {
        // Método para cargar los catálogos
        public List<Catalogo> CargarCatalogoDAL(string listado)
        {
            List<Catalogo> listadoTem = new List<Catalogo>();

            switch (listado)
            {
                case "Pais":
                    #region Pais
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[dbo].[sps_GetPaises]", ConfigurationManager.ConnectionStrings["AztecaCStringSitesDB"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["PaisID"].ToString()),
                                Etiqueta = row["NombrePais"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "PaisesSedes":
                    #region Pais
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_GetPais]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["PaisID"].ToString()),
                                Etiqueta = row["NombrePais"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "Area":
                    #region Area
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[dbo].[sps_Areas]", ConfigurationManager.ConnectionStrings["AztecaCStringSeguridad"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["AreaID"].ToString()),
                                Etiqueta = row["Nombre"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "TipoDocumento":
                    #region Tipo de Documento
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_CatalogoTipoDocumento]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["TipoDocumentoID"].ToString()),
                                Etiqueta = row["Nombre"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "Parentesco":
                    #region Parentesco
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_Parentesco]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["ParentescoID"].ToString()),
                                Etiqueta = row["NombreParentesco"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "NivelFormacion":
                    #region Nivel de Formacion
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_NivelFormacion]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["NivelFormacionID"].ToString()),
                                Etiqueta = row["NombreNivelFormacion"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "Sector":
                    #region Sector
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_Sector]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["SectorID"].ToString()),
                                Etiqueta = row["NombreSector"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "AreaTrabajo":
                    #region Area de Trabajo
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_AreaTrabajo]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["AreaTrabajoID"].ToString()),
                                Etiqueta = row["NombreAreaTrabajo"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                default:
                    break;
            }
            return listadoTem;
        }

        // Método para cargar los catálogos que dependen de un valor seleccionado previamente
        public List<Catalogo> CargarCatalogoDependienteDAL(string listado, string id)
        {
            List<Catalogo> listadoTem = new List<Catalogo>();

            switch (listado)
            {
                case "Departamentos":
                    #region Departamentos
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[dbo].[sps_GetDepartamentosByPais]", ConfigurationManager.ConnectionStrings["AztecaCStringSitesDB"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pPaisID", SqlDbType.Int)).Value = Int32.Parse(id);

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["DepartamentoID"].ToString()),
                                Etiqueta = row["Departamento"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "Municipios":
                    #region Municipios
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[dbo].[sps_Municipios]", ConfigurationManager.ConnectionStrings["AztecaCStringSitesDB"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pDepartamento", SqlDbType.Int)).Value = Int32.Parse(id);

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["MunicipioID"].ToString()),
                                Etiqueta = row["Nombre"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "Cargos":
                    #region Cargos
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[dbo].[sps_CargosPorArea]", ConfigurationManager.ConnectionStrings["AztecaCStringSeguridad"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pAreaID", SqlDbType.Int)).Value = Int32.Parse(id);

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["CargoID"].ToString()),
                                Etiqueta = row["Nombre"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "Sedes":
                    #region Sedes
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_GetSedesByMunicipio]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pMunicipioID", SqlDbType.Int)).Value = Int32.Parse(id);

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["SedeID"].ToString()),
                                Etiqueta = row["NombreSede"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "MunicipiosSedes":
                    #region MunicipiosSedes
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_GetMunicipios]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pDepartamentoID", SqlDbType.Int)).Value = Int32.Parse(id);

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["MunicipioID"].ToString()),
                                Etiqueta = row["Municipio"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                case "DepartamentosSedes":
                    #region DepartamentosSedes
                    using (SqlDataAdapter adaptador = new SqlDataAdapter("[LISTA].[sps_GetDepartamentos]", ConfigurationManager.ConnectionStrings["AztecaCStringSistemaRRHH"].ConnectionString))
                    {
                        DataTable dataTable = new DataTable();
                        adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;

                        adaptador.SelectCommand.Parameters.Add(new SqlParameter("@pPaisID", SqlDbType.Int)).Value = Int32.Parse(id);

                        adaptador.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            Catalogo catalogoTem = new Catalogo()
                            {
                                Id = Int32.Parse(row["DepartamentoID"].ToString()),
                                Etiqueta = row["Departamento"].ToString()
                            };

                            listadoTem.Add(catalogoTem);
                        }
                    }
                    break;
                    #endregion
                default:
                    break;
            }
            return listadoTem;
        }
    }
}

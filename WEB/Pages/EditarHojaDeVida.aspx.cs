using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB.CatalogoService;
using WEB.EmpleadoService;
using System.Threading;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using DAL;
using Tickets.Layouts;

namespace WEB.Pages
{
    public partial class EditarHojaDeVida : PageHelper
    {
        
        private int UsuarioID;
        protected void Page_Load(object sender, EventArgs e)
        {
            Seguridad();
            Session["UsuarioID"] = Int32.Parse(Request.QueryString["Id"]);
            pnlResultado.Visible = false;           
            //PanelAdicionarEstudio.Visible = false;
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient()) 
            {
                if (!Page.IsPostBack) {
                    // Cargamos los Tipos de Documento
                    ddlTipoIdentificacion.DataSource = svc.CargarCatalogoWCF("TipoDocumento");
                    ddlTipoIdentificacion.DataTextField = "Etiqueta";
                    ddlTipoIdentificacion.DataValueField = "Id";
                    ddlTipoIdentificacion.DataBind();
                    ddlTipoIdentificacion.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));

                    // Cargamos los Parentescos
                    ddlParentesco.DataSource = svc.CargarCatalogoWCF("Parentesco");
                    ddlParentesco.DataTextField = "Etiqueta";
                    ddlParentesco.DataValueField = "Id";
                    ddlParentesco.DataBind();
                    ddlParentesco.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));

                    // Cargamos los Sectores
                    ddlSector.DataSource = svc.CargarCatalogoWCF("Sector");
                    ddlSector.DataTextField = "Etiqueta";
                    ddlSector.DataValueField = "Id";
                    ddlSector.DataBind();
                    ddlSector.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));

                    // Cargamos los Area de Trabajo
                    ddlAreaTrabajo.DataSource = svc.CargarCatalogoWCF("AreaTrabajo");
                    ddlAreaTrabajo.DataTextField = "Etiqueta";
                    ddlAreaTrabajo.DataValueField = "Id";
                    ddlAreaTrabajo.DataBind();
                    ddlAreaTrabajo.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                }
            }

            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                if (!IsPostBack)
                {
                    // Cargamos los Datos del Empleado
                    WEB.EmpleadoService.Empleado empleado = svcEmpleado.ObtenerEmpleadoByUsuarioID(Int32.Parse(Session["UsuarioID"].ToString())).FirstOrDefault();
                    Session["EmpleadoID"] = empleado.EmpleadoID;
                    int EmpleadoID = Int32.Parse(Session["EmpleadoID"].ToString());

                    ddlTipoIdentificacion.SelectedValue = empleado.TipoDocumentoID.ToString();
                    txtDocumentoIdentidad.Text = empleado.Documento;
                    txtPrimerNombre.Text = empleado.PrimerNombre;
                    txtSegundoNombre.Text = empleado.SegundoNombre;
                    txtPrimerApellido.Text = empleado.PrimerApellido;
                    txtSegundoApellido.Text = empleado.SegundoApellido;
                    txtFechaNacimiento.Text = empleado.FechaNacimiento.Date.ToShortDateString().ToString();
                    ddlRH.SelectedValue = empleado.GrupoSanguineo;
                    ddlEstadoCivil.SelectedValue = empleado.EstadoCivil;
                    txtDireccion.Text = empleado.DireccionResidencia;
                    txtBarrio.Text = empleado.Barrio;
                    txtTelefonoFijo.Text = empleado.TelefonoFijo;
                    txtCelular.Text = empleado.CelularPersonal;
                    txtCorreoCorporativo.Text = empleado.CorreoElectronico;
                    txtCorreoPersonal.Text = empleado.CorreoElectronicoPersonal;
                    txtCelularCorporativo.Text = empleado.CelularCorporativo;
                    // Seleccionamos el País
                    ddlPais.SelectedValue = empleado.PaisID.ToString();
                    ddlArea.SelectedValue = empleado.AreaID.ToString();
                    ddlCargo.SelectedValue = empleado.CargoID.ToString();
                    ddlSede.SelectedValue = empleado.SedeID.ToString();
                    ddlPaisSede.SelectedValue = empleado.PaisSedeID.ToString();
                    ddlDepartamentoSede.SelectedValue = empleado.DepartamentoSedeID.ToString();
                    ddlMunicipioSede.SelectedValue = empleado.MunicipioSedeID.ToString();

                    byte[] foto = new EmpleadoDAL().ObtenerFotoEmpleado(EmpleadoID);
                    string base64String = Convert.ToBase64String(foto, 0, foto.Length);
                    FotoEmpleado.ImageUrl = "data:image/png;base64," + base64String;

                    lblNumeroEmpleado.Text = "Número de Empleado : " + empleado.NumeroEmpleado;

                    CargarGrids();
                
                    using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
                    {
                        // Cargamos los Paises
                        ddlPais.DataSource = svc.CargarCatalogoWCF("Pais");
                        ddlPais.DataTextField = "Etiqueta";
                        ddlPais.DataValueField = "Id";
                        ddlPais.DataBind();

                        ddlPaisInfoAcademica.DataSource = svc.CargarCatalogoWCF("Pais");
                        ddlPaisInfoAcademica.DataTextField = "Etiqueta";
                        ddlPaisInfoAcademica.DataValueField = "Id";
                        ddlPaisInfoAcademica.DataBind();

                        ddlPaisExperienciaLaboral.DataSource = svc.CargarCatalogoWCF("Pais");
                        ddlPaisExperienciaLaboral.DataTextField = "Etiqueta";
                        ddlPaisExperienciaLaboral.DataValueField = "Id";
                        ddlPaisExperienciaLaboral.DataBind();

                        ddlNivelFormacion.DataSource = svc.CargarCatalogoWCF("NivelFormacion");
                        ddlNivelFormacion.DataTextField = "Etiqueta";
                        ddlNivelFormacion.DataValueField = "Id";
                        ddlNivelFormacion.DataBind();
                        
                        // Cargamos los Departamentos
                        ddlDepartamento.DataSource = svc.CargarCatalogoDependienteWCF("Departamentos", empleado.PaisID.ToString());
                        ddlDepartamento.DataTextField = "Etiqueta";
                        ddlDepartamento.DataValueField = "Id";
                        ddlDepartamento.DataBind();
                        // Seleccionamos el Departamento
                        ddlDepartamento.SelectedValue = empleado.DepartamentoID.ToString();

                        // Cargamos los Departamentos
                        ddlMunicipio.DataSource = svc.CargarCatalogoDependienteWCF("Municipios", empleado.DepartamentoID.ToString());
                        ddlMunicipio.DataTextField = "Etiqueta";
                        ddlMunicipio.DataValueField = "Id";
                        ddlMunicipio.DataBind();
                        //Seleccionamos el Municipio
                        ddlMunicipio.SelectedValue = empleado.MunicipioID.ToString();

                        // Cargamos las Areas
                        ddlArea.DataSource = svc.CargarCatalogoWCF("Area");
                        ddlArea.DataTextField = "Etiqueta";
                        ddlArea.DataValueField = "Id";
                        ddlArea.DataBind();

                        // Cargamos los Cargos
                        ddlCargo.DataSource = svc.CargarCatalogoDependienteWCF("Cargos", empleado.AreaID.ToString());
                        ddlCargo.DataTextField = "Etiqueta";
                        ddlCargo.DataValueField = "Id";
                        ddlCargo.DataBind();

                        // Cargamos los Paises de las Sedes
                        ddlPaisSede.DataSource = svc.CargarCatalogoWCF("PaisesSedes");
                        ddlPaisSede.DataTextField = "Etiqueta";
                        ddlPaisSede.DataValueField = "Id";
                        ddlPaisSede.DataBind();

                        // Cargamos los Departamentos de las Sedes
                        ddlDepartamentoSede.DataSource = svc.CargarCatalogoDependienteWCF("DepartamentosSedes", empleado.PaisSedeID.ToString());
                        ddlDepartamentoSede.DataTextField = "Etiqueta";
                        ddlDepartamentoSede.DataValueField = "Id";
                        ddlDepartamentoSede.DataBind();

                        // Cargamos los Cargos
                        ddlMunicipioSede.DataSource = svc.CargarCatalogoDependienteWCF("MunicipiosSedes", empleado.DepartamentoSedeID.ToString());
                        ddlMunicipioSede.DataTextField = "Etiqueta";
                        ddlMunicipioSede.DataValueField = "Id";
                        ddlMunicipioSede.DataBind();

                        // Cargamos las Sedes
                        ddlSede.DataSource = svc.CargarCatalogoDependienteWCF("Sedes", empleado.MunicipioSedeID.ToString());
                        ddlSede.DataTextField = "Etiqueta";
                        ddlSede.DataValueField = "Id";
                        ddlSede.DataBind();
                        ddlSede.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));

                        // Valores del Option Label
                        ddlDepartamento.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlMunicipio.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlPais.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlArea.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlCargo.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlPaisInfoAcademica.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlPaisExperienciaLaboral.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlNivelFormacion.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlPaisSede.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlDepartamentoSede.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlMunicipioSede.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                    }
                }
            }
        }

        protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient()) 
            {
                // Cargamos los Departamentos
                ddlDepartamento.DataSource = svc.CargarCatalogoDependienteWCF("Departamentos", ddlPais.SelectedValue);
                ddlDepartamento.DataTextField = "Etiqueta";
                ddlDepartamento.DataValueField = "Id";
                ddlDepartamento.DataBind();
                ddlDepartamento.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                ddlMunicipio.Items.Clear();
                ddlMunicipio.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Municipios
                ddlMunicipio.DataSource = svc.CargarCatalogoDependienteWCF("Municipios", ddlDepartamento.SelectedValue);
                ddlMunicipio.DataTextField = "Etiqueta";
                ddlMunicipio.DataValueField = "Id";
                ddlMunicipio.DataBind();
                ddlMunicipio.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void ddlArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos las Áreas
                ddlCargo.DataSource = svc.CargarCatalogoDependienteWCF("Cargos", ddlArea.SelectedValue);
                ddlCargo.DataTextField = "Etiqueta";
                ddlCargo.DataValueField = "Id";
                ddlCargo.DataBind();
                ddlCargo.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void btnActualizarInformacion_Click(object sender, EventArgs e)
        {
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                Thread.Sleep(2000);
                string PrimerNombre = txtPrimerNombre.Text.Trim().ToUpper();
                string SegundoNombre = txtSegundoNombre.Text.Trim().ToUpper();
                string PrimerApellido = txtPrimerApellido.Text.Trim().ToUpper();
                string SegundoApellido = txtSegundoApellido.Text.Trim().ToUpper();
                int TipoDocumentoID = Int32.Parse(ddlTipoIdentificacion.SelectedValue);
                string Documento = txtDocumentoIdentidad.Text.Trim();
                int CargoID = Int32.Parse(ddlCargo.SelectedValue);
                DateTime FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text.Trim());
                string DireccionResidencia = txtDireccion.Text.Trim().ToUpper();
                string Barrio = txtBarrio.Text.Trim().ToUpper();
                string TelefonoFijo = txtTelefonoFijo.Text.Trim();
                string CelularPersonal = txtCelular.Text.Trim();
                string CelularCorporativo = txtCelularCorporativo.Text.Trim();
                string GrupoSanguineo = ddlRH.SelectedValue;
                string EstadoCivil = ddlEstadoCivil.SelectedValue;
                string CorreoPersonal = txtCorreoPersonal.Text.Trim().ToUpper();
                string CorreoCorporativo = txtCorreoCorporativo.Text.Trim().ToUpper();
                int MunicipioID = Int32.Parse(ddlMunicipio.SelectedValue);

                int SedeID = Int32.Parse(ddlSede.SelectedValue);

                int n = svcEmpleado.ActualizarInformacionUsuario(Int32.Parse(Session["UsuarioID"].ToString()), PrimerNombre, SegundoNombre,
                           PrimerApellido, SegundoApellido, TipoDocumentoID,
                           Documento, CargoID, FechaNacimiento,
                           DireccionResidencia, Barrio, TelefonoFijo,
                           CelularPersonal, CelularCorporativo,
                           CorreoPersonal, CorreoCorporativo,
                           GrupoSanguineo, EstadoCivil, MunicipioID, SedeID);
                
                pnlResultado.Visible = true;

                if (n == 0)
                {
                    lblResultado.Text = "Los datos se actualizaron de manera satisfactoria";
                }
                else 
                {
                    lblResultado.Text = "Hubo un problema al actualizar la información del empleado";
                }

            }
        }

        protected void dgvInformacionFamiliar_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void btnAdicionarIntegrante_Click(object sender, EventArgs e)
        {
            this.ModalPopupExtender1.Show();
        }

        protected void btnGuardarIntegrante_Click(object sender, EventArgs e)
        {
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                Thread.Sleep(2000);
                int EmpleadoID = Int32.Parse(Session["EmpleadoID"].ToString());
                string Nombres = txtNombresIntegrante.Text.Trim().ToUpper();
                string Apellidos = txtApellidosIntegrante.Text.Trim().ToUpper();
                int ParentescoID = Int32.Parse(ddlParentesco.SelectedValue);
                string Ocupacion = txtOcupacionIntegrante.Text.Trim().ToUpper();
                DateTime FechaNacimiento = DateTime.Parse(txtFechaNacimientoIntegrante.Text.Trim());

                int n = svcEmpleado.GuardarInformacionFamiliar(EmpleadoID, Nombres, Apellidos, Ocupacion, FechaNacimiento, ParentescoID);
                CargarGrids();
                
                if (n == 0)
                {
                    //lblResultado.Text = "Los datos se actualizaron de manera satisfactoria";
                }
                else
                {
                    //lblResultado.Text = "Hubo un problema al actualizar la información del empleado";
                }

            }
        }

        public void CargarGrids() {
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                dgvInformacionFamiliar.DataSource = svcEmpleado.ObtenerInformacionFamiliarEmpleadoByUsuarioID(Int32.Parse(Session["UsuarioID"].ToString()));
                dgvInformacionFamiliar.DataBind();

                dgvFormacionAcademica.DataSource = svcEmpleado.ObtenerFormacionAcademicaEmpleadoByUsuarioID(Int32.Parse(Session["UsuarioID"].ToString()));
                dgvFormacionAcademica.DataBind();

                grvExperienciaLaboral.DataSource = svcEmpleado.ObtenerExperienciaLaboralEmpleadoByUsuarioID(Int32.Parse(Session["UsuarioID"].ToString()));
                grvExperienciaLaboral.DataBind();
            }
        }

        protected void btnAdicionarEstudio_Click(object sender, EventArgs e)
        {            
            // Abrimos la Ventana
            this.ModalEstudios.Show();
        }

        protected void ddlPaisInfoAcademica_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Departamentos
                ddlDepartamentoInfoAcademica.DataSource = svc.CargarCatalogoDependienteWCF("Departamentos", ddlPaisInfoAcademica.SelectedValue);
                ddlDepartamentoInfoAcademica.DataTextField = "Etiqueta";
                ddlDepartamentoInfoAcademica.DataValueField = "Id";
                ddlDepartamentoInfoAcademica.DataBind();
                ddlDepartamentoInfoAcademica.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                ddlMunicipioInfoAcademica.Items.Clear();
                ddlMunicipioInfoAcademica.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void ddlDepartamentoInfoAcademica_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Municipios
                ddlMunicipioInfoAcademica.DataSource = svc.CargarCatalogoDependienteWCF("Municipios", ddlDepartamentoInfoAcademica.SelectedValue);
                ddlMunicipioInfoAcademica.DataTextField = "Etiqueta";
                ddlMunicipioInfoAcademica.DataValueField = "Id";
                ddlMunicipioInfoAcademica.DataBind();
                ddlMunicipioInfoAcademica.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void btnGuardarEstudio_Click(object sender, EventArgs e)
        {
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                Thread.Sleep(2000);
                // Obtenemos los valores del formulario
                int EmpleadoID = Int32.Parse(Session["EmpleadoID"].ToString());
                string Institucion = txtInstitucion.Text.Trim().ToUpper();
                string TituloObtenido = txtTituloObtenido.Text.Trim().ToUpper();
                int NivelFormacionID = Int32.Parse(ddlNivelFormacion.SelectedValue);
                int MunicipioID = Int32.Parse(ddlMunicipioInfoAcademica.SelectedValue);
                string Ocupacion = txtOcupacionIntegrante.Text.Trim().ToUpper();
                DateTime FechaInicio = DateTime.Parse(txtFechaInicioEstudio.Text.Trim());
                DateTime FechaFinalizacion = DateTime.Parse(txtFechaFinalizacionEstudio.Text.Trim());
                // Almacenamos los datos
                int n = svcEmpleado.GuardarInformacionAcademica(EmpleadoID, Institucion, TituloObtenido, NivelFormacionID, FechaInicio, FechaFinalizacion, MunicipioID);
                // Volvemos a Bindear las grillas
                CargarGrids();
                // Limpiamos los campos
                txtInstitucion.Text = "";
                txtTituloObtenido.Text = "";
                ddlNivelFormacion.SelectedIndex = 0;
                ddlMunicipioInfoAcademica.SelectedIndex = 0;
                txtOcupacionIntegrante.Text = "";
                txtFechaInicioEstudio.Text = "";
                txtFechaFinalizacionEstudio.Text = "";
                // Ocutamos la ventana
                ModalEstudios.Hide();                
            }
        }

        protected void btnAdicionarExperienciaLaboral_Click(object sender, EventArgs e)
        {
            ModalAdicionarExperienciaLaboral.Show();
        }

        protected void ddlPaisExperienciaLaboral_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Departamentos
                ddlDepartamentoExperienciaLaboral.DataSource = svc.CargarCatalogoDependienteWCF("Departamentos", ddlPaisExperienciaLaboral.SelectedValue);
                ddlDepartamentoExperienciaLaboral.DataTextField = "Etiqueta";
                ddlDepartamentoExperienciaLaboral.DataValueField = "Id";
                ddlDepartamentoExperienciaLaboral.DataBind();
                ddlDepartamentoExperienciaLaboral.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                ddlMunicipioExperienciaLaboral.Items.Clear();
                ddlMunicipioExperienciaLaboral.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void ddlDepartamentoExperienciaLaboral_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Municipios
                ddlMunicipioExperienciaLaboral.DataSource = svc.CargarCatalogoDependienteWCF("Municipios", ddlDepartamentoExperienciaLaboral.SelectedValue);
                ddlMunicipioExperienciaLaboral.DataTextField = "Etiqueta";
                ddlMunicipioExperienciaLaboral.DataValueField = "Id";
                ddlMunicipioExperienciaLaboral.DataBind();
                ddlMunicipioExperienciaLaboral.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void btnGuardarExperienciaLaboral_Click(object sender, EventArgs e)
        {
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                Thread.Sleep(2000);
                // Obtenemos los valores del formulario
                int EmpleadoID = Int32.Parse(Session["EmpleadoID"].ToString());
                string Empresa = txtEmpresa.Text.Trim().ToUpper();
                string Cargo = txtCargo.Text.Trim().ToUpper();
                int SectorID = Int32.Parse(ddlSector.SelectedValue);
                int MunicipioID = Int32.Parse(ddlMunicipioExperienciaLaboral.SelectedValue);
                int AreaTrabajoID = Int32.Parse(ddlAreaTrabajo.SelectedValue);
                string Funciones = txtFunciones.Text.Trim().ToUpper();
                DateTime FechaIngreso = DateTime.Parse(txtFechaIngreso.Text.Trim());
                DateTime FechaRetiro = DateTime.Parse(txtFechaRetiro.Text.Trim());

                int n = svcEmpleado.GuardarExperienciaLaboral(EmpleadoID, Empresa, SectorID, AreaTrabajoID, Cargo, FechaIngreso, FechaRetiro, Funciones, MunicipioID);
                // Volvemos a Bindear las grillas
                CargarGrids();

                ModalAdicionarExperienciaLaboral.Hide();
            }
        }

        protected void btnSybirFotoModal_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Convertir archivo a Binario para Almacenarlo en la base de datos
        /// </summary>
        /// <param name="path">Dirección donde se encuentra el archivo</param>
        /// <returns>Binario del Archivo Convertido</returns>
        byte[] ArchivoBinario(string path)
        {
            byte[] data = null;
            FileInfo info = new FileInfo(path);
            long bytes = info.Length;

            FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)bytes);
            br.Close();
            fStream.Close();

            return data;
        }

        protected void btnSubirFotoModal_Click(object sender, EventArgs e)
        {
            if (fuFotoEmpleado.HasFile)
            {
                int EmpleadoID = Int32.Parse(Session["EmpleadoID"].ToString());
                string filename = Path.GetFileName(fuFotoEmpleado.PostedFile.FileName);
                string contentType = fuFotoEmpleado.PostedFile.ContentType;
                EmpleadoDAL empleado = new EmpleadoDAL();

                using (Stream fs = fuFotoEmpleado.PostedFile.InputStream)
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((Int32)fs.Length);
                        int n = empleado.ActualizarFotoEmpleado(EmpleadoID, bytes);
                    }
                }
            }            
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void SeleccionGrillaInformacionFamiliar(Object sender, GridViewCommandEventArgs e)
        {
            // Obtenemos la fila que se seleccionó
            int Index = Convert.ToInt32(e.CommandArgument);
            int InformacionFamiliarID = Convert.ToInt32(dgvInformacionFamiliar.DataKeys[Index].Values["InformacionFamiliarID"]);
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                int n = svcEmpleado.EliminarInformacionFamiliarEmpleadoByID(InformacionFamiliarID);
                // Volvemos a Bindear las grillas
                CargarGrids();
            }
        }

        protected void SeleccionGrillaFormacionAcademica(Object sender, GridViewCommandEventArgs e)
        {
            // Obtenemos la fila que se seleccionó
            int Index = Convert.ToInt32(e.CommandArgument);
            int FormacionAcademicaID = Convert.ToInt32(dgvFormacionAcademica.DataKeys[Index].Values["FormacionAcademicaID"]);
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                int n = svcEmpleado.EliminarFormacionAcademicaEmpleadoByID(FormacionAcademicaID);
                // Volvemos a Bindear las grillas
                CargarGrids();
            }
        }

        protected void SeleccionGrillaExperienciaLaboral(Object sender, GridViewCommandEventArgs e)
        {
            // Obtenemos la fila que se seleccionó
            int Index = Convert.ToInt32(e.CommandArgument);
            int ExperienciaLaboralID = Convert.ToInt32(grvExperienciaLaboral.DataKeys[Index].Values["ExperienciaLaboralID"]);
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                int n = svcEmpleado.EliminarExperienciaLaboralEmpleadoByID(ExperienciaLaboralID);
                // Volvemos a Bindear las grillas
                CargarGrids();
            }
        }
        protected void ddlPaisSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Departamentos
                ddlDepartamentoSede.DataSource = svc.CargarCatalogoDependienteWCF("DepartamentosSedes", ddlPaisSede.SelectedValue);
                ddlDepartamentoSede.DataTextField = "Etiqueta";
                ddlDepartamentoSede.DataValueField = "Id";
                ddlDepartamentoSede.DataBind();
                ddlDepartamentoSede.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void ddlDepartamentoSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Municipios
                ddlMunicipioSede.DataSource = svc.CargarCatalogoDependienteWCF("MunicipiosSedes", ddlDepartamentoSede.SelectedValue);
                ddlMunicipioSede.DataTextField = "Etiqueta";
                ddlMunicipioSede.DataValueField = "Id";
                ddlMunicipioSede.DataBind();
                ddlMunicipioSede.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void ddlMunicipioSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Municipios
                ddlSede.DataSource = svc.CargarCatalogoDependienteWCF("Sedes", ddlMunicipioSede.SelectedValue);
                ddlSede.DataTextField = "Etiqueta";
                ddlSede.DataValueField = "Id";
                ddlSede.DataBind();
                ddlSede.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }
    }
}
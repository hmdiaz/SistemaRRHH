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
using DAL;
using Tickets.Layouts;

namespace WEB.Pages
{
    
    public partial class DetalleHojaDeVida : PageHelper
    {
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
                    //ddlTipoIdentificacion.DataSource = svc.CargarCatalogoWCF("TipoDocumento");
                    //ddlTipoIdentificacion.DataTextField = "Etiqueta";
                    //ddlTipoIdentificacion.DataValueField = "Id";
                    //ddlTipoIdentificacion.DataBind();
                    //ddlTipoIdentificacion.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
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

                    txtPrimerNombre.Text = empleado.PrimerNombre;
                    txtSegundoNombre.Text = empleado.SegundoNombre;
                    txtPrimerApellido.Text = empleado.PrimerApellido;
                    txtSegundoApellido.Text = empleado.SegundoApellido;
                    int dia = empleado.FechaNacimiento.Day;
                    string NombreMes = DateTimeHelper.CapitalizeFirstLetter(DateTimeHelper.MonthName(empleado.FechaNacimiento.Month));
                    txtFechaNacimiento.Text = (dia + " de " + NombreMes).ToString();
                    txtCorreoCorporativo.Text = empleado.CorreoElectronico;
                    txtCelularCorporativo.Text = empleado.CelularCorporativo;
                    ddlArea.SelectedValue = empleado.AreaID.ToString();
                    ddlCargo.SelectedValue = empleado.CargoID.ToString();

                    byte[] foto = new EmpleadoDAL().ObtenerFotoEmpleado(EmpleadoID);
                    string base64String = Convert.ToBase64String(foto, 0, foto.Length);
                    FotoEmpleado.ImageUrl = "data:image/png;base64," + base64String;

                    lblNumeroEmpleado.Text = "Número de Empleado : " + empleado.NumeroEmpleado;

                    CargarGrids();
                
                    using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
                    {
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
                   
                        ddlArea.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                        ddlCargo.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                    }
                }
            }
        }

        protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient()) 
            {
                //// Cargamos los Departamentos
                //ddlDepartamento.DataSource = svc.CargarCatalogoDependienteWCF("Departamentos", ddlPais.SelectedValue);
                //ddlDepartamento.DataTextField = "Etiqueta";
                //ddlDepartamento.DataValueField = "Id";
                //ddlDepartamento.DataBind();
                //ddlDepartamento.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
            }
        }

        protected void ddlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {
                // Cargamos los Municipios
                //ddlMunicipio.DataSource = svc.CargarCatalogoDependienteWCF("Municipios", ddlDepartamento.SelectedValue);
                //ddlMunicipio.DataTextField = "Etiqueta";
                //ddlMunicipio.DataValueField = "Id";
                //ddlMunicipio.DataBind();
                //ddlMunicipio.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
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

        protected void dgvInformacionFamiliar_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        public void CargarGrids() {
            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
            }
        }
                
        protected void btnSybirFotoModal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
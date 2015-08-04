using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB.EmpleadoService;
using WEB.CatalogoService;
using System.Configuration;
using BAL;
using Tickets.Layouts;
using System.Threading;

namespace WEB.Pages
{
    public partial class ConsultaEmpleadosRRHH : PageHelper
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            Seguridad();
            using (SistemaRRHHServicesClient svc = new SistemaRRHHServicesClient())
            {                
                if (!Page.IsPostBack)
                {
                    // Cargamos las Areas
                    ddlArea.DataSource = svc.CargarCatalogoWCF("Area");
                    ddlArea.DataTextField = "Etiqueta";
                    ddlArea.DataValueField = "Id";
                    ddlArea.DataBind();
                    ddlArea.Items.Insert(0, new ListItem("[Seleccione uno...]", ""));
                }
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

        protected void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            FillGrid(1);
        }

        private void FillGrid(int page)
        {           
            string NombreUsuario = txtLogin.Text.Trim();
            string NumeroEmpleado = txtNumeroEmpleado.Text.Trim();
            string Cedula = txtCedula.Text.Trim();
            string PrimerApellido = txtPrimerApellido.Text.Trim();
            string Nombres = txtNombres.Text.Trim();
            string SegundoApellido = txtSegundoApellido.Text.Trim();
            string AreaID = (ddlArea.SelectedValue == "" || ddlArea.SelectedValue == null) ? "0" : ddlArea.SelectedValue;
            string CargoID = (ddlCargo.SelectedValue == "" || ddlCargo.SelectedValue == null) ? "0" : ddlCargo.SelectedValue;

            using (EmpleadoServiceClient svcEmpleado = new EmpleadoServiceClient())
            {
                try
                {
                    int RegistrosPorPagina = Convert.ToInt32(ConfigurationManager.AppSettings["GridViewsRegistrosPorPagina"]);
                    List<WEB.EmpleadoService.Empleado> items
                        = svcEmpleado.ObtenerEmpleados(page, RegistrosPorPagina, NombreUsuario, NumeroEmpleado, Cedula, PrimerApellido, 
                                                       SegundoApellido, Nombres, Int32.Parse(AreaID), Int32.Parse(CargoID));
                    grvEmpleados.DataSource = items;
                    grvEmpleados.AutoGenerateColumns = false;
                    grvEmpleados.CustomPageIndex = page - 1;
                    grvEmpleados.TotalRecords = 0;
                    grvEmpleados.PageSize = Convert.ToInt32(ConfigurationManager.AppSettings["GridViewsRegistrosPorPagina"]);

                    if (items.Count > 0)
                    {
                        grvEmpleados.TotalRecords = items[0].TotalRegistros;
                    }                    
                    grvEmpleados.DataBind();                    
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Error", string.Format("alert('{0}');",
                        "Ha ocurrido un error inesperado"), true);
                }
            }
        }

        protected void grvEmpleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            FillGrid(e.NewPageIndex + 1);
        }
    }
}
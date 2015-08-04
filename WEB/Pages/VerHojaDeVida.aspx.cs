using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using Tickets.Layouts;
using Helper;
using System.Configuration;

namespace WEB.Pages
{
    public partial class VerHojaDeVida : PageHelper
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Seguridad();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int IdUsuario = Int32.Parse(Request.QueryString["Id"]);
                // Set the processing mode for the ReportViewer to Remote
                rptHojaVida.ProcessingMode = ProcessingMode.Remote;
                rptHojaVida.ShowParameterPrompts = false;

                ServerReport serverReport = rptHojaVida.ServerReport;

                // Set the report server URL and report path
                //serverReport.ReportServerUrl = new Uri("http://10.142.6.57/reportserver");
                serverReport.ReportServerUrl = new Uri(String.Format("{0}/{1}", ConfigurationManager.AppSettings["ReportHost"], 
                                                                                ConfigurationManager.AppSettings["ReportServer"]));
                serverReport.ReportPath = ConfigurationManager.AppSettings["ReportPathCVEmployee"];
                Microsoft.Reporting.WebForms.IReportServerCredentials irsc = new ReportAuthHelper
               (ConfigurationManager.AppSettings["ReportAuthUser"], ConfigurationManager.AppSettings["ReportAuthPwd"], ConfigurationManager.AppSettings["ReportDomain"]);
                rptHojaVida.ServerReport.ReportServerCredentials = irsc;

                // Create the sales order number report parameter
                ReportParameter UsuarioID = new ReportParameter();
                UsuarioID.Name = "pUsuarioID";
                UsuarioID.Values.Add(IdUsuario.ToString());

                // Set the report parameters for the report
                rptHojaVida.ServerReport.SetParameters(new ReportParameter[] { UsuarioID });
            }
        }
    }
}
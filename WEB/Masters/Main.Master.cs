﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB.Masters
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltUsuario.Text = Convert.ToString(Session["Usuario"]);
            ConsultarEmpleados.Visible = Boolean.Parse(Session["ConsultarEmpleados"].ToString());
        }
    }
}
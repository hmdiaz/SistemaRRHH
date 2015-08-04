using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tickets.Layouts;

namespace WEB.Pages
{
    public partial class Main : PageHelper
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Seguridad();
        }
    }
}
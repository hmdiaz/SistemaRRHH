using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;

namespace WEB.Pages
{
    public partial class Logout : System.Web.UI.Page
    {
        Boolean goToMenu = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Cerrando sesión...");

            if (!string.IsNullOrEmpty(Request.QueryString["m"]))
            {
                if (Request.QueryString["m"].Equals("1"))
                {
                    goToMenu = true;
                }
            }

            secureLogOut();
        }

        protected void secureLogOut()
        {            
            //FormsAuthentication.RedirectToLoginPage();
            if (goToMenu)
            {
                Response.Redirect(ConfigurationManager.AppSettings["Menu"]);
            }
            else
            {
                // Generic Logout
                FormsAuthentication.SignOut();
                Response.Cookies.Remove(FormsAuthentication.FormsCookieName);
                Session.Clear();  // This may not be needed -- but can't hurt
                Session.Abandon();

                // Clear authentication cookie
                HttpCookie rFormsCookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
                rFormsCookie.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(rFormsCookie);

                // Clear session cookie 
                HttpCookie rSessionCookie = new HttpCookie("ASP.NET_SessionId", "");
                rSessionCookie.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(rSessionCookie);

                // Invalidate the Cache on the Client Side
                Response.Cache.SetExpires(DateTime.Now.AddYears(-1));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();

                Response.Redirect(ConfigurationManager.AppSettings["Logout"]);
            }

        }
    }
}
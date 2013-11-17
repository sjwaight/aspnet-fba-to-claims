using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobSmithDemoWebApp
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton1.Text = Request.LogonUserIdentity.IsAuthenticated ? "Logout" : "Login";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if(Request.LogonUserIdentity.IsAuthenticated)
            {
                // logging out
                var module = FederatedAuthentication.WSFederationAuthenticationModule;
                module.SignOut(false);
                var request = new SignOutRequestMessage(new Uri(module.Issuer), module.Realm);
                Response.Redirect(request.WriteQueryString());
            }
            Response.Redirect("~/Secured/");
        }
    }
}
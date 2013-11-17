using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobSmithDemoWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Submit1_Click(object sender, EventArgs e)
        {
            if(Membership.ValidateUser(UserEmail.Text, UserPass.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(UserEmail.Text, Persist.Checked);
            }
            else
            {
                Msg.Text = "Invalid credentials. Please try again.";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobSmithDemoWebApp
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MembershipCreateStatus result;

            Membership.CreateUser("bob@smith.com", "smith", "bob@smith.com", "Name of first pet", "Binky", true, out result);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Roles.CreateRole("EndUser");

            Roles.AddUserToRole("bob@smith.com", "EndUser");
        }
    }
}
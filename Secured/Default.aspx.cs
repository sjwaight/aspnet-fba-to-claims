using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BobSmithDemoWebApp.Secured
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("EndUser"))
                Label1.Text = "Is An End User";
        }
    }
}
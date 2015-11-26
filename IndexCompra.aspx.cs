using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona
{
    public partial class IndexCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {
            string script = "var windowRef = window.open('AyudaContras.aspx', null, 'height=500, width = 735, status=yes, resizeable=no, scrollbars= no, toolbar=no, menubar=no');";
                script += "windowRef.focus();";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "123", script, true);
        }

       
    }
}
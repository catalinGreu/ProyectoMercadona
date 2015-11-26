using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona
{
    public partial class RegistroClientes2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("IndexCompra.aspx");
        }

        protected void btnEnviarAlta_Click(object sender, EventArgs e)
        {
            //creat objeto Cliente y mandarlo a grabar al xml
        }
    }
}
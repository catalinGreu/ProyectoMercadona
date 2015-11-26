using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            this.Response.Redirect("NuestraEmpresaMaster.aspx");
        }

        protected void btnCompraOnline_Click(object sender, ImageClickEventArgs e)
        {
            this.Response.Redirect("IndexCompra.aspx");
        }
    }
}
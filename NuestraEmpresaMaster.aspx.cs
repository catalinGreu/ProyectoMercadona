using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona
{
    public partial class NuestraEmpresaMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {

                foreach (string clave in this.Request.Params.Keys)
                {
                    string claveRequest = this.Request.Params[clave];

                    switch (clave)
                    {
                        case "__EVENTTARGET":

                            if (claveRequest.Contains("linkInicio"))
                            {
                                this.Response.Redirect("Inicio.aspx");
                            }
                            else if (claveRequest.Contains("linkDonde"))
                            {
                                this.Response.Redirect("DondeEstamos.aspx");
                            }

                            else if (claveRequest.Contains("linkAtencion"))
                            {
                                this.Response.Redirect("AtencionCliente.aspx");
                            }
                            break;
                        default:
                            break;
                    }
                }

            }
        }

    }
}
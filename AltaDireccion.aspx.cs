using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Modelos;
namespace MerCadona
{
    public partial class AltaDireccion : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( this.IsValid )
            {
                string direccion = this.inputVia.Text +":"+ this.inputNombreVia.Text + ":" + this.inputNum.Text + ":" + this.inputPiso.Text + ":" + this.inputPuerta.Text + ":" + this.inputBloque.Text + ":" + this.inputEscalera.Text + ":" + this.inputLoc.Text;

                this.Session["direccion"] = direccion;
                ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
                
            }
            else
            {
                return;
            }
        }
    }
}
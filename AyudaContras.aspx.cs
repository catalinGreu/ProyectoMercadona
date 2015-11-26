using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;

namespace MerCadona
{
    public partial class AyudaContras : System.Web.UI.Page
    {
        private ControladorEmail controlMail;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.inputDNI.Focus();
            
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            //llamo controlador de Email que manda correo al cliente..
            //comproban que antes exista!!!! Crear XML CLientes.
            
            string to = this.inputMail.Text;

            controlMail = new ControladorEmail(to);
            //se me abre de nuevo la misma ayuda para probar...
           

        }
    }
}
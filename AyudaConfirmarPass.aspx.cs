using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;

namespace MerCadona
{
    public partial class AyudaConfirmarPass : System.Web.UI.Page
    {
        private ControladorFicheros controlFichero;
        private string ruta = "/ficheros/Clientes.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            controlFichero = new ControladorFicheros();
            string email = this.Request.QueryString["email"];
            this.inputEmail.Text = email;

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if ( this.IsValid )
            {
                string mail = this.inputEmail.Text;
                string pass = this.inputPass.Text;
                controlFichero.cambiaPasswdCliente(mail, pass, ruta);
                this.labelInfo.Visible = true;


            }
        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        }
    }
}
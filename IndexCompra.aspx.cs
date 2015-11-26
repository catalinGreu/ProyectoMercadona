using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
namespace MerCadona
{
    public partial class IndexCompra : System.Web.UI.Page
    {
        private ControladorFicheros controlFichero;
        private string ruta = "ficheros/Clientes.xml";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {
            string script = "var windowRef = window.open('AyudaContras.aspx', null, 'height=500, width = 735, status=yes, resizeable=no, scrollbars= no, toolbar=no, menubar=no');";
            script += "windowRef.focus();";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "123", script, true);
        }

        protected void linkRegistro_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("RegistroClientes2.aspx");
        }

        protected void imgButtonLogo_Click(object sender, ImageClickEventArgs e)
        {
            this.Response.Redirect("Inicio.aspx");
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {

                string email = this.inputUsuario.Text;
                string pass = this.inputPass.Text;
                controlFichero = new ControladorFicheros();
                bool exists = controlFichero.existeCliente(email, pass, ruta);

                if (exists)
                {
                    this.Response.Redirect("CompraOnline.aspx?usuario=" + email);//AUN NO HE DECIDIDO EL NOMBRE
                }
            }
            else
            {
                return;
            }
        }
    }
}
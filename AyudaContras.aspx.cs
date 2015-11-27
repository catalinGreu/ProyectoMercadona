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
        private ControladorFicheros controlFichero;
        private string ruta = "/ficheros/Clientes.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            controlFichero = new ControladorFicheros();
            this.inputDNI.Focus();

        }

        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string dni = this.inputDNI.Text;
            string mail = this.inputMail.Text;
            //CREAR XML CLIENTES Y VER SI EXISTIA....
            if (this.IsValid)
            {
                bool existe = controlFichero.compruebaCliente(dni, mail, ruta);

                if (existe)
                {
                    string to = this.inputMail.Text;

                    controlMail = new ControladorEmail(to);
                   
                    this.infoEmail.Visible = true;
                }
            }

            else
            {                
                return;

            }



        }
    }
}
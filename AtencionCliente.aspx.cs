using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
using MerCadona.App_Code.Modelos;

namespace MerCadona
{
    public partial class AtencionCliente : System.Web.UI.Page
    {
        ControladorFicheros __controlFichero = new ControladorFicheros();
        private string ruta = "/ficheros/RECLAMACIONES.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            #region "es Postback"
            if (this.IsPostBack)
            {
                foreach (string clave in this.Request.Params.Keys)
                {
                    string claveRequest = this.Request.Params[clave];
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
                }
            }
            #endregion
            this.inputMensaje.Focus();
            //si no es valida la pagina no hace postback el cabron
        }

        protected void buttonEnviar_Click(object sender, EventArgs e)
        {

            if (this.IsValid)
            {
                Reclamacion r = new Reclamacion();
                r.Asunto = this.radioList.SelectedValue;
                r.Mensaje = this.inputMensaje.Text;
                r.Nombre = this.inputNombre.Text;
                r.Apellido = this.inputApe1.Text;
                r.DNI = this.inputDNI.Text;
                r.Provincia = this.inputProvincia.Text;
                r.Localidad = this.inputLoc.Text;
                r.Telefono = this.inputTlf.Text;
                r.Email = this.inputMail.Text;
                //si es valida creo objeto Reclamacion y lo mando a controlFIchero
                //para guardarlo en el fichero
                __controlFichero.grabaReclamacion(r, ruta);

                this.inputMensaje.Text = "Mensaje enviado con éxito";
            }
            else
            {
                return;
            }

        }

    }
}
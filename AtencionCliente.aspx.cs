using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;

namespace MerCadona
{
    public partial class AtencionCliente : System.Web.UI.Page
    {
        ControladorFicheros __controlFichero = new ControladorFicheros();
        private string ruta = "/ficheros/RECLAMACIONES.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            RequiredFieldValidator req = new RequiredFieldValidator();
            req.ControlToValidate = this.inputMensaje.ID;
            req.ErrorMessage = "Campo incompleto";

        }

        protected void buttonEnviar_Click(object sender, EventArgs e)
        {
            __controlFichero.grabaReclamacion(this.inputNombre.Text, this.inputDNI.Text, ruta);
            //comprobar que radio button esta apretado
        }
    }
}
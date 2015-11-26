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
    public partial class CompraOnline : System.Web.UI.Page
    {
        private ControladorFicheros controlFichero;
        private Cliente cliente;
        private string rutaXML = "ficheros/Clientes.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            //instanciar controles de la MASTER!!!!----> leo categorias y subcategorias

            string email = this.Request.QueryString["usuario"];
            controlFichero = new ControladorFicheros();
            cliente = controlFichero.getCliente(email, rutaXML);

        }
    }
}
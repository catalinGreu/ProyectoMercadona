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
    public partial class Formalizar : System.Web.UI.Page
    {
        private ControladorFicheros controlFichero;
        private ControladorEmail controlEmail;
        private string ruta = "ficheros/Clientes.xml";
        string total;
        string email;
        Cliente c;
        protected void Page_Load(object sender, EventArgs e)
        {
            controlFichero = new ControladorFicheros();
            total = this.Request.QueryString["total"];
            email = this.Request.QueryString["cliente"];

            c = controlFichero.getCliente(email, ruta);

            this.lblPrecioTotal.Text = total;
            this.lblDireccion.Text = c.Direccion;
            this.lblCliente.Text = c.Nombre;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                controlEmail = new ControladorEmail();
                controlEmail.sendFactura(c, total, this.inputCuenta.Text);

                this.Response.Redirect("Inicio.aspx");

            }
            else
            {
                return;
            }
        }
    }
}
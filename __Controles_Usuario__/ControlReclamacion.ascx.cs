using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona.__Controles_Usuario__
{
    public partial class ControlReclamacion : System.Web.UI.UserControl
    {
        private string asunto;
        private string mensaje;
        private string nombre;
        private string email;
        private string boton;
        //boton se mapea contra email.

        public string Asunto
        {
            get { return this.asunto; }
            set
            {
                this.asunto = value;
                this.txtAsunto.Text = this.asunto;
            }
        }
        public string Mensaje
        {
            get { return this.mensaje; }
            set
            {
                this.mensaje = value;
                this.txtMensaje.Text = this.mensaje;
            }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                this.nombre = value;
                this.lblNombre.Text = this.nombre;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;
                this.lblEmail.Text = this.email;
            }
        }
        public string Boton
        {
            get { return this.boton; }
            set { this.boton = value;
                this.botonBorrar.ID = this.boton;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
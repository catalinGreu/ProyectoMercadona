using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona.__Controles_Usuario__
{
    public partial class ControlSupermercado : System.Web.UI.UserControl
    {
        private string calle;
        private string codigoPostal;
        private string telefono;
        private string horario;
        private string parking;

        #region "___getters y setters___"

        public string Calle
        {
            get { return this.calle; }
            set
            {
                this.calle = value;
                this.labelDir.Text = this.calle;
            }
        }
        public string CodigoPostal
        {
            get { return this.codigoPostal; }
            set
            {
                this.codigoPostal = value;
                this.labelCP.Text = this.codigoPostal;
            }
        }
        public string Telefono
        {
            get { return this.telefono; }
            set
            {
                this.telefono = value;
                this.labelTlf.Text = this.telefono;
            }
        }
        public string Horario
        {
            get { return this.horario; }
            set
            {
                this.horario = value;
                this.labelHorario.Text = this.horario;
            }
        }
        public string Parking
        {
            get { return this.parking; }
            set { this.parking = value; }
            //si el parking es false, imagen no visible
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.parking != "si")
            {
                this.Image1.Visible = false;
            }
        }
    }
}
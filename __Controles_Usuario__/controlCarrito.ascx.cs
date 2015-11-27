using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona.__Controles_Usuario__
{
    public partial class controlCarrito : System.Web.UI.UserControl
    {
        private decimal total;
        private decimal ivaSobreTotal;
        private const decimal precioEnvio = 7.21M;

        public decimal Total
        {
            get { return this.total; }
            set { this.total = value + precioEnvio;
                this.LblTotal.Text = this.total.ToString();
            }
        }

        public decimal IVA
        {
            get { return this.ivaSobreTotal; }
            set { this.ivaSobreTotal = value;
                this.LblIVA.Text = this.ivaSobreTotal.ToString(); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TablaMiniProductos = new Table();
        }
    }
}
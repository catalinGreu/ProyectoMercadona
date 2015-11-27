using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona.__Controles_Usuario__
{
    public partial class controlListaMiniProducto : System.Web.UI.UserControl
    {
        private string prod;
        private decimal precio;
        private int cant;
        public string Producto
        {
            get { return this.prod; }
            set { this.prod = value;
                this.LblMiniProducto.Text = this.prod;
            }
        }
        public decimal Precio
        {
            get { return this.precio; }
            set { this.precio = value;
                this.LblPrecio.Text = this.precio.ToString();
            }
        }
        public int Cantidad
        {
            get { return this.cant; }
            set { this.cant = value;
                this.LblCantidadMiniProd.Text = this.cant.ToString();
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
    }
}
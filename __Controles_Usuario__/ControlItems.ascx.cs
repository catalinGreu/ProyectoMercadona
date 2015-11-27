using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona.__Controles_Usuario__
{
    public partial class ControlItems : System.Web.UI.UserControl
    {
        public string producto;
        public decimal precio;
        public int cantidadProducto;
        public string boton;

        public string Boton
        {
            get { return this.boton; }
            set { this.boton = value;
                this.btnAddToCart.ID = this.boton;
            }
        }

        public string Descripcion
        {
            get { return this.producto; }
            set
            {
                this.producto = value;
                this.lblDescripcion.Text = this.producto;
            }
        }

        public decimal Precio
        {
            get { return this.precio; }
            set
            {
                this.precio = value;
                this.lblPrecio.Text = this.precio.ToString();
            }
        }
        public void sumaItem()
        {
            this.cantidadProducto += 1;
            this.LblCantidadMiniProd.Text = this.cantidadProducto.ToString();
            decimal precioNuevo = this.precio * this.cantidadProducto;
            this.lblPrecio.Text = precioNuevo.ToString();

        }
        public void restaItem()
        {
            if (this.LblCantidadMiniProd.Text == "1")
            {//no puedo restar mas...
                this.LblCantidadMiniProd.Text = "1";
            }
            else
            {
                this.cantidadProducto--;
                this.LblCantidadMiniProd.Text = this.cantidadProducto.ToString();
                decimal precioNuevo = this.precio * this.cantidadProducto;
                this.lblPrecio.Text = precioNuevo.ToString();//a ver si chuta
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerCadona.App_Code.Modelos
{
    public class Producto
    {
        public string descripcion;
        public decimal precio;
        public string seccion;
        public string subseccion;
        public Producto() { }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }
        public decimal Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public string Seccion
        {
            get { return this.seccion; }
            set { this.seccion = value; }
        }
        public string Subseccion
        {
            get { return this.subseccion; }
            set { this.subseccion = value; }
        }

    }
}
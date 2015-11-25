using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerCadona.App_Code.Modelos
{
    public class Empleado
    {
        private string nombre;
        private string departamento;
        private string puesto;
        public Empleado() { }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Depart
        {
            get { return this.departamento; }
            set { this.departamento = value; }
        }
        public string Puesto
        {
            get { return this.puesto; }
            set { this.puesto = value; }
        }
    }
}
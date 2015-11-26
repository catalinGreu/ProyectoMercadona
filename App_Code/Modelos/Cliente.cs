using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerCadona.App_Code.Modelos
{
    public class Cliente
    {
        public Cliente() { }

        #region "atributos"
        private string nombre;
        private string apellido;
        private string dni;
        private string email;
        private string passwd;
        private string direccion; //formada por campo Calle, nº, loc...etc
        private string tlf;
        #endregion

        #region "Getters & Setters"

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.passwd; }
            set { this.passwd = value; }
        }
        public string Telefono
        {
            get { return this.tlf; }
            set { this.tlf = value; }

        }
        #endregion
    }
}
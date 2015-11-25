using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerCadona.App_Code.Modelos
{
    public class Reclamacion
    {
        #region "atributos"
        private string asunto;
        private string mensaje;
        private string nombre;
        private string apellido;
        private string dni;
        private string provincia;
        private string loc;
        private string tlf;
        private string mail;
        #endregion
        public Reclamacion(){ }

        #region "getters & setters"

        public string Asunto
        {
            get { return this.asunto; }
            set { this.asunto = value; }
        }
        public string Mensaje
        {
            get { return this.mensaje; }
            set { this.mensaje = value; }
        }
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
        public string Provincia
        {
            get { return this.provincia; }
            set { this.provincia = value; }
        }
        public string Localidad
        {
            get { return this.loc; }
            set { this.loc = value; }
        }
        public string Telefono
        {
            get { return this.tlf; }
            set { this.tlf = value; }
        }
        public string Email
        {
            get { return this.mail; }
            set { this.mail = value; }
        }

        #endregion  

    }
}
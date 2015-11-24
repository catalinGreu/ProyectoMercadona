using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MerCadona.App_Code.Modelos
{
    public class Supermercado
    {
        #region "____Atributos de clase___"
        private string localidad;
        private string calle;
        private short codPostal;
        private int telefono;
        private string horario;
        private bool parking;
        #endregion

        public Supermercado(){}
        public Supermercado(string loc, string calle, short cp, int tlf, string hora, bool parking)
        {
            this.Localidad = loc;
            this.Calle = calle;
            this.CP = cp;
            this.Telefono = tlf;
            this.Horario = hora;
            this.Parking = parking;
            
        }

        #region "____Getters & Setters____"

        public string Localidad
        {
            get { return this.localidad; }
            set { this.localidad = value; }
        }

        public string Calle
        {
            get { return this.calle; }
            set { this.calle = value; }
        }
        public short CP
        {
            get { return this.codPostal; }
            set { this.codPostal = value; }
        }
        public int Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }
        public string Horario
        {
            get { return this.horario; }
            set { this.horario = value; }
        }
        public bool Parking
        {
            get { return this.parking; }
            set { this.parking = value; }
        }

        #endregion

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Web;
using System.IO;
using MerCadona.App_Code.Modelos;
namespace MerCadona.App_Code.Controladores
{
    public class ControladorFicheros
    {
        private StreamReader fichero;
        private StreamWriter writer;
        public string[] getProvincias(string ruta)
        {

            fichero = new StreamReader(HttpContext.Current.Request.MapPath(ruta));

            return (from linea in fichero.ReadToEnd().Split(new char[] { '\r', '\n' }).Where(linea => !new System.Text.RegularExpressions.Regex("^$").Match(linea).Success)
                    let campoProvincia = linea.Split(new char[] { ';' })[1]
                    select campoProvincia).ToArray();

        }


        // Leo from XML
        public List<Supermercado> getSuperFromXML(string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            return (from nodo in root.Descendants("Supermercado")
                    let loc = nodo.Parent.Attribute("Nombre").Value
                    let dir = nodo.Element("Direccion").Value
                    let cp = nodo.Element("CP").Value
                    let hora = nodo.Element("Horario").Value
                    let tlf = nodo.Element("Telefono").Value
                    let parking = nodo.Element("Parking").Value
                    select new Supermercado
                    {
                        Localidad = loc,
                        Calle = dir,
                        CP = cp,
                        Horario = hora,
                        Telefono = tlf,
                        Parking = parking

                    }).ToList<Supermercado>();

        }

        public List<Supermercado> getSuperLoc(string ruta, string localidad)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            return (from nodo in root.Descendants("Supermercado")
                    where (string)nodo.Parent.Attribute("Nombre").Value == localidad
                    let loc = nodo.Parent.Attribute("Nombre").Value
                    let dir = nodo.Element("Direccion").Value
                    let cp = nodo.Element("CP").Value
                    let hora = nodo.Element("Horario").Value
                    let tlf = nodo.Element("Telefono").Value
                    let parking = nodo.Element("Parking").Value
                    select new Supermercado
                    {
                        Localidad = loc,
                        Calle = dir,
                        CP = cp,
                        Horario = hora,
                        Telefono = tlf,
                        Parking = parking
                    }
           ).ToList<Supermercado>();

        }
        public List<Supermercado> getSuperLocYHora(string ruta, string localidad, string hora)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));
            return (from nodo in root.Descendants("Supermercado")
                    where (string)nodo.Parent.Attribute("Nombre").Value == localidad
                    where (string)nodo.Element("Horario").Value == hora

                    let loc = nodo.Parent.Attribute("Nombre").Value
                    let dir = nodo.Element("Direccion").Value
                    let cp = nodo.Element("CP").Value
                    let horario = nodo.Element("Horario").Value
                    let tlf = nodo.Element("Telefono").Value
                    let parking = nodo.Element("Parking").Value
                    select new Supermercado
                    {
                        Localidad = loc,
                        Calle = dir,
                        CP = cp,
                        Horario = horario,
                        Telefono = tlf,
                        Parking = parking
                    }).ToList<Supermercado>();
        }
        public string[] getLocalidades(string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));
            return (from nodo in root.Descendants("Localidad")
                    let loc = nodo.Attribute("Nombre").Value
                    select loc).ToArray<string>();
        }

        // grabo datos en fichero
        public bool grabaReclamacion( Reclamacion r, string ruta )
        {
            string cadena = r.Asunto + ":" + r.Mensaje + ":" + r.Nombre + ":" + r.Apellido + ":" + r.DNI + ":"
                            + r.Provincia + ":" + r.Localidad + ":" + r.Telefono + ":" + r.Email;

            try
            {
                writer = new StreamWriter(HttpContext.Current.Request.MapPath(ruta), true);
                writer.WriteLine(cadena);
                writer.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //Compruebo existencia del empleado
        public bool compruebEmpleado(string nif, string depart, string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            bool resultado = (from nodo in root.Descendants("empleado")
                              let campoNIF = nodo.Element("nif").Value
                              let campoDepart = nodo.Element("departamento").Value
                              where campoNIF == nif && campoDepart == depart
                              select true).SingleOrDefault();
            return resultado;
        }

        //Recupero reclamaciones
        public List<Reclamacion> getReclamaciones(string ruta)
        {
            fichero = new StreamReader(HttpContext.Current.Request.MapPath(ruta));
            return (from linea in fichero.ReadToEnd().Split(new char[] { '\r', '\n' }).Where(linea => !new System.Text.RegularExpressions.Regex("^$").Match(linea).Success)
                    select new Reclamacion
                    {
                        Asunto = linea.Split(new char[] { ':' })[0],
                        Mensaje = linea.Split(new char[] { ':' })[1],
                        Nombre = linea.Split(new char[] { ':' })[2],
                        Email = linea.Split(new char[] { ':' })[8]

                    }).ToList<Reclamacion>();

        }
    }
}
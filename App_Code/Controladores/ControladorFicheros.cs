﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Web;
using System.IO;
using MerCadona.App_Code.Modelos;
namespace MerCadona.App_Code.Controladores
{
    public class ControladorFicheros
    {
        private StreamReader fichero;
        
        public string[] getProvincias(string ruta)
        {

            fichero = new StreamReader(HttpContext.Current.Request.MapPath(ruta));

            return (from linea in fichero.ReadToEnd().Split(new char[] { '\r', '\n' }).Where(linea => !new System.Text.RegularExpressions.Regex("^$").Match(linea).Success)
                    let campoProvincia = linea.Split(new char[] { ';' })[1]
                    select campoProvincia).ToArray();

        }//--->provincias.csv

        
        // FICHERO Supermercados.xml
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


        //FICHERO RECLAMACIONES.xml
        public bool grabaReclamacion( Reclamacion r, string ruta )
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(HttpContext.Current.Request.MapPath(ruta));

            XmlElement reclamacion = doc.CreateElement("reclamacion");

            XmlNode asunto = doc.CreateNode("element", "asunto", "");
            asunto.InnerText = r.Asunto;

            XmlNode mensaje = doc.CreateNode("element", "mensaje", "");
            mensaje.InnerText = r.Mensaje;

            XmlNode nombre = doc.CreateNode("element", "nombre", "");
            nombre.InnerText = r.Nombre;

            XmlNode email = doc.CreateNode("element", "email", "");
            email.InnerText = r.Email;

            reclamacion.AppendChild(asunto);
            reclamacion.AppendChild(mensaje);
            reclamacion.AppendChild(nombre);
            reclamacion.AppendChild(email);

            XmlElement root = doc.DocumentElement;
            root.AppendChild(reclamacion);

            doc.Save(HttpContext.Current.Request.MapPath(ruta));

            return true;
        }
        public List<Reclamacion> getReclamaciones(string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            return (from nodo in root.Descendants("reclamacion")
                    select new Reclamacion
                    {
                        Asunto = nodo.Element("asunto").Value,
                        Mensaje = nodo.Element("mensaje").Value,
                        Nombre = nodo.Element("nombre").Value,
                        Email = nodo.Element("email").Value
                    }).ToList<Reclamacion>();


        }
        public void borraNodo(string email, string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            (from nodo in root.Descendants("reclamacion")
             where nodo.Element("email").Value == email
             select nodo).Remove();

            root.Save(HttpContext.Current.Request.MapPath(ruta));

        }

        //FICHERO Clientes.xml
        public bool compruebaCliente(string dni, string mail, string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            bool resultado = (from nodo in root.Descendants("cliente")
                              let campoDNI = nodo.Element("dni").Value
                              let campoEmail = nodo.Element("email").Value
                              where campoDNI == dni && campoEmail == mail
                              select true).SingleOrDefault();
            return resultado;
        }
        public void cambiaPasswdCliente(string mail, string pass, string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            (from nodo in root.Descendants("cliente")
             where nodo.Element("email").Value == mail
             select (nodo.Element("password").Value = pass)).Single();
            root.Save(HttpContext.Current.Request.MapPath(ruta));

        }
        public bool existeCliente(string email, string pass, string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            bool resultado = (from nodo in root.Descendants("cliente")
                              let campoPass = nodo.Element("password").Value
                              let campoEmail = nodo.Element("email").Value
                              where campoPass == pass && campoEmail == email
                              select true).SingleOrDefault();
            return resultado;

        }
        public void addCliente(Cliente c, string ruta)
        {
            
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





    }
}
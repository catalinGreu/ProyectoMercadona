using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Web;
using System.IO;
using MerCadona.App_Code.Modelos;
using System.Web.UI.WebControls;

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
        public bool grabaReclamacion(Reclamacion r, string ruta)
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
            XmlDocument doc = new XmlDocument();
            doc.Load(HttpContext.Current.Request.MapPath(ruta));

            XmlElement cliente = doc.CreateElement("cliente");


            XmlNode nombre = doc.CreateNode("element", "nombre", "");
            XmlNode apellido = doc.CreateNode("element", "apellido", "");
            XmlNode dni = doc.CreateNode("element", "dni", "");
            XmlNode email = doc.CreateNode("element", "email", "");
            XmlNode password = doc.CreateNode("element", "password", "");
            XmlNode direccion = doc.CreateNode("element", "direccion", "");
            XmlNode telefono = doc.CreateNode("element", "telefono", "");
            XmlNode fecha = doc.CreateNode("element", "fecha", "");

            nombre.InnerText = c.Nombre;
            apellido.InnerText = c.Apellido;
            dni.InnerText = c.DNI;
            email.InnerText = c.Email;
            password.InnerText = c.Password;
            direccion.InnerText = c.Direccion;
            telefono.InnerText = c.Telefono;
            fecha.InnerText = c.FechaNacimiento;

            cliente.AppendChild(nombre);
            cliente.AppendChild(apellido);
            cliente.AppendChild(dni);
            cliente.AppendChild(email);
            cliente.AppendChild(password);
            cliente.AppendChild(direccion);
            cliente.AppendChild(telefono);
            cliente.AppendChild(fecha);

            XmlElement root = doc.DocumentElement;
            root.AppendChild(cliente);

            doc.Save(HttpContext.Current.Request.MapPath(ruta));


        }
        public Cliente getCliente(string email, string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));
            return (from nodo in root.Descendants("cliente")
                    where nodo.Element("email").Value == email
                    select new Cliente
                    {
                        Nombre = nodo.Element("nombre").Value,
                        Apellido = nodo.Element("apellido").Value,
                        DNI = nodo.Element("dni").Value,
                        Email = nodo.Element("email").Value,
                        Password = nodo.Element("password").Value,
                        Direccion = nodo.Element("direccion").Value,
                        Telefono = nodo.Element("telefono").Value,
                        FechaNacimiento = nodo.Element("fecha").Value
                    }).Single();

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

        
        public List<Producto> getProductoSubseccion(string subseccion, string ruta)
        {
            XElement root = XElement.Load(HttpContext.Current.Request.MapPath(ruta));

            return (from nodo in root.Descendants("Producto")
                    where nodo.Parent.Attribute("Nombre").Value == subseccion
                    select new Producto
                    {
                        Descripcion = nodo.Value,
                        Precio = Convert.ToDecimal(nodo.Attribute("Precio").Value),
                        Seccion = nodo.Parent.Parent.Attribute("Nombre").Value,
                        Subseccion = nodo.Parent.Attribute("Nombre").Value
                    }).ToList<Producto>();/* He comentado el XML porq no sabia como
                                            decirle que solo coja 4 en una consulta Linq...*/
        }

    }
}
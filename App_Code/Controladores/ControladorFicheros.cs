using System;
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
        public string[] getProvincias(string ruta)
        {

            fichero = new StreamReader(HttpContext.Current.Request.MapPath(ruta));

            return (from linea in fichero.ReadToEnd().Split(new char[] { '\r', '\n' }).Where(linea => !new System.Text.RegularExpressions.Regex("^$").Match(linea).Success)
                    let campoProvincia = linea.Split(new char[] { ';' })[1]
                    select campoProvincia).ToArray();

        }

        public List<Supermercado> getSuperFromXML(string ruta)
        {
            XElement root = XElement.Load(@"fichero/Supermercados.xml");

            return (from nodo in root.Elements("Localidad")

                    let nombreLoc = nodo.Attributes("Nombre")
                    let calle = nodo.Element("Supermercado").
                    //let cp = ....a ver si va;
            select new Supermercado()
            {
                Localidad = nombreLoc,
            }
                    ).List<Supermercado>;

        }
    }
}
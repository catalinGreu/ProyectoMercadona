using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
using MerCadona.App_Code.Modelos;
using MerCadona.__Controles_Usuario__;
using System.Xml;
using System.Xml.Linq;
namespace MerCadona
{
    public partial class CompraOnline : System.Web.UI.Page
    {
        private ControladorFicheros controlFichero;
        private Cliente cliente;
        private string rutaXML = "ficheros/Clientes.xml";
        private string rutaControlCarrito = "~__Controles_Usuario__/controlCarrito.ascx";
        private string rutaControlProducto = "~__Controles_Usuario__/controlCarrito.ascx";
        private string rutaSecciones = "ficheros/SECCIONES_SUBSECCIONES.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            //instanciar controles de la MASTER!!!!----> leo categorias y subcategorias
            TreeView tree = (TreeView)this.Master.FindControl("TreeView1");
            if (!this.IsPostBack)
            {
                string email = this.Request.QueryString["usuario"];
                controlFichero = new ControladorFicheros();
                cliente = controlFichero.getCliente(email, rutaXML);

                //ahora tengo que cargar los nodos desde el XML

                int contador = 0;
                //XElement root = controlFichero.getSecciones(rutaSecciones);

                XElement root = XElement.Load(HttpContext.Current.Request.MapPath(rutaSecciones));
                foreach (XElement seccion in root.Descendants("Seccion") )
                {
                    TreeNode parentSecc = new TreeNode();
                    parentSecc.Text = seccion.Attribute("Nombre").Value;
                    tree.Nodes.Add(parentSecc);

                    foreach ( XElement subseccion in seccion.Descendants("SubSeccion") )
                    {
                        TreeNode childSubsecc = new TreeNode();
                        childSubsecc.Text = subseccion.Attribute("Nombre").Value;
                        parentSecc.ChildNodes.Add(childSubsecc);

                        foreach (XElement producto in subseccion.Descendants("Producto") )
                        {
                            TreeNode childProd = new TreeNode();
                            childProd.Text = producto.Value + producto.Attribute("Precio");
                            childSubsecc.ChildNodes.Add(childProd);
                            ++contador;
                            if ( contador == 4 )
                            {
                                contador = 0;
                                break;
                            }

                        }

                    }
                    

                }
                //secciones.Nodes.Add(controlFichero.getSecciones(rutaSecciones));
            
            }

        }
    }
}
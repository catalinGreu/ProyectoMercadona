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
using System.Drawing;

namespace MerCadona
{
    public partial class CompraOnline : System.Web.UI.Page
    {
        private ControladorFicheros controlFichero;
        private Cliente cliente;
        private string rutaXML = "ficheros/Clientes.xml";
        private string rutaControlCarrito = "~/__Controles_Usuario__/controlCarrito.ascx";
        private string rutaControlProducto = "~/__Controles_Usuario__/controlListaMiniProducto.ascx";
        private string rutaSecciones = "ficheros/SECCIONES_SUBSECCIONES.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            //instanciar controles de la MASTER!!!!----> leo categorias y subcategorias
            TreeView tree = (TreeView)this.Master.FindControl("TreeView1");
            Label lblDireccion = (Label)this.Master.FindControl("LabelDireccion");
            controlFichero = new ControladorFicheros();
            if (!this.IsPostBack)
            {
                string email = this.Request.QueryString["usuario"];
                cliente = controlFichero.getCliente(email, rutaXML);
                lblDireccion.Text = "Usuario: " + cliente.Nombre + ". Direccion: " + cliente.Direccion;

                //ahora tengo que cargar los nodos desde el XML

                //int contador = 0;
                //XElement root = controlFichero.getSecciones(rutaSecciones);

                #region "cargo tree a mano"
                XElement root = XElement.Load(HttpContext.Current.Request.MapPath(rutaSecciones));
                foreach (XElement seccion in root.Descendants("Seccion"))
                {
                    TreeNode parentSecc = new TreeNode();
                    parentSecc.Text = seccion.Attribute("Nombre").Value;
                    tree.Nodes.Add(parentSecc);

                    foreach (XElement subseccion in seccion.Descendants("SubSeccion"))
                    {
                        TreeNode childSubsecc = new TreeNode();
                        childSubsecc.Text = subseccion.Attribute("Nombre").Value;
                        parentSecc.ChildNodes.Add(childSubsecc);

                        foreach (XElement producto in subseccion.Descendants("Producto"))
                        {
                            TreeNode childProd = new TreeNode();
                            childProd.Text = producto.Value + producto.Attribute("Precio");
                            childSubsecc.ChildNodes.Add(childProd);
                            //++contador;
                            //if ( contador == 4 )
                            //{
                            //    contador = 0;
                            //    break;
                            //}
                            //CUTRE Q TE CAGAAAAS!!
                        }

                    }


                }
                #endregion
                //secciones.Nodes.Add(controlFichero.getSecciones(rutaSecciones));

            }
            else if (this.IsPostBack)
            {
                mostrar();
                foreach (string clave in this.Request.Params.AllKeys)
                {
                    string claveRequest = this.Request.Params[clave];
                    switch (clave)
                    {
                        case "__EVENTTARGET":
                            string nodo = this.Request.Params["__EVENTARGUMENT"];
                            if (claveRequest.Contains(tree.ID))
                            {
                                if ( nodo.Contains("Fruta") || nodo.Contains("Verduras") || nodo.Contains("Lacteos"))
                                {
                                    
                                }
                                char[] separador = new char[] { '\\' };
                                string subseccion = this.Request.Params["__EVENTARGUMENT"].ToString().Split(separador)[1];

                                List<Producto> lista = controlFichero.getProductoSubseccion(subseccion, rutaSecciones);
                                rellenaTablaConProductos(lista);
                            }
                            break;
                        default:
                            break;
                    }
                }
                //compruebo que subcategoria se pulsa
                //y cargo controles usuario producto
                //instancio objeto Producto...



            }
        }
        public void rellenaTablaConProductos(List<Producto> lista)
        {
            TableRow row = new TableRow();
            row.BackColor = Color.LightSalmon;
            TableCell cell = new TableCell();
            Label l = new Label();
            l.Font.Bold = true;
            l.Text = lista[0].Subseccion; ;
            cell.Controls.Add(l);
            row.Cells.Add(cell);
            this.tablaProductos.Rows.Add(row);

            foreach ( Producto p in lista )
            {
                controlListaMiniProducto micontrol = (controlListaMiniProducto)Page.LoadControl(rutaControlProducto);
                micontrol.Producto = p.Descripcion;
                micontrol.Precio = p.Precio;
                //quiza haya que mapear algo....
                TableRow row2 = new TableRow();
                
                TableCell cell2 = new TableCell();
                Label cat = new Label();
                cat.Text = p.Subseccion;
                cat.Font.Bold = true;               
                cell.Controls.Add(micontrol);
                row.Cells.Add(cell2);
                this.tablaProductos.Rows.Add(row2);
            }
        }
        private void mostrar()
        {
            string mensaje = "";
            foreach (string clave in this.Request.Params.Keys)
            {
                mensaje += "clave:_" + clave + " -------valor:_" +
                    this.Request.Params[clave].ToString() + "\n";
            }
            this.TextBox1.Text = mensaje;
        }
    }
}
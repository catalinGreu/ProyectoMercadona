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
        private string rutaControlItems = "~/__Controles_Usuario__/ControlItems.ascx";
        private string rutaSecciones = "ficheros/SECCIONES_SUBSECCIONES.xml";
        List<Producto> lista;
        Table tablaDeCarrito;
        protected void Page_Load(object sender, EventArgs e)
        {
            TreeView tree = (TreeView)this.Master.FindControl("TreeView1");
            Label lblDireccion = (Label)this.Master.FindControl("LabelDireccion");

            controlFichero = new ControladorFicheros();

            cargaControlCarrito();
            if (!this.IsPostBack)
            {
                string email = this.Request.QueryString["usuario"];
                cliente = controlFichero.getCliente(email, rutaXML);
                lblDireccion.Text = "Usuario: " + cliente.Nombre + ". Direccion: " + cliente.Direccion;


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

            }
            else if (this.IsPostBack)
            {
                mostrar();
                foreach (string clave in this.Request.Params.AllKeys)
                {
                    string subseccion;
                    string claveRequest = this.Request.Params[clave];
                    switch (clave)
                    {
                        case "__EVENTTARGET":

                            if (claveRequest.Contains(tree.ID))
                            {
                                char[] separador = new char[] { '\\' };

                                try
                                {
                                    subseccion = this.Request.Params["__EVENTARGUMENT"].ToString().Split(separador)[1];
                                    Session["subActual"] = subseccion;
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    return;
                                }

                                lista = controlFichero.getProductoSubseccion(subseccion, rutaSecciones);
                                rellenaTablaConProductos(lista);
                            }
                            break;
                        default:
                            break;

                    }

                    if (claveRequest.Equals("Añadir"))
                    {
                        string descripcion = clave.Split(new char[] { '$' })[3];
                        string sub = (string)Session["subActual"];
                        lista = controlFichero.getProductoSubseccion(sub, rutaSecciones);
                        Producto p = (from prod in lista
                                      where prod.Descripcion == descripcion
                                      select prod).Single();
                        controlListaMiniProducto minicontrol = (controlListaMiniProducto)Page.LoadControl(rutaControlProducto);
                        minicontrol.Producto = p.Descripcion;
                        minicontrol.Precio = p.Precio;
                        
                        addToCarrito(minicontrol, tablaDeCarrito);
                        rellenaTablaConProductos(lista);
                    }


                }
            }
        }
        public void rellenaTablaConProductos(List<Producto> lista)
        {
            TableRow row = new TableRow();
            row.BackColor = Color.LightSalmon;
            TableCell cell = new TableCell();
            Label l = new Label();
            l.Font.Bold = true;
            l.Text = lista[0].Subseccion + ".";
            l.Text += "\n" + lista.Count + "  Productos encontrados";
            cell.Controls.Add(l);
            row.Cells.Add(cell);
            this.tablaProductos.Rows.Add(row);

            foreach (Producto p in lista)
            {
                ControlItems micontrol = (ControlItems)Page.LoadControl(rutaControlItems);
                micontrol.Descripcion = p.Descripcion;
                micontrol.Precio = p.Precio;
                micontrol.Boton = p.Descripcion;
                //quiza haya que mapear algo....
                TableRow row2 = new TableRow();
                TableCell cell2 = new TableCell();

                cell.Controls.Add(micontrol);
                row.Cells.Add(cell2);
                this.tablaProductos.Rows.Add(row2);
            }
        }

        public void cargaControlCarrito()
        {
            Table tablaCarro = (Table)this.Master.FindControl("tablaCarrito");
            //si no hay postback cargo la Cesta
            controlCarrito control = (controlCarrito)Page.LoadControl(rutaControlCarrito);
            tablaDeCarrito = (Table)control.FindControl("TablaMiniProductos");
            TableRow row3 = new TableRow();
            TableCell cell3 = new TableCell();

            cell3.Controls.Add(control);
            row3.Cells.Add(cell3);
            tablaCarro.Rows.Add(row3);//si añaden un producto a la cesta...find control de la tabla de la cesta
                                      //para añadirle items
        }

        public void addToCarrito(controlListaMiniProducto uncontrol, Table tablaDeCarrito)
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            cell.Controls.Add(uncontrol);
            row.Cells.Add(cell);
            tablaDeCarrito.Rows.Add(row);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
using MerCadona.App_Code.Modelos;
using MerCadona.__Controles_Usuario__;

namespace MerCadona.ATENCION_CLIENTE
{
    public partial class InfoReclamaciones : System.Web.UI.Page
    {
        private ControladorFicheros miControl = new ControladorFicheros();
        private List<Reclamacion> lista;
        private string ruta = "../ficheros/RECLAMACIONES.xml";
        private string rutaControl = "~/__Controles_Usuario__/ControlReclamacion.ascx";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                
                foreach (string clave in this.Request.Params.Keys)
                {
                    string claveRequest = this.Request.Params[clave];

                    if ( clave.Contains("botonBorrar") )
                    {
                        string correo = clave.Split(new char[] { ':' })[1];
                        miControl.borraNodo(correo, ruta);
                        cargaReclamaciones();
                        //borrar linea de fichero donde coincida email (posicion 8);
                    }

                }

            }
            else
            {

                cargaReclamaciones();
               

            }
        }
        public void cargaReclamaciones()
        {
            lista = miControl.getReclamaciones(ruta);

            foreach (Reclamacion r in lista)
            {
                //creo control usuario y lo cargo en la tabla
                ControlReclamacion control = (ControlReclamacion)Page.LoadControl(rutaControl);
                control.Asunto = r.Asunto;
                control.Mensaje = r.Mensaje;
                control.Nombre = r.Nombre;
                control.Email = r.Email;
                control.Boton = "botonBorrar" + ":" + r.Email; //mapeo boton

                rellenaTabla(control);
            }
        }
        public void rellenaTabla(ControlReclamacion c)
        {
            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            cell.Controls.Add(c);
            row.Cells.Add(cell);
            this.tablaReclamacion.Rows.Add(row);
        }
        
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("../Inicio.aspx");
        }
    }
}
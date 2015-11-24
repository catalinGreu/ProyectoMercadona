using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
using MerCadona.App_Code.Modelos;
using MerCadona.__Controles_Usuario__;
namespace MerCadona
{
    public partial class DondeSupermercados : System.Web.UI.Page
    {
        private string ruta = "ficheros/Supermercados.xml";
        private string rutaControl = "~/__Controles_Usuario__/ControlSupermercado.ascx";
        private ControladorFicheros __controlFichero;
        private List<Supermercado> listaSupers;

        protected void Page_Load(object sender, EventArgs e)
        {
            __controlFichero = new ControladorFicheros();
            #region "es Postback"
            if (this.IsPostBack)
            {
                foreach (string clave in this.Request.Params.Keys)
                {//no lo coge bien.....Revisar
                    if (clave.Contains("linkInicio"))
                    {
                        this.Response.Redirect("Inicio.aspx");
                    }
                }
            }
            #endregion

            else if (!this.IsPostBack)
            {

                string[] localidades = __controlFichero.getLocalidades(ruta);

                for (int i = 0; i < localidades.Length; i++)
                {
                    this.dropLocalidades.Items.Insert(i, localidades[i]);
                }

                this.listaSupers = __controlFichero.getSuperFromXML(ruta);

                rellenaTablaSuper(listaSupers);
                //falta busqueda por municipios o franjas horarias.
            }
        }

        public void rellenaTablaSuper(List<Supermercado> lista)
        {
            if ( lista.Count == 0 )
            {
                TableRow row = new TableRow();
                row.BackColor = Color.LightSalmon;
                TableCell cell = new TableCell();
                Label l = new Label();
                l.Font.Bold = true;
                l.Text = "No se han encontrado coincidencias";
                cell.Controls.Add(l);
                row.Cells.Add(cell);
                this.tablaSupers.Rows.Add(row);
            }
            string loc = "";
            foreach (Supermercado s in lista)
            {
                //compruebo cuando pongo row de localidad
                if (s.Localidad != loc)
                {
                    loc = s.Localidad;
                    TableRow row = new TableRow();
                    row.BackColor = Color.LightBlue;
                    TableCell cell = new TableCell();
                    Label l = new Label();
                    l.Font.Bold = true;
                    l.Text = loc;
                    cell.Controls.Add(l);
                    row.Cells.Add(cell);
                    this.tablaSupers.Rows.Add(row);
                }
                ControlSupermercado micontrol = (ControlSupermercado)Page.LoadControl(rutaControl);
                micontrol.Calle = s.Calle;
                micontrol.CodigoPostal = s.CP;
                micontrol.Telefono = s.Telefono;
                micontrol.Horario = s.Horario;
                micontrol.Parking = "Si";

                TableRow row2 = new TableRow();
                TableCell cell2 = new TableCell();
                cell2.Controls.Add(micontrol);
                row2.Cells.Add(cell2);
                this.tablaSupers.Rows.Add(row2);

            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string loc = this.dropLocalidades.SelectedValue;
            string hora = this.dropHorarios.SelectedValue;
            List<Supermercado> lista = new List<Supermercado>();

            if (loc != null && hora == "")
            {
                //relleno solo con Supermercados de provincia
                lista = __controlFichero.getSuperLoc(ruta, loc);
                rellenaTablaSuper(lista);
            }
            else if ( loc != null && hora != null )
            {
                lista = __controlFichero.getSuperLocYHora(ruta, loc, hora);
                rellenaTablaSuper(lista);
            }
            /// CUANDO ESTAN VACIOS LOC Y HORA NO VAAAAAA

            //Me leo el xml y devuelvo los arrays necesarios para
            //cargar los campos usuario...cogiendo lo que esté seleccionado en los drop

        }
    }
}
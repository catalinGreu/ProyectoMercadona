using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
using MerCadona.App_Code.Modelos;
namespace MerCadona
{
    public partial class RegistroClientes2 : System.Web.UI.Page
    {
        private ControladorFicheros controlFicheros;
        private Cliente cli;
        private string ruta = "/ficheros/Clientes.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            cli = new Cliente();
            //cargo los drop box
            cargaDias();
            cargaMeses();
            cargaAnios();
            this.tablaForm.Visible = false;
            this.tablaTlf.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("IndexCompra.aspx");
        }

        protected void btnEnviarAlta_Click(object sender, EventArgs e)
        {
            string fecha = this.dropDia.SelectedValue + "/" + this.dropMes.SelectedValue + "/" + this.dropAnio.SelectedValue;
           
            cli = new Cliente();
            cli.Direccion = this.dropDireccion.SelectedValue;
            cli.Nombre = this.inputNombre.Text;
            cli.Apellido = this.inputApe1.Text;
            cli.FechaNacimiento = fecha;
            cli.DNI = this.inputDNI.Text;
            cli.Email = this.inputEmail.Text;
            cli.Password = this.inputPasswd.Text;
            cli.Telefono = this.dropTelefono.Text;

            controlFicheros = new ControladorFicheros();
            controlFicheros.addCliente(cli, ruta);
            this.Response.Redirect("IndexCompra.aspx");
            //creat objeto Cliente y mandarlo a grabar al xml

        }

        public void cargaDias()
        {
            List<int> arrDias = new List<int>();
            for (int i = 1; i <= 31; i++)
            { arrDias.Add(i); }
            for (int i = 0; i < arrDias.Count; i++)
            {
                this.dropDia.Items.Insert(i, arrDias[i].ToString());
            }
        }
        public void cargaMeses()
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo",
    "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            for (int i = 0; i < meses.Length; i++)
            {
                this.dropMes.Items.Insert(i, meses[i]);
            }
        }
        public void cargaAnios()
        {
            List<int> years = new List<int>();
            for (int i = 1915; i < 2016; i++)
            { years.Add(i); }

            for (int i = 0; i < years.Count; i++)
            {
                this.dropAnio.Items.Insert(i, years[i].ToString());
            }
        }

        protected void btnAltaDir_Click(object sender, EventArgs e)
        {

            this.tablaForm.Visible = true;


        }

        protected void btnAltaTlf_Click(object sender, EventArgs e)
        {
            this.tablaTlf.Visible = true;
            
        }

        protected void btnAceptarDir_Click(object sender, EventArgs e)
        {
            string direccion = this.inputVia.Text + " " + this.inputNombreVia.Text + " " + this.inputNum.Text + " " + this.inputPiso.Text + " " + this.inputPuerta.Text + " " + this.inputBloque.Text + " " + this.inputEscalera.Text + " " + this.inputLoc.Text;
            this.tablaForm.Visible = false;
            this.dropDireccion.Items.Insert(0, direccion);
        }

        protected void btnCerrarDir_Click(object sender, EventArgs e)
        {
            this.tablaForm.Visible = false;
        }

        protected void btnCancelarTlf_Click(object sender, EventArgs e)
        {
            this.tablaTlf.Visible = false;
        }

        protected void btnAceptarTlf_Click(object sender, EventArgs e)
        {
            this.dropTelefono.Items.Insert(0, inputTlf.Text);
            this.tablaTlf.Visible = false;
        }
    }
}
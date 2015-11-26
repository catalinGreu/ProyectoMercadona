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
        protected void Page_Load(object sender, EventArgs e)
        {
            cli = new Cliente();
            //cargo los drop box
            cargaDias();
            cargaMeses();
            cargaAnios();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("IndexCompra.aspx");
        }

        protected void btnEnviarAlta_Click(object sender, EventArgs e)
        {
            string fecha = this.dropDia.SelectedValue + "/" + this.dropMes.SelectedValue + "/" + this.dropAnio.SelectedValue;
            this.dropTelefono.SelectedValue = (string)this.Session["direccion"];
            this.dropTelefono.SelectedValue = (string)this.Session["telefono"];
            cli = new Cliente();
            cli.Direccion = this.dropDireccion.SelectedValue;
            cli.Nombre = this.inputNombre.Text;
            cli.Apellido = this.inputApe1.Text;
            cli.FechaNacimiento = fecha;
            cli.DNI = this.inputDNI.Text;
            cli.Email = this.inputEmail.Text;
            cli.Password = this.inputPasswd.Text;
            cli.Telefono = this.dropTelefono.Text;


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
            
            string script = "var windowRef = window.open('AltaDireccion.aspx', null, 'height=6500, width = 935, status=yes, resizeable=no, scrollbars= no, toolbar=no, menubar=no');";
            script += "windowRef.focus();";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "123", script, true);
            string driSession = (string)Session["direccion"];
            this.dropTelefono.SelectedValue = (string)Session["direccion"];


        }

        protected void btnAltaTlf_Click(object sender, EventArgs e)
        {
            string script = "var windowRef = window.open('AltaTlf.aspx', null, 'height=400, width = 935, status=yes, resizeable=no, scrollbars= no, toolbar=no, menubar=no');";
            script += "windowRef.focus();";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "123", script, true);
            string tlfSesion = (string)Session["telefono"];
            this.dropTelefono.SelectedValue = (string)Session["telefono"];
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
using MerCadona.App_Code.Modelos;

namespace MerCadona.ATENCION_CLIENTE
{
    public partial class LoginAdmin : System.Web.UI.Page
    {
        ControladorFicheros miControl;
        private string ruta = "../ficheros/Empleados.xml";
        protected void Page_Load(object sender, EventArgs e)
        {
            miControl = new ControladorFicheros();
            this.inputNIF.Focus();
            
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if ( this.IsValid )
            {
                string nif = this.inputNIF.Text;
                string depart = this.inputDepart.Text.ToUpper();

                if ( depart != "CONTROLCALIDAD" )
                {
                    this.labelAcces.Visible = true;
                    return;
                }
                else
                {
                    bool existe = miControl.compruebEmpleado(nif, depart, ruta);
                    if ( existe )
                    {
                        this.labelAcces.Text = "Usuario OKKKK";
                        this.Response.Redirect("InfoReclamaciones.aspx");

                    }
                    else
                    {
                        this.labelAcces.Text = "ACCESO DENEGADO!";
                        return;
                    }
                }
            }
            else
            {
                return;
            }
            //me leo el fichero XML y si DNI && Depart ==
            //si el DEPARTAMENTO != CONTROLCALIDAD...no compruebo
        }
    }
}
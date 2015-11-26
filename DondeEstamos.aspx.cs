using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MerCadona.App_Code.Controladores;
namespace MerCadona
{
    public partial class DondeEstamos : System.Web.UI.Page
    {
        ControladorFicheros __controlFichero;
        protected void Page_Load(object sender, EventArgs e)
        {
            ContentPlaceHolder holder = (ContentPlaceHolder)this.Master.FindControl("ContentPlaceHolder1");
            //Leer fichero y cargar provincias en 
            //drop down (con controlador ficheros)


            if (this.IsPostBack)
            {

                foreach (string clave in this.Request.Params.Keys)
                {
                    string claveRequest = this.Request.Params[clave];

                    if (clave.Contains("btnAceptar"))
                    {
                        if (this.dropProvincias.SelectedValue == "Madrid")
                        {
                            this.Response.Redirect("DondeSupermercados.aspx");

                        }
                    }
                    if (claveRequest.Contains("linkInicio"))
                    {
                        this.Response.Redirect("Inicio.aspx");
                    }
                    else if (claveRequest.Contains("linkAtencion"))
                    {
                        this.Response.Redirect("AtencionCliente.aspx");
                    }
                    //CONTROLAR ATENCION AL CLIENTE....
                }
            }
            else
            {
                __controlFichero = new ControladorFicheros();
                string[] provincias = __controlFichero.getProvincias("/ficheros/provincias.csv");

                for (int i = 0; i < provincias.Length; i++)
                {
                    this.dropProvincias.Items.Insert(i, provincias[i]);
                }
            }
        }
               
    }
}
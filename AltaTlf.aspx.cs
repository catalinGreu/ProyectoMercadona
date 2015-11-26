using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona
{
    public partial class AltaTlf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {

                this.Session["telefono"] = this.inputTlf.Text;
                ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
            }
            else
            {
                return;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);
        }
    }
}
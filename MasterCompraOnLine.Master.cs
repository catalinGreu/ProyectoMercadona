﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MerCadona
{
    public partial class MasterCompraOnLine : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BotonInicio_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Inicio.aspx");
        }

        protected void BotonDonde_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("DondeEstamos.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("IndexCompra.aspx");
        }
    }
}
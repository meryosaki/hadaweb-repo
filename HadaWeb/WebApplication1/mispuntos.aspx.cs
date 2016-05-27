using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;
namespace WebApplication1
{
    public partial class mispuntos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
                Response.Redirect("~/inicio.aspx");
            ClienteEN c = new ClienteEN();
            c.Nick = Session["USER"].ToString();
            c.recuperarPuntos();
            Puntos.Text = c.PuntosTotales.ToString();
        }
    }
}
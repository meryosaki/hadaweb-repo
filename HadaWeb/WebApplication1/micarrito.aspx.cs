using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;
namespace WebApplication1
{
    public partial class micarrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
                Response.Redirect("~/inicio.aspx");
            double precioTotal = 0;
            string precioActual = "";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                precioActual = GridView1.Rows[i].Cells[2].Text;
                precioTotal += Convert.ToDouble(precioActual);
            }
            Importe.Text = precioTotal.ToString();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
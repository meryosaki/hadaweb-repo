using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;

namespace WebApplication1
{
    public partial class ofertas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string b = Request.QueryString["b"];
            prueba.Text = b;
            prueba.Visible = true;

            if (prueba.Text == "")
            {
                OfertaEN oferta = new OfertaEN();
                prueba.Text = oferta.numEN("null");
                ListView1.Visible = true;
            }
        }

        protected void boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
        }

        protected void mostrar_Click(object sender, EventArgs e)
        {
            string aux = DropDownList1.Text;

            OfertaEN oferta = new OfertaEN();

            string b = oferta.numEN(aux);

            prueba.Text = b;

        }
    }
}
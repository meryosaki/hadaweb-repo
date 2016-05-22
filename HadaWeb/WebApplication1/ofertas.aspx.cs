using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ofertas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (boton != null)
            {
                switch (boton.Text)
                {
                    case "ajedrezdamas": Response.Redirect("oferta-ajedrezdamas.aspx");
                        break;
                    case "badmintonbalon": Response.Redirect("oferta-badmintonbalon.aspx");
                        break;
                    case "biologiaquimica": Response.Redirect("oferta-biologiaquimica.aspx");
                        break;
                    case "buceonatacion": Response.Redirect("oferta-buceonatacion.aspx");
                        break;
                    case "matefisica": Response.Redirect("oferta-matefisica.aspx");
                        break;
                    case "fotophotoshop": Response.Redirect("oferta-fotophotoshop.aspx");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
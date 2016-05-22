using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using PracticaGrupalHADA;

namespace WebApplication1
{
    public partial class cursos : System.Web.UI.Page
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
                    case "Ajedrez": Response.Redirect("curso-ajedrez.aspx");
                        break;
                    case "Photoshop": Response.Redirect("curso-photoshop.aspx");
                        break;
                    case "Balonmano": Response.Redirect("curso-balonmano.aspx");
                        break;
                    case "Natación": Response.Redirect("curso-natacion.aspx");
                        break;
                    case "Buceo": Response.Redirect("curso-buceo.aspx");
                        break;
                    case "Matemáticas": Response.Redirect("curso-matematicas.aspx");
                        break;
                    case "Biología": Response.Redirect("curso-biologia.aspx");
                        break;
                    case "Fotografía": Response.Redirect("curso-fotografia.aspx");
                        break;
                    case "Química": Response.Redirect("curso-quimica.aspx");
                        break;
                    case "Bádminton": Response.Redirect("curso-badminton.aspx");
                        break;
                    case "Física": Response.Redirect("curso-fisica.aspx");
                        break;
                    case "Damas": Response.Redirect("curso-damas.aspx");
                        break;
                }
            }
            
        }


    }

}
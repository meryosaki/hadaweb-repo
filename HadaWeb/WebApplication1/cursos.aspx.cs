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
            string b = Request.QueryString["b"];
            prueba.Text = b;
            prueba.Visible = false;

            if (prueba.Text == "")
            {
                CursoEN curso = new CursoEN();
                prueba.Text = curso.numEN("null");
                ListView1.Visible = true;
            }
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
                    case "Natacion": Response.Redirect("curso-natacion.aspx");
                        break;
                    case "Buceo": Response.Redirect("curso-buceo.aspx");
                        break;
                    case "Matematicas": Response.Redirect("curso-matematicas.aspx");
                        break;
                    case "Biologia": Response.Redirect("curso-biologia.aspx");
                        break;
                    case "Fotografia": Response.Redirect("curso-fotografia.aspx");
                        break;
                    case "Quimica": Response.Redirect("curso-quimica.aspx");
                        break;
                    case "Badminton": Response.Redirect("curso-badminton.aspx");
                        break;
                    case "Fisica": Response.Redirect("curso-fisica.aspx");
                        break;
                    case "Damas": Response.Redirect("curso-damas.aspx");
                        break;
                }
            }

        }

        protected void mostrar_Click(object sender, EventArgs e)
        {
            string aux = DropDownList1.Text;

            CursoEN curso = new CursoEN();

            string b = curso.numEN(aux);

            prueba.Text = b;

        }


    }

}
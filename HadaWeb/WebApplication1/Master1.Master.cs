using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Master1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
            {
                Carrito.Visible = false;
                Cuenta.Visible = false;
                Cerrar.Visible = false;
                CerrarIcon.Visible = false;
                CarritoIcon.Visible = false;

            }
            else
            {
                Identificarse.Visible = false;

            }

        }


        public void RedirectImagenCer(object sender, EventArgs e)
        {
            Response.Redirect("~/identificarse.aspx");
        }

        public void RedirectCuenta(object sender, EventArgs e)
        {
            Response.Redirect("~/identificarse.aspx");
        }

        public void RedirectImagenIde(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
            {
                Response.Redirect("~/identificarse.aspx");
            }
            else
            {
                Response.Redirect("~/micuenta.aspx");
            }
        }

        public void RedirectImagenCar(object sender, EventArgs e)
        {
            Response.Redirect("~/micarrito.aspx");
        }

        public void RedirectIdentificarse(object sender, EventArgs e)
        {
            Response.Redirect("~/identificarse.aspx");
        }
        public void RedirectInicio(object sender, EventArgs e)
        {
            Response.Redirect("~/inicio.aspx");
        }

        public void RedirectQsomos(object sender, EventArgs e)
        {
            Response.Redirect("~/quienes.aspx");
        }
        public void RedirectAviso(object sender, EventArgs e)
        {
            Response.Redirect("~/avisolegal.aspx");
        }
        public void RedirectCursos(object sender, EventArgs e)
        {
            Response.Redirect("~/cursos.aspx");
        }
        public void RedirectOfertas(object sender, EventArgs e)
        {
            Response.Redirect("~/ofertas.aspx");
        }
        public void RedirectComo(object sender, EventArgs e)
        {
            Response.Redirect("~/comocomprar.aspx");
        }
    }
}
      




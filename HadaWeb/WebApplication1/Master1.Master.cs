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
            //primero controlo cuando los dos son nulos, es decir, no me he logeado
            if (Session["USER"] == null)
            {
                if (Session["PROFESSOR"] == null)
                {
                    Cuenta.Visible = false;
                    Identificarse.Visible = true;
                    IdentificarseIcon.Visible = true;
                    Cerrar.Visible = false;
                    Carrito.Visible = false;
                    CerrarIcon.Visible = false;
                    CarritoIcon.Visible = false;
                }
                //ahora controlo cuando me logeo como profesor
                if (Session["PROFESSOR"] != null)
                {
                    Cuenta.Visible = true;
                    Identificarse.Visible = false;
                    IdentificarseIcon.Visible = true;
                    Cerrar.Visible = true;
                    Carrito.Visible = false;
                    CerrarIcon.Visible = true;
                    CarritoIcon.Visible = false;
                }
            }
            else{
                //ahora controlo cuando me logeo como cliente
                if (Session["PROFESSOR"] == null)
                {
                    Cuenta.Visible = true;
                    Identificarse.Visible = false;
                    IdentificarseIcon.Visible = true;
                    Cerrar.Visible = true;
                    Carrito.Visible = true;
                    CerrarIcon.Visible = true;
                    CarritoIcon.Visible = true;
                }
            }

        }


        public void RedirectImagenCer(object sender, EventArgs e)
        {
            if (Session["USER"] != null)
            {
                Session["USER"] = null;
            }
            if (Session["PROFESSOR"] != null)
            {
                Session["PROFESSOR"] = null;
            }
            Response.Redirect("~/identificarse.aspx");
        }

        public void RedirectCuenta(object sender, EventArgs e)
        {
            if (Session["USER"] != null)
            {
                Response.Redirect("~/micuenta.aspx");
            }
            else
            {
                if (Session["PROFESSOR"] != null)
                {
                    Response.Redirect("~/profesorcuenta.aspx");
                }
            }
            
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

        public void RedirectCarrito(object sender, EventArgs e)
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
      




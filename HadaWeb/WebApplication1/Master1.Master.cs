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
            }
           
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
            Response.Redirect("~/comprar.aspx");
        }
      




        /**
         * protected void Page_Load(object sender, EventArgs e)
        {
          if (Session["USER"] == null)
            {
                Identificate.Visible = true;
                Salir.Visible = false;
                Carrito.Visible = false;
            }
            else
            {
                Identificate.Visible = false;
                Salir.Visible = true;
                Carrito.Visible = true;
            }
         }
      
        public void InicioRedirect(object sender, EventArgs e)
        {
            Response.Redirect("~/inicio.aspx");
        }
        public void CursosRedirect(object sender, EventArgs e)
        {
            Response.Redirect("~/cursos.aspx");
        }
        public void OfertasRedirect(object sender, EventArgs e)
        {
            Response.Redirect("~/ofertas.aspx");
        }
        public void ComprarRedirect(object sender, EventArgs e)
        {
            Response.Redirect("~/comprar.aspx");
        }
        public void QuienesRedirect(object sender, EventArgs e)
        {
            Response.Redirect("~/quienes.aspx");
        }
        public void AvisoRedirect(object sender, EventArgs e)
        {
            Response.Redirect("~/avisolegal.aspx");
        }
        public void IdentificateRedirect(object sender, EventArgs e)
        {
            Response.Redirect("~/identificarse.aspx");
        }
        public void SalirRedirect(object sender, EventArgs e)
        {
            if (Session["USER"] != null)
            {
                Session["USER"] = null;
            }
            Response.Redirect("~/inicio.aspx");
        }
        public void CarritoRedirect(object sender, EventArgs e) {
            Response.Redirect("~/micarrito.aspx");
        
        }
         * */
    }
}
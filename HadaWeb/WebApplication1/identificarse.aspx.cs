using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;

namespace WebApplication1
{
    public partial class identificarse : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            //Session.Clear(); //para cerrar sesion
        }
        public void crearCliente(object sender, EventArgs e)
        {
            UsuarioEN nuevo = new UsuarioEN();
            nuevo.Nick = login.Text;
            nuevo.Contrasenya = password.Text;
            if (nuevo.comprobarNickContrasenya())
            {
                Session["USER"] = nuevo.Nick;
                Response.Redirect("~/micuenta.aspx");
            }
            else
            {
                login.Text = "MAAAAAAAAl";
                //Response.Redirect("~/identificarse.aspx");
            }
        }
    }
}







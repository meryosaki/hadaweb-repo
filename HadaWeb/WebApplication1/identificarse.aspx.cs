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
            Session.Clear(); //para cerrar sesion
        }
        public void crearCliente(object sender, EventArgs e)
        {
            UsuarioEN nuevo = new UsuarioEN();
            nuevo.Nick = Nick.Text;
            nuevo.Contrasenya = password.Text;
            if (Page.IsValid)
            {
                Session["USER"] = nuevo.Nick;
                Response.Redirect("~/micuenta.aspx");
            }
            //else
            //{
                //Response.Redirect("~/identificarse.aspx");
            //}
        }

        protected void ComprobarUsuario(object sender, ServerValidateEventArgs e)
        {
            string nick = e.Value.ToLower();
            string contraseña = password.Text;
            UsuarioEN us = new UsuarioEN();
            us.Nick = nick;
            us.Contrasenya = contraseña;
            e.IsValid = us.comprobarNickContrasenya();
        }
    }
}







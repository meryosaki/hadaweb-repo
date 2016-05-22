using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;
namespace WebApplication1
{
    public partial class misdatoseditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
                Response.Redirect("~/inicio.aspx");

            UsuarioEN us = new UsuarioEN();
            us.Nick = Session["USER"].ToString();
            us.mostrar_usuario();
            Nick.Text=us.Nick;
            Nombre.Text=us.Nombre;
            Email.Text= us.Email;
        }

        protected void Confirmar(object sender, EventArgs e)
        {
            UsuarioEN cliente = new UsuarioEN();
            cliente.Nick = Session["USER"].ToString();
            cliente.recuperarId_EN();
            cliente.Nick = Nick.Text;
            cliente.Nombre = Nombre.Text;
            cliente.Email = Email.Text;
            cliente.modificar_usuario();

        }
        protected void ComprobarUsuario(object sender, ServerValidateEventArgs e)
        {
            string nick = e.Value.ToLower();
            UsuarioEN us = new UsuarioEN();
            e.IsValid = us.ComprobarNick(nick);
        }


    }
}
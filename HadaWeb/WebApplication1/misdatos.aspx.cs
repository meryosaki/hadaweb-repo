using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;
namespace WebApplication1
{
    public partial class misdatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null && Session["PROFESSOR"] == null)
                Response.Redirect("~/inicio.aspx");

            if (Session["USER"] != null)
            {
                UsuarioEN us = new UsuarioEN();
                us.Nick = Session["USER"].ToString();
                us.mostrar_usuario();

                ImagePerfil.ImageUrl = us.Avatar;
                Nick.Text = us.Nick;
                Nombre.Text = us.Nombre; ;
                Email.Text = us.Email;
            }
            else
            {
                UsuarioEN us = new UsuarioEN();
                us.Nick = Session["PROFESSOR"].ToString();
                us.mostrar_usuario();

                ImagePerfil.ImageUrl = us.Avatar;
                Nick.Text = us.Nick;
                Nombre.Text = us.Nombre; ;
                Email.Text = us.Email;


            }


        }
    }
}
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
            if (Session["USER"] != null)
            {
                UsuarioEN us = new UsuarioEN();
                us.Nick = Session["USER"].ToString();
                us.mostrar_usuario();

                Label1.Text = us.Nick;
                Label2.Text = us.Nombre; ;
                Label3.Text = us.Email;
            }
            else
                Response.Redirect("~/inicio.aspx");


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;

namespace WebApplication1
{
    public partial class mipasseditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null && Session["PROFESSOR"] == null)           
                Response.Redirect("~/inicio.aspx");

        }

         protected void Aceptar_OnClick(object sender, EventArgs e){

             if (Page.IsValid)
             {
                 UsuarioEN usuario = new UsuarioEN();
                 usuario.Nick = (Session["USER"].ToString() == "") ? Session["PROFESSOR"].ToString() : Session["USER"].ToString();
                 usuario.Contrasenya = TextBoxContrasenyaNueva1.Text;
                 usuario.modificar_usuario_contrasenya();
                 Response.Redirect("~/misdatos.aspx");
             }
            



         }

         protected void ComprobarPass(object sender, ServerValidateEventArgs e)
         {
             string nick;
             if (Session["USER"] == null)
             {
                 nick = Session["PROFESSOR"].ToString();
             }else{
                 nick=Session["USER"].ToString();
             }
                 
                     UsuarioEN us = new UsuarioEN();
                     us.Nick = nick;
                     us.Contrasenya = TextBoxContrasenya.Text;
                     e.IsValid = us.comprobar_pass();         
         }

         protected void Cancelar_OnClick(object sender, EventArgs e)
         {


             Response.Redirect("~/misdatos.aspx");

         }
        
    }
}
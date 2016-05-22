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
            //necesito saber si el usuario que pretende iniciar sesion
            //es un profesor o un cliente
            //para ello lo primero que debo hacer es saber si puede o no iniciar sesion 
            //ya que si no puedo no tengo porque comprobar que tipo de usuario es
            if (nuevo.comprobarNickContrasenya())
            {

                //en este punto ya he iniciado sesion 
                //pero debo saber si soy profesor o si soy cliente
                nuevo.recuperarId_EN();
                //int auxID = nuevo.IdUsuario;
                //ya tnego el id del usuario
                //ahora quiero saber si ese id corresponde a un profesor o a un cliente
                bool esCliente = false;
                esCliente = nuevo.comprobarUsuarioClienteEN();
                if (esCliente == true)
                {
                    Session["USER"] = nuevo;
                    Response.Redirect("~/micuenta.aspx");
                }
                else
                {
                    Session["PROFESSOR"] = nuevo;
                    Response.Redirect("~/profesorcuenta.aspx");
                }
                //Session["USER"] = nuevo.Nick;
                //guardo en session el objeto entero(dejo arriba conectado lo que habia antes)


            }
            else
            {
                login.Text = "MAAAAAAAAl";
                //Response.Redirect("~/identificarse.aspx");
            }
        }
    }
}











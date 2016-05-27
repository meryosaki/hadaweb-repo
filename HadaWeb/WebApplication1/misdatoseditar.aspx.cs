using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;
using System.Windows;


namespace WebApplication1
{
    public partial class misdatoseditar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioEN us = new UsuarioEN();
            if (Session["USER"] == null && Session["PROFESSOR"] == null)
                Response.Redirect("~/inicio.aspx");

            if (Session["USER"] == null)
            {
                us.Nick = Session["PROFESSOR"].ToString();
            }
            else if (Session["PROFESSOR"] == null)
            {
                us.Nick = Session["USER"].ToString();
            }
            
            us.mostrar_usuario();
            ImagePerfil.ImageUrl = us.Avatar;
            NickTextBox.WatermarkText = us.Nick;
            EmailTextBox.WatermarkText = us.Email;
            NombreTextBox.WatermarkText = us.Nombre;

        }







        protected void ConfirmarArchivo(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/images/userimages/");
            bool fileOk = false;
            if (SubirArchivo.HasFile)
            {
                string FileName = System.IO.Path.GetExtension(SubirArchivo.FileName).ToLower();
                string[] extensionesPermitidas = { ".gif", ".png", ".jpeg", ".jpg" };

                for (int i = 0; i < extensionesPermitidas.Length; i++)
                {
                    if (FileName == extensionesPermitidas[i])
                    {
                        fileOk = true;
                    }
                }
                if (!fileOk)
                {
                    ArchivoSubido.Text = "Extensión de archivo no permitida";
                    ArchivoSubido.Visible = true;
                }
                if (fileOk)
                {
                    UsuarioEN usuario = new UsuarioEN();

                    //try{

                    if (Session["USER"] == null)
                    {
                        usuario.Nick = Session["PROFESSOR"].ToString();
                        SubirArchivo.PostedFile.SaveAs(path + usuario.Nick + SubirArchivo.FileName);

                    }
                    else
                    {
                        usuario.Nick = Session["USER"].ToString();
                        SubirArchivo.PostedFile.SaveAs(path + usuario.Nick + SubirArchivo.FileName);
                    }
                    path = "~/images/userimages/";
                    usuario.Avatar = path + usuario.Nick + SubirArchivo.FileName; ;
                    usuario.modificar_usuario_avatar();
                    ArchivoSubido.Text = path;// "Archivo Subido Correctamente!";
                    ArchivoSubido.Visible = true;
                    ImagePerfil.ImageUrl = path + usuario.Nick + SubirArchivo.FileName;
                    // }
                    //catch (Exception errorArchivo)
                    // {
                    ArchivoSubido.Visible = true;
                    ArchivoSubido.Text = "Error al subir el archivo";


                    //}

                }
            }
        }





        protected void Confirmar(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                bool usuario = false;
                UsuarioEN cliente = new UsuarioEN();
                if (Session["USER"] == null)
                {
                    cliente.Nick = Session["PROFESSOR"].ToString();
                }
                else if (Session["PROFESSOR"] == null)
                {
                    usuario = true;
                    cliente.Nick = Session["USER"].ToString();
                }
                cliente.recuperarId_EN();
                cliente.Nick = (Nick.Text == "") ? NickTextBox.WatermarkText : Nick.Text;
                cliente.Email = (Email.Text == "") ? EmailTextBox.WatermarkText : Email.Text;
                cliente.Nombre = (Nombre.Text == "") ? NombreTextBox.WatermarkText : Nombre.Text;

                cliente.modificar_usuario();
                if (usuario == true)
                {
                    Session["USER"] = cliente.Nick;

                }
                else
                {
                    Session["PROFESSOR"] = cliente.Nick;
                }
            }
        }








        protected void ComprobarUsuario(object sender, ServerValidateEventArgs e)
        {
            string nick = e.Value.ToLower();
            if (Session["USER"] == null)
            {
                if (Session["PROFESSOR"].ToString() != nick)
                {
                    UsuarioEN us = new UsuarioEN();
                    e.IsValid = us.ComprobarNick(nick);
                }
            }
            else
            {
                if (Session["USER"].ToString() != nick)
                {
                    UsuarioEN us = new UsuarioEN();
                    e.IsValid = us.ComprobarNick(nick);
                }
            }
        }
    }
}












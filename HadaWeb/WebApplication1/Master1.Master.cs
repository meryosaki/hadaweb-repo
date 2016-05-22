using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace WebApplication1
{
    public partial class Master1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //primero controlo cuando los dos son nulos, es decir, no me he logeado 
            if (Session["USER"] == null)
            {
                if (Session["PROFFESOR"] == null)
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
                if (Session["PROFFESOR"] != null) 
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
                //ahora controlo cuando me logio como cliente
                if (Session["PROFFESOR"] == null)
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

<<<<<<< HEAD
        }


        public void RedirectImagenCer(object sender, EventArgs e)
        {
            if (Session["USER"] != null)
            {
                Session["USER"] = null;
            }
            if (Session["PROFFESOR"] != null)
            {
                Session["PROFFESOR"] = null;
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
                if (Session["PROFFESOR"] != null)
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
=======
>>>>>>> refs/remotes/origin/master
        }


        public void RedirectImagenCer(object sender, EventArgs e)
        {
            if (Session["USER"] != null)
            {
                Session["USER"] = null;
            }
            if (Session["PROFFESOR"] != null)
            {
                Session["PROFFESOR"] = null;
            }
            Response.Redirect("~/identificarse.aspx");
        }

        public void RedirectCuenta(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
        public void SendMail(object sender, EventArgs e)
        {
            String MensajeCorreo = Mensaje.Text;
            String Nick = NickSend.Text;
            String Correo = EmailSend.Text;
            try
            {
                //Configuración del Mensaje
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
                mail.From = new MailAddress("servirentweb@gmail.com", Nick, Encoding.UTF8);
                //Aquí ponemos el asunto del correo
                mail.Subject = Correo;
                //Aquí ponemos el mensaje que incluirá el correo
                mail.Body = MensajeCorreo;
                //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
                mail.To.Add("servirentweb@gmail.com");


                //Configuracion del SMTP
                SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
                //Especificamos las credenciales con las que enviaremos el mail
                SmtpServer.Credentials = new System.Net.NetworkCredential("servirentweb@gmail.com", "Hada1234");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

            }
            catch (Exception ex)
            {
                Response.Redirect("~/identificarse.aspx");
            }
        }


=======
            if (Session["USER"] != null)
            {
                Response.Redirect("~/micuenta.aspx");
            }
            else
            {
                if (Session["PROFFESOR"] != null)
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
>>>>>>> refs/remotes/origin/master
    }
}
      




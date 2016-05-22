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
    }
}
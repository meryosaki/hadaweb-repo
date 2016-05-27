using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;

namespace WebApplication1
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
              Response.Redirect("~/inicio.aspx");

            //string cadena = Request.QueryString["cadena"];

            t1.Visible = false; t2.Visible = false; t3.Visible = false; t4.Visible = false; t5.Visible = false; t6.Visible = false; t7.Visible = false; t8.Visible = false; t9.Visible = false; t10.Visible = false; t11.Visible = false; t12.Visible = false; t13.Visible = false; t14.Visible = false; t15.Visible = false; pagarTarjeta.Visible = false;
            Tr1.Visible = false; Tr6.Visible = false; caixa.Visible = false; sabadell.Visible = false; BBVA.Visible = false; santander.Visible = false;
            W1.Visible = false; W3.Visible = false;
            P1.Visible = false; P2.Visible = false;P3.Visible = false;

        }

        protected void visa_Click(object sender, ImageClickEventArgs e)
        {
            t2.BorderColor = System.Drawing.Color.Cyan;
            t2.BorderWidth = 1;
            t3.BorderColor = System.Drawing.Color.White;
            t4.BorderColor = System.Drawing.Color.White;
            t5.BorderColor = System.Drawing.Color.White;
            t1.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
            t4.Visible = true;
            t5.Visible = true;
            t6.Visible = true;
            t7.Visible = true;
            t8.Visible = true;
            t9.Visible = true;
            t10.Visible = true;
            t11.Visible = true;
            t12.Visible = true;
            t13.Visible = true;
            t14.Visible = true;
            t15.Visible = true;
            pagarTarjeta.Visible = true;
        }
        protected void master_Click(object sender, ImageClickEventArgs e)
        {
            t3.BorderColor = System.Drawing.Color.Cyan;
            t3.BorderWidth = 1;
            t2.BorderColor = System.Drawing.Color.White;
            t4.BorderColor = System.Drawing.Color.White;
            t5.BorderColor = System.Drawing.Color.White;
            t1.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
            t4.Visible = true;
            t5.Visible = true;
            t6.Visible = true;
            t7.Visible = true;
            t8.Visible = true;
            t9.Visible = true;
            t10.Visible = true;
            t11.Visible = true;
            t12.Visible = true;
            t13.Visible = true;
            t14.Visible = true;
            t15.Visible = true;
            pagarTarjeta.Visible = true;
        }

        protected void maestro_Click(object sender, ImageClickEventArgs e)
        {
            t4.BorderColor = System.Drawing.Color.Cyan;
            t4.BorderWidth = 1;
            t3.BorderColor = System.Drawing.Color.White;
            t2.BorderColor = System.Drawing.Color.White;
            t5.BorderColor = System.Drawing.Color.White;
            t1.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
            t4.Visible = true;
            t5.Visible = true;
            t6.Visible = true;
            t7.Visible = true;
            t8.Visible = true;
            t9.Visible = true;
            t10.Visible = true;
            t11.Visible = true;
            t12.Visible = true;
            t13.Visible = true;
            t14.Visible = true;
            t15.Visible = true;
            pagarTarjeta.Visible = true;
        }

        protected void amex_Click(object sender, ImageClickEventArgs e)
        {
            t5.BorderColor = System.Drawing.Color.Cyan;
            t5.BorderWidth = 1;
            t3.BorderColor = System.Drawing.Color.White;
            t4.BorderColor = System.Drawing.Color.White;
            t2.BorderColor = System.Drawing.Color.White;
            t1.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
            t4.Visible = true;
            t5.Visible = true;
            t6.Visible = true;
            t7.Visible = true;
            t8.Visible = true;
            t9.Visible = true;
            t10.Visible = true;
            t11.Visible = true;
            t12.Visible = true;
            t13.Visible = true;
            t14.Visible = true;
            t15.Visible = true;
            pagarTarjeta.Visible = true;
        }

        protected void tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            western.Checked = false;
            transferencia.Checked = false;
            paysafecard.Checked = false;

            t1.Visible = true;
            t2.Visible = true;
            t3.Visible = true;
            t4.Visible = true;
            t5.Visible = true;
            t6.Visible = true;
            t7.Visible = true;
            t8.Visible = true;
            t9.Visible = true;
            t10.Visible = true;
            t11.Visible = true;
            t12.Visible = true;
            t13.Visible = true;
            t14.Visible = true;
            t15.Visible = true;
            pagarTarjeta.Visible = true;
        }

        protected void transferencia_CheckedChanged(object sender, EventArgs e)
        {
            tarjeta.Checked = false;
            western.Checked = false;
            paysafecard.Checked = false;

            Tr1.Visible = true; 
            Tr6.Visible = true; 
            caixa.Visible = true; 
            sabadell.Visible = true; 
            BBVA.Visible = true; 
            santander.Visible = true;
        }

        protected void paysafecard_CheckedChanged(object sender, EventArgs e)
        {
            tarjeta.Checked = false;
            western.Checked = false;
            transferencia.Checked = false;
            P1.Visible = true;
            P2.Visible = true;
            P3.Visible = true;
        }

        protected void western_CheckedChanged(object sender, EventArgs e)
        {
            tarjeta.Checked = false;
            paysafecard.Checked = false;
            transferencia.Checked = false;
            W1.Visible = true; 
            W3.Visible = true;
        }

        protected void pagarTarjeta_Click(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.FormaPago = "Tarjeta";
            pedido.Confirmar();
            Response.Redirect("~/micuenta.aspx");
        }

        protected void caixa_Click(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.FormaPago = "Transferencia";
            pedido.Confirmar();
            
            Response.Redirect("https://portal.lacaixa.es/");
        }

        protected void sabadell_Click(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.FormaPago = "Transferencia";
            pedido.Confirmar();
            Response.Redirect("https://www.bancsabadell.com/cs/Satellite/SabAtl/");
        }

        protected void BBVA_Click(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.FormaPago = "Transferencia";
            pedido.Confirmar();
            Response.Redirect("https://www.bbva.es/particulares/index.jsp");
        }

        protected void Santander_Click(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.FormaPago = "Transferencia";
            pedido.Confirmar();
            Response.Redirect("https://www.bancosantander.es/es/particulares");
        }

        protected void W3_Click(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.FormaPago = "Wester Union";
            pedido.Confirmar();
            Response.Redirect("https://www.westernunion.es/WUCOMWEB/staticMid.do?method=load&countryCode=ES&languageCode=es&pagename=HomePage");
        }

        protected void pay_Click(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.FormaPago = "Paysafecard";
            pedido.Confirmar();
            Response.Redirect("~/micuenta.aspx");
        }

        protected void factura_Click(object sender, EventArgs e)
        {
            Response.Redirect("factura.aspx");
        }

    }
}
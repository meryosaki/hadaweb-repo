using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;
namespace WebApplication1
{
    public partial class micarrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
                Response.Redirect("~/inicio.aspx");


            double precioTotal = 0;
            string precioActual = "";
            if (GridView1.Rows.Count == 0)
            {
                NoArticulos.Visible = true;
                Importe.Visible = false;
                ImportePuntos.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                ConfirmarPedido.Visible = false;
                BorrarPedido.Visible = false;
            }
            else
            {
                NoArticulos.Visible = false;
                Importe.Visible = true;
                ImportePuntos.Visible = true;
                Label1.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;
                Label4.Visible = true;
                ConfirmarPedido.Visible = true;
                BorrarPedido.Visible = true;


                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    precioActual = GridView1.Rows[i].Cells[2].Text;
                    precioTotal += Convert.ToDouble(precioActual);
                }
                Importe.Text = precioTotal.ToString();
                string nombre = Session["USER"].ToString();
                ClienteEN c = new ClienteEN();
                c.Nick = nombre;
                c.recuperarPuntos();
                if (c.PuntosTotales >= 100)
                    ImportePuntos.Text = (precioTotal - 0.1 * precioTotal).ToString();
                else
                    ImportePuntos.Text = (precioTotal).ToString();
            }    
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void confirmarP(object sender, EventArgs e)
        {
           /* string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            ClienteEN c = new ClienteEN();
            c.Nick = nombre;
            c.recuperarPuntos();
            if (c.PuntosTotales >= 100)
                c.restarPuntos();
            pedido.Cliente = nombre;
            pedido.Confirmar();*/
            Response.Redirect("~/forma-pago.aspx");
        }

        protected void borrarP(Object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            pedido.Cliente = nombre;
            pedido.borrar_todos_los_pedidos();
            Response.Redirect("~/micarrito.aspx");
        }

        protected void EliminarArticulo(Object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string usuario = Session["USER"].ToString();
                string curso = GridView1.Rows[index].Cells[1].Text;
                PedidoEN p = new PedidoEN();
                p.Cliente = usuario;
                p.borrar_pedido_carrito(curso);
                Response.Redirect("~/micarrito.aspx");
            }
        }      
    }
}
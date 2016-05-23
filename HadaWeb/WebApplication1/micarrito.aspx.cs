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
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                precioActual = GridView1.Rows[i].Cells[2].Text;
                precioTotal += Convert.ToDouble(precioActual);
            }
            Importe.Text = precioTotal.ToString();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void confirmarP(object sender, EventArgs e)
        {
            string nombre = Session["USER"].ToString();
            PedidoEN pedido = new PedidoEN();
            pedido.Cliente = nombre;
            pedido.Confirmar();
            Response.Redirect("~/misdatos.aspx");
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
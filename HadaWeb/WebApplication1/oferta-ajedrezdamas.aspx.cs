﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PracticaGrupalHADA;

namespace WebApplication1
{
    public partial class oferta_ajedrezdamas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void comprar_Click(object sender, EventArgs e)
        {
            if (Session["USER"] == null)
            {
                Response.Redirect("identificarse.aspx");
            }
            else
            {
                string fecha = (DateTime.Today).ToString("d");
                DateTime f = new DateTime();
                f = DateTime.Parse(fecha);
                //string cadena = "";
                PedidoEN pedido = new PedidoEN();
                pedido.IdPedido = 1;
                pedido.Puntos = 50;
                pedido.EstadoPago = null;
                pedido.FormaPago = null;
                pedido.EstadoPedido = "Activo";
                pedido.Cliente = Session["USER"].ToString();
                pedido.Descripcion = "Curso de Ajedrez";
                pedido.F_compra = f;
                pedido.Importe_total = 50;
                pedido.Curso = null;
                pedido.Oferta = 4;
                //CursoEN cursoAjedrez = new CursoEN();
                pedido.insertar_pedido();
                Response.Redirect("micarrito.aspx");
            }

        }
    }
}
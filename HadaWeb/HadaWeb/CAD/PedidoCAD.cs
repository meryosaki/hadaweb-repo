using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace PracticaGrupalHADA
{
    // Clase que gestiona la insercion y borrado de pedidos de los cursos solicitados por los clientes
    class PedidoCAD
    {
        // En esta variable se almacenara el nombre de la bbdd para poder trabajar con ella mas adelante
        private String BDD;
        private PedidoEN pedido;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;

         // Constructor de pedidoCAD
        public PedidoCAD(string bbdd = ""){
            // Se asigna la bbdd a la clase
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            pedido = new PedidoEN();
        }

        // Metodo que inserta pedidos en la bbdd 
        public void insertar_pedido(PedidoEN pedido){
            this.pedido = pedido;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from pedido";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "pedido");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["pedido"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = pedido.IdPedido;
            nuevafila[1] = pedido.Descripcion;
            nuevafila[2] = pedido.F_compra;
            nuevafila[3] = pedido.Importe_total;
            nuevafila[4] = pedido.Puntos;
            nuevafila[5] = pedido.EstadoPago;
            nuevafila[6] = pedido.FormaPago;
            nuevafila[7] = pedido.EstadoPedido;
            nuevafila[8] = pedido.Cliente;
            nuevafila[9] = pedido.Curso;
            nuevafila[10] = pedido.Oferta;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "pedido");

            // Aqui realizamos el insert en la bbdd
        }

        // Metodo que borra pedidos de la bbdd 
        public void borrar_pedido(int id){
            // Aqui realizamos el delete en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from pedido where idPedido = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que actualiza los datos de un pedido
        public void modificar_pedido(PedidoEN pedido){
            // Aqui realizamos el update en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("update pedido set descripcion ='" + pedido.Descripcion + "', f_compra =" + pedido.F_compra + "', importe_total =" + pedido.Importe_total + "', puntos =" + pedido.Puntos + "', estadoPago =" + pedido.EstadoPago + "', formaPago =" + pedido.FormaPago + "', estadoPedido =" + pedido.EstadoPedido + "', cliente =" + pedido.Cliente + ", oferta =" + pedido.Oferta + "where idPedido = " + pedido.IdPedido, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que muestra un pedido en concreto a partir de un id, que identifica a los cursos
        public PedidoEN mostrar_pedido(int id)
        {
            SqlDataReader dr;
            PedidoEN pedido = new PedidoEN();
            try
            {
                conex.Open();
                string operation = "Select * from usuario where idPedido = " + id;
                SqlCommand com = new SqlCommand(operation, conex);
                dr = com.ExecuteReader();
                dr.Read();

                pedido.Descripcion = dr["descripcion"].ToString();
                pedido.F_compra = Convert.ToDateTime(dr["f_compra"].ToString());
                pedido.Importe_total = Int32.Parse(dr["importe_total"].ToString());
                pedido.Puntos = Int32.Parse(dr["puntos"].ToString());
                pedido.EstadoPago = dr["estadoPago"].ToString();
                pedido.FormaPago = dr["formaPago"].ToString();
                pedido.EstadoPedido = dr["estadoPedido"].ToString();
                pedido.Cliente = dr["cliente"].ToString();
                pedido.Curso = Convert.ToInt32(dr["curso"].ToString());
                pedido.Oferta = Convert.ToInt32(dr["oferta"].ToString());
            }
            catch (Exception ex)
            {

                //Aqui trataremos la excepcion.         
            }
            finally
            {
                conex.Close();

            }
            return pedido;
        }

        // Metodo que devuelve todos los pedidos que han sido registrados en la bbdd (pedidos solicitados)
        public List<PedidoEN> mostrar_todos_pedidos()
        {
            List<PedidoEN> pedidos = new List<PedidoEN>();
            return pedidos;
        }
        //Esta función cuando le demos a confirmar perdido en el carrito pondrá todos los pedidos del carrito como finalizados y pagados
        public void Confirmar(string cliente)
        {
            PedidoEN pedido = new PedidoEN();
            conex.Open();
            string operation = "Update pedido set estadoPedido = 'Finalizado', estadoPago = 'Pagado' where cliente = '" + cliente + "' and estadoPedido = 'Activo'";
            SqlCommand com = new SqlCommand(operation, conex);
            com.ExecuteNonQuery();
        }
        //Esta función suma los puntos que da cada pedido y se lo añade al usuario
        public void SumarPuntos(string cliente) {
            PedidoEN p = new PedidoEN();
            conex.Open();
            string operation = "Update cliente set puntosTotales = puntosTotales + isnull ((Select sum(puntos) from pedido where cliente = '" + cliente + "' and estadoPedido = 'Activo') , 0) from cliente inner join usuario on usuario.idUsuario = cliente.idCliente and nick = '" + cliente + "'";
            SqlCommand com = new SqlCommand(operation, conex);
            com = new SqlCommand(operation, conex);
            com.ExecuteNonQuery();
            conex.Close();   
        }

        public void borrar_pedido_carrito(string cliente, string curso) {
            conex.Open();
            //SqlCommand com = new SqlCommand("Delete p from pedido p inner join curso c on p.curso = c.idCurso where cliente = '" + cliente + "' and c.nombre = '" + curso + "'", conex);
            SqlCommand com = new SqlCommand("Delete from pedido where idPedido in (select idPedido from pedido p inner join curso c on p.curso = c.idCurso where cliente = '" + cliente + "' and c.nombre = '" + curso + "' union select idPedido from pedido p inner join oferta o on p.oferta = o.idOferta where cliente = '" + cliente + "' and o.nombre = '" + curso + "')", conex);
            com.ExecuteNonQuery();
            conex.Close();      
        }
        //Esta función borra todos los pedidos del carrito
        public void borrar_todos_los_pedidos(string cliente)
        {
            conex.Open();
            SqlCommand com = new SqlCommand("Delete p from pedido p where cliente = '" + cliente + "' and estadoPedido = 'Activo'", conex);
            com.ExecuteNonQuery();
            conex.Close();
        }
    }
}

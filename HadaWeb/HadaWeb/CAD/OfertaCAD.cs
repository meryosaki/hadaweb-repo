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
    public class OfertaCAD
    {
        // En esta variable se almacenara el nombre de la bbdd para poder trabajar con ella mas adelante
        private String BDD;
        private OfertaEN oferta;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;

         // Constructor de ofertaCAD
        public OfertaCAD(string bbdd = ""){
            // Se asigna la bbdd a la clase
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            oferta = new OfertaEN();
        }

        // Metodo que inserta ofertas en la bbdd 
        public void insertar_oferta(OfertaEN oferta){
            // Aqui realizamos el insert en la bbdd
            this.oferta = oferta;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from oferta";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "oferta");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["oferta"];
            DataRow nuevafila = t.NewRow();
            nuevafila[0] = oferta.IdOferta;
            nuevafila[1] = oferta.Nombre;
            nuevafila[2] = oferta.Avatar;
            nuevafila[3] = oferta.Categoria;
            nuevafila[4] = oferta.Curso1;
            nuevafila[5] = oferta.Curso2;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "oferta");
        }

        // Metodo que borra ofertas de la bbdd 
        public void borrar_oferta(int id){
            // Aqui realizamos el delete en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from oferta where idOferta = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que actualiza los datos de un oferta
        public void modificar_oferta(OfertaEN oferta){
            // Aqui realizamos el update en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("update oferta set  idOferta = " + ", nombre = '" + oferta.Nombre + "', avatar = '" + oferta.Avatar + "', categoria = '"+ oferta.Categoria + "', curso1 = " + oferta.Curso1 + ", curso2 =" + oferta.Curso2 + "where idOferta = " + oferta.IdOferta, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que muestra un oferta en concreto a partir de un id, que identifica a los cursos
        public OfertaEN mostrar_oferta(int id)
        {
            SqlDataReader dr;
            OfertaEN oferta = new OfertaEN();
            try
            {
                conex.Open();
                string operation = "Select * from usuario where idCurso = " + id;
                SqlCommand com = new SqlCommand(operation, conex);
                dr = com.ExecuteReader();
                dr.Read();
                oferta.IdOferta = Int32.Parse(dr["idOferta"].ToString());
                oferta.Nombre = dr["nombre"].ToString();
                oferta.Avatar = dr["avatar"].ToString();
                oferta.Categoria = dr["categoria"].ToString();
                oferta.Curso1 = Int32.Parse(dr["curso1"].ToString());
                oferta.Curso2 = Int32.Parse(dr["curso2"].ToString());
                dr.Close();


            }
            catch (Exception ex)
            {

                //Aqui trataremos la excepcion.         
            }
            finally
            {
                conex.Close();

            }
            return oferta;

        }

        public string nombresOfertasCAD(string a)
        {
            string aux = "";
            int id_max = Last_ID();
            int id_min = Min_ID();
            for (int i = id_min; i < id_max; i++)
            {
                using (SqlConnection conexion = new SqlConnection(BDD))
                {
                    string sql2 = "";

                    if (a != "null")
                    {
                        sql2 = "select nombre from oferta where categoria = '" + a + "' and idOferta = " + i;
                    }
                    else
                    {
                        sql2 = "select nombre from oferta where idOferta = " + i;
                    }

                    conexion.Open();

                    SqlCommand com = new SqlCommand();
                    com.Connection = conexion;
                    com.CommandText = sql2;
                    com.CommandType = CommandType.Text;

                    aux += (com.ExecuteScalar() + " ");
                    com.Dispose();
                    conexion.Close();
                }
            }
            return aux;
        }

        // Metodo que devuelve todos los cursos que han sido registrados en la bbdd (cursos solicitados)
        public List<OfertaEN> mostrar_todas_ofertas()
        {
            List<OfertaEN> oferta = new List<OfertaEN>();

            int id_max = Last_ID();
            int id_min = Min_ID();
            for (int i = id_min; i < id_max; i++)
            {
                oferta.Add(mostrar_oferta(i));
            }
            return oferta;
        }

        public int Last_ID()
        {
            int id = 0;
            SqlDataReader dr;
            try
            {
                conex.Open();
                string operation = "Select max(idOferta) from oferta";
                SqlCommand com = new SqlCommand(operation, conex);
                dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    id = dr.GetInt32(0);
                    id++;
                }
                else
                    id = 1;
                dr.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conex.Close();
            }
            return id;
        }

        public int Min_ID()
        {
            int id = 0;
            SqlDataReader dr;
            try
            {
                conex.Open();
                string operation = "Select min(idOferta) from oferta";
                SqlCommand com = new SqlCommand(operation, conex);
                dr = com.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                    id = dr.GetInt32(0);
                else
                    id = 1;
                dr.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                conex.Close();
            }
            return id;
        }
    }
}

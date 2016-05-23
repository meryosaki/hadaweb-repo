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
    // Clase que gestiona la insercion y borrado de cursos solicitados por los clientes
    class CursoCAD
    {
        // En esta variable se almacenara el nombre de la bbdd para poder trabajar con ella mas adelante
        private String BDD;
        private CursoEN curso;
        private ArrayList AlmacenUsuarios;
        private SqlConnection conex;

        // Constructor de cursoCAD
        public CursoCAD(string bbdd = ""){
            // Se asigna la bbdd a la clase
            this.BDD = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString();
            conex = new SqlConnection(BDD);
            curso = new CursoEN();
           
        }

        // Metodo que inserta cursos en la bbdd 
        public void insertar_curso(CursoEN curso){
            // Aqui realizamos el insert en la bbdd
            this.curso = curso;
            DataSet bdvirtual = new DataSet();
            string operacion = "select * from curso";
            SqlDataAdapter da = new SqlDataAdapter(operacion, conex);
            da.Fill(bdvirtual, "curso");
            DataTable t = new DataTable();
            t = bdvirtual.Tables["curso"];
            DataRow nuevafila = t.NewRow();
            //nuevafila[0] = curso.IdCurso;
            nuevafila[1] = curso.Nombre;
            nuevafila[2] = curso.Descripcion;
            nuevafila[3] = curso.Valoracion;
            nuevafila[4] = curso.Precio;
            nuevafila[5] = curso.Duracion;
            nuevafila[6] = curso.Categoria;
            nuevafila[7] = curso.Avatar;
            nuevafila[8] = curso.PlazasOcupadas;
            nuevafila[9] = curso.PlazasDisponibles;
            nuevafila[10] = curso.F_inicio;
            nuevafila[11] = curso.Profesor;
            t.Rows.Add(nuevafila);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            da.Update(bdvirtual, "curso");

        }

        // Metodo que borra cursos de la bbdd 
        public void borrar_curso(int id){
            // Aqui realizamos el delete en la bbdd
            conex.Open();
            SqlCommand com = new SqlCommand("Delete from curso where idCurso = " + id, conex);
            com.ExecuteNonQuery();
            conex.Close();
        }

        // Metodo que actualiza los datos de un curso
        public void modificar_curso(CursoEN c){
            // Aqui realizamos el update en la bbdd
            SqlCommand com = new SqlCommand("update curso set descripcion = '" + c.Descripcion + "', valoracion =" + c.Valoracion + ", precio = " + c.Precio + ", duracion = " + c.Duracion + ", avatar = '" + c.Avatar + "', plazasOcupadas = " + c.PlazasOcupadas + ", plazasDisponibles = " + c.PlazasDisponibles + ", f_comienzo = '" + c.F_inicio + "', loImparte = " + c.Profesor + " where idCurso = " + c.IdCurso, conex);
        }

        // Metodo que muestra un curso en concreto a partir de un id, que identifica a los cursos
        public CursoEN mostrar_curso(int id)
        {
            SqlDataReader dr;
            CursoEN curso = new CursoEN();
            try
            {
                conex.Open();
                string operation = "Select * from usuario where idCurso = " + id;
                SqlCommand com = new SqlCommand(operation, conex);
                dr = com.ExecuteReader();
                dr.Read();

                curso.IdCurso = Int32.Parse(dr["idCurso"].ToString());
                curso.Descripcion = dr["descripcion"].ToString();
                curso.Valoracion = Int32.Parse(dr["valoracion"].ToString());
                curso.Precio = Int32.Parse(dr["precio"].ToString());
                curso.Duracion = Int32.Parse(dr["duracion"].ToString());
                curso.Categoria = dr["categoria"].ToString();
                curso.Avatar = dr["avatar"].ToString();
                curso.PlazasOcupadas = Int32.Parse(dr["PlazasOcupadas"].ToString());
                curso.PlazasDisponibles = Int32.Parse(dr["PlazasDisponibles"].ToString());
                curso.F_inicio = Convert.ToDateTime(dr["f_comienzo"].ToString());
                curso.Profesor = Int32.Parse(dr["loImparte"].ToString());
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
            return curso;

        }

        // Metodo que devuelve todos los cursos que han sido registrados en la bbdd (cursos solicitados)
        public List<CursoEN> mostrar_todos_cursos(){
            List<CursoEN> cursos = new List<CursoEN>();
            return cursos;
        }
    }
}

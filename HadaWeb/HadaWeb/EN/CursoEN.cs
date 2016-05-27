﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGrupalHADA
{
    public class CursoEN
    {
        private int idCurso;
        private string descripcion, nombre;
        private int plazasDisponibles;
        private int valoracion;
        private double precio;
        private int duracion;
        private Nullable<DateTime> f_inicio;
        private string categoria;
        private string avatar;
        private int plazasOcupadas;
        private int profesor;
        private CursoCAD curso_cad;
        
        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int PlazasDisponibles
        {
            get { return plazasDisponibles; }
            set { plazasDisponibles = value; }
        }
        public int Valoracion
        {
            get { return valoracion; }
            set { valoracion = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public Nullable<DateTime> F_inicio
        {
            get { return f_inicio; }
            set { f_inicio = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
        public int PlazasOcupadas
        {
            get { return plazasOcupadas; }
            set { plazasOcupadas = value; }
        }

        public int Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        public void asignar(int idCurso, string nombre, string descripcion, int plazasDisponibles, int valoracion, double precio, int duracion, Nullable<DateTime> f_inicio, string categoria, string avatar, int plazasOcupadas, int profesor)
        {
            this.idCurso = idCurso;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.plazasDisponibles = plazasDisponibles;
            this.valoracion = valoracion;
            this.precio = precio;
            this.duracion = duracion;
            this.f_inicio = f_inicio;
            this.categoria = categoria;
            this.avatar = avatar;
            this.plazasOcupadas = plazasOcupadas;
            this.profesor = profesor;
        }

        public CursoEN()
        {
            asignar(0, "", "", 0, 0, 0f, 0, null, "", "", 0, 0);
        }

        public CursoEN(int idCurso, string nombre, string descripcion, int plazasDisponibles, int valoracion, double precio, int duracion, Nullable<DateTime> f_inicio, string categoria, string avatar, int plazasOcupadas, int profesor)
        {
            asignar(idCurso, nombre, descripcion, plazasDisponibles, valoracion, precio, duracion, f_inicio, categoria, avatar, plazasOcupadas, profesor);
        }

        public void insertar_curso() { 
            try
            {
                curso_cad = new CursoCAD("bbddSQLhada");
                curso_cad.insertar_curso(this);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Curso: %s\n", e);
            }
        }

        public void borrar_curso()
        {
            try
            {
                curso_cad = new CursoCAD("bbddSQLhada");
                curso_cad.borrar_curso(idCurso);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Curso: %s\n", e);
            }
        }

        public void modificar_curso()
        {
            try
            {
                curso_cad = new CursoCAD("bbddSQLhada");
                curso_cad.modificar_curso(this);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Curso: %s\n", e);
            }
        }

        public void mostrar_curso()
        {
            try
            {
                curso_cad = new CursoCAD("bbddSQLhada");
                curso_cad.mostrar_curso(idCurso);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error creando Curso: %s\n", e);
            }
        }

        public string numEN(string a)
        {
            curso_cad = new CursoCAD("bbddSQLhada");
            return curso_cad.nombresCursosCAD(a);
        }

        public List<CursoEN> mostrar_todos_cursosEN()
        {
            try
            {
                curso_cad = new CursoCAD("bbddSQLhada");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error mostrando Cursos: %s\n", e);
            }
            return curso_cad.mostrar_todos_cursos();
        }
    }
}

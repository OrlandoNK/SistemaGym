using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class CategoriaProductoDAL : ConexionDAL
    {
        //metodo insertar CategoriaProducto
        public static void InsertarCliente(CategoriaProductoEntity CategoriaProducto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into CategoriaProducto(IDCategoria, Nombre, Descripcion)" +
                " values(@IDCategoria, @Nombre, @Descripcion,)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
   
            cmd.Parameters.AddWithValue("@nombre", CategoriaProducto.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", CategoriaProducto.Descripcion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar cliente
        public static void ActualizarCliente(CategoriaProductoEntity CategoriaProducto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update CategoriaProducto set IDCategoria =@idCategoria, Nombre=@idNombre, Descripcion=@Descripcion";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@Nombre", CategoriaProducto.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", CategoriaProducto.Descripcion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar cliente

        public static bool EliminarCliente(CategoriaProductoEntity CategoriaProducto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from CategoriaProducto where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idCategoria", CategoriaProducto.IDCategoria);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar CategoriaProducto
        public static DataTable MostrarCategoriaProducto()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From CategoriaProducto";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public DataTable BuscarID(CategoriaProductoEntity CategoriaProducto)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From CategoriaProducto where IDCliente= @idCategoria";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcategoria", CategoriaProducto.IDCategoria);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(CategoriaProductoEntity CategoriaProducto)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from CategoriaProducto " +
                 "Where Nombre Like '%' + @nombre + '%' or Descripcion Like '%' + @Descripcion + '%'";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idCategoria", CategoriaProducto.IDCategoria);
            cmd.Parameters.AddWithValue("@Nombre", CategoriaProducto.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", CategoriaProducto.Descripcion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;//metodo insertar CategoriaProducto
        }
            public static void InsertarCategoriaProducto(CategoriaProductoEntity Categoria)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();

                Conexion.Open();
                string insertar = "Insert into CategoriaProducto (IDCategoria, Nombre, Descripcion)" +
                    " values(@idCategoria, @Nombre, @Descripcion)";
                SqlCommand cmd = new SqlCommand(insertar, Conexion);
                cmd.Parameters.AddWithValue("@Nombre", Categoria.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Categoria.Descripcion);
                cmd.ExecuteNonQuery();
            }

            //metodo actualizar CategoriaProducto

            public static void ActualizarCategoriaProducto(CategoriaProductoEntity CategoriaProducto)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();

                Conexion.Open();
                string actualizar = "Update CategoriaProducto set IDCtegoria =@idCategoria, Nombre=@Nombre, Descripcion=@Descripcion";
                SqlCommand cmd = new SqlCommand(actualizar, Conexion);
                cmd.Parameters.AddWithValue("@Nombre", CategoriaProducto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", CategoriaProducto.Descripcion);
                cmd.ExecuteNonQuery();


            }
            //funcion eliminar CategoriaProducto

            public static bool EliminarCategoriaProducto(CategoriaProductoEntity CategoriaProducto)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();
                bool seElimino;



                Conexion.Open();
                string Eliminar = "Delete from CategoriaProducto where IDCategoria= @idCategoria";
                SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
                cmd.Parameters.AddWithValue("@idCategoria", CategoriaProducto.IDCategoria);
                seElimino = cmd.ExecuteNonQuery() > 0;
                return seElimino;

            }


            //metodo mostrar CategoriaProducto
            public static DataTable MostrarCategoria()
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();
                DataTable dt = new DataTable();
                Conexion.Open();
                string mostrar = "Select * From CategoriaProducto";
                SqlCommand cmd = new SqlCommand(mostrar, Conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


                return dt;

            }

            public static DataTable BuscarIDCategoria(CategoriaProductoEntity CategoriaProducto)
            {

                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();

                Conexion.Open();
                DataTable dt = new DataTable();
                string buscar = "Select * From CategoriaProducto where IDCliente= @idCategoria";
                SqlCommand cmd = new SqlCommand(buscar, Conexion);
                cmd.Parameters.AddWithValue("@idCategoriaProducto", CategoriaProducto.IDCategoria);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            //
            public static DataTable ObtenerCategoriaProducto(CategoriaProductoEntity CategoriaProducto)
            {

                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();

                Conexion.Open();
                DataTable dt = new DataTable();
                string obtenerValor = "Select * from CategoriaProducto " +
                     "Where IDCategoria Like '%' + @idCategoria + '%' or Nombre Like '%' + @nombre + '%' or Descripcion Like '%' + @Descripcio";
                SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
                cmd.Parameters.AddWithValue("@IdCategoria", CategoriaProducto.IDCategoria);
                cmd.Parameters.AddWithValue("@nombre", CategoriaProducto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", CategoriaProducto.Descripcion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

        }
    }


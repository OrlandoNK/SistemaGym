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
            public static void InsertarCategoriaProducto(CategoriaProductoEntity Categoria)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();

                Conexion.Open();
                string insertar = "Insert into CategoriaProductos(Nombre, Descripcion)" +
                    " values(@Nombre, @Descripcion)";
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
                string actualizar = "Update CategoriaProductos set Nombre=@Nombre, Descripcion=@Descripcion where IDCategoria = @IDCategoria";
                SqlCommand cmd = new SqlCommand(actualizar, Conexion);
                cmd.Parameters.AddWithValue("@Nombre", CategoriaProducto.Nombre);
               cmd.Parameters.AddWithValue("@IDCategoria", CategoriaProducto.IDCategoria);
               cmd.Parameters.AddWithValue("@Descripcion", CategoriaProducto.Descripcion);
                cmd.ExecuteNonQuery();


            }
            //funcion eliminar CategoriaProducto

            public static bool EliminarCategoriaProducto(int CategoriaProducto)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();
                bool seElimino;



                Conexion.Open();
                string Eliminar = "Delete from CategoriaProductos where IDCategoria= @idCategoria";
                SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
                cmd.Parameters.AddWithValue("@idCategoria", CategoriaProducto);
                seElimino = cmd.ExecuteNonQuery() > 0;
                return seElimino;

            }

        public static DataTable Mostrar()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select Nombre From CategoriaProductos";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        //metodo mostrar CategoriaProducto
        public static DataTable MostrarCategoria()
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();
                DataTable dt = new DataTable();
                Conexion.Open();
                string mostrar = "Select * From CategoriaProductos";
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
                string buscar = "Select * From CategoriaProductos where IDCategoria= @idCategoria";
                SqlCommand cmd = new SqlCommand(buscar, Conexion);
                cmd.Parameters.AddWithValue("@idCategoria", CategoriaProducto.IDCategoria);
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
                string obtenerValor = "Select * from CategoriaProductos " +
                     "Where Nombre Like '%' + @Nombre + '%' or Descripcion Like '%' + @Descripcion + '%' Order by Nombre";
                SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
                cmd.Parameters.AddWithValue("@Nombre", CategoriaProducto.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", CategoriaProducto.Descripcion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

        public static DataTable ObtenerByValor(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM CategoriaProductos WHERE Nombre LIKE @Busqueda OR Descripcion LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

    }
    }


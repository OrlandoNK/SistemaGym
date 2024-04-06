using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class InventarioDAL: ConexionDAL
    {
        //metodo insertar Inventario
        public static void InsertarInventario(InventarioEntity inventario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Inventario(IDInventario, NombreItems, Descripcion, Categoria, Ubicacion,Cantidad,EstatusItems)" +
                " values(@idinventario, @nombreitems, @descripcion,@categoria,@ubicacion,@cantidad, @estatusitems)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idinventario", inventario.IDInventario);
            cmd.Parameters.AddWithValue("@nombreitems", inventario.NombreItems);
            cmd.Parameters.AddWithValue("@descripcion", inventario.Descripcion);
            cmd.Parameters.AddWithValue("@categoria", inventario.Categoria);
            cmd.Parameters.AddWithValue("@ubicacion", inventario.Ubicacion);
            cmd.Parameters.AddWithValue("@cantidad", inventario.Cantidad);
            cmd.Parameters.AddWithValue("@statusitems", inventario.EstatusItems);
            cmd.ExecuteNonQuery();
        }
        
        //metodo actualizar Inventario
        public static void ActualizarInventario(InventarioEntity inventario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Inventario set NombreItems=@nombreitems, Decripcion=@descripcion " +
                "Categoria =@categoria, Ubicacion =@ubicacion,Cantidad =@cantidad where IDInventario= @idinventario ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idinventario", inventario.IDInventario);
            cmd.Parameters.AddWithValue("@nombreitems", inventario.NombreItems);
            cmd.Parameters.AddWithValue("@descripcion", inventario.Descripcion);
            cmd.Parameters.AddWithValue("@categoria", inventario.Categoria);
            cmd.Parameters.AddWithValue("@ubicacion", inventario.Ubicacion);
            cmd.Parameters.AddWithValue("@cantidad", inventario.Cantidad);
            cmd.Parameters.AddWithValue("@statusitems", inventario.EstatusItems);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar Inventario

        public static bool EliminarInventario(InventarioEntity inventario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Inventario where IDInventario= @idinventario ";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idinventario", inventario.IDInventario);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }
        //metodo mostrar Inventario
        public static DataTable MostrarInventario()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Inventario ";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        public static DataTable BuscarID(InventarioEntity inventario)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Inventario where IDInventario= @idinventario ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idinventario", inventario.IDInventario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static DataTable ObtenerPorValor(InventarioEntity inventario)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from Inventario " +
                 "Where NombreItems Like '%' + @nombreitems + '%' or " +
                 "Descripcion Like '%' + @descripcion +'%' or Categoria Like '%' + @categoria +'%' or Ubicacion Like '%' + @ubicacion + '%' or Cantidad Like '%' + @cantidad +'%' or EstatusItems Like '%' + @estatusitems + '%' Order By NombresItems";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@nombreitems", inventario.NombreItems);
            cmd.Parameters.AddWithValue("@descripcion", inventario.Descripcion);
            cmd.Parameters.AddWithValue("@categoria", inventario.Categoria);
            cmd.Parameters.AddWithValue("@ubicacion", inventario.Ubicacion);
            cmd.Parameters.AddWithValue("@cantidad", inventario.Cantidad);
            cmd.Parameters.AddWithValue("@statusitems", inventario.EstatusItems);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}

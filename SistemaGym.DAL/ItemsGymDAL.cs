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
    public class ItemsGym : ConexionDAL
    {
        //metodo insertar ItemGym
        public static void InsertarItemsGym(ItemsGymEntity itemsGym)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into ItemsGym(Nombre, Cantidad," +
                " Precio, Descripcion)" +
                " values(@proveedor, @Nombre, @Cantidad, @Precio, @Descripcion)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@Proveedor", itemsGym.Proveedor);
            cmd.Parameters.AddWithValue("@Nombre", itemsGym.Nombre);
            cmd.Parameters.AddWithValue("@Cantidad", itemsGym.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", itemsGym.Precio);
            cmd.Parameters.AddWithValue("@Descripcion", itemsGym.Descripcion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar ItemGym
        public static void ActualizarItemsGym(ItemsGymEntity itemsGym)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update ItemsGym set Proveedor=@Proveedor, Nombre=@Nombre " +
                "Cantidad =@Cantidad, Precio=@Precio, Descripcion =@Descripcion ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@Proveedor", itemsGym.Proveedor);
            cmd.Parameters.AddWithValue("@Nombre", itemsGym.Nombre);
            cmd.Parameters.AddWithValue("@Cantidad", itemsGym.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", itemsGym.Precio);
            cmd.Parameters.AddWithValue("@Descripcion", itemsGym.Descripcion);
            cmd.ExecuteNonQuery();

        }
        //funcion eliminar ItemGym

        public static bool EliminarItemsGym(ItemsGymEntity itemsGym)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from IdItem where IDItem= @idItem";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idItem", itemsGym.IDItem);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar ItemGym
        public static DataTable MostrarItemsGym()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From ItemsGym";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public DataTable BuscarID(ItemsGymEntity ItemsGym)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From IdIten where IDItem= @idItem";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idItem", ItemsGym.IDItem);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(ItemsGymEntity itemsGym)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from ItemsGym " +
                 "Where Proveedor Like '%' + @Proveedor + '%' or Nombre Like '%' + @Nombre + '%' or " +
                 "Cantidad Like '%' + @Cantidad + '%' or Precio Like '%' + @Precio +'%' or Descripcion Like '%' + @Descripcion + '%' ";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@Proveedor", itemsGym.Proveedor);
            cmd.Parameters.AddWithValue("@Nombre", itemsGym.Nombre);
            cmd.Parameters.AddWithValue("@Cantidad", itemsGym.Cantidad);
            cmd.Parameters.AddWithValue("@Precio", itemsGym.Precio);
            cmd.Parameters.AddWithValue("@Descripcion",itemsGym.Descripcion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

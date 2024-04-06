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
    public class DetalleInventarioDal : ConexionDAL
    {
        //metodo insertar DetalleInventario
        public static void InsertarDetalleInventario(DetalleInventarioEntity detalleinventario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into DetalleInventario(IDDetalleInventario, NombreItems, Tipo, Kilo,Cantidad,Precio, Marca,Descripcion,Modelo,Estatus,FechaEntrada,FechaSalida)" +
                " values(@iddetalleinventario, @nombreitems, @tipo,@kilo,@cantidad,@precio,@marca,@descripcion, @estatus,fechaentrada,fechasalida)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@iddetalleinventario", detalleinventario.IDDetalleInventario);
            cmd.Parameters.AddWithValue("@nombreitems", detalleinventario.NombreItems);
            cmd.Parameters.AddWithValue("@tipo", detalleinventario.Tipo);
            cmd.Parameters.AddWithValue("@kilo", detalleinventario.Kilo);
            cmd.Parameters.AddWithValue("@cantidad", detalleinventario.Cantidad);
            cmd.Parameters.AddWithValue("@precio", detalleinventario.Precio);
            cmd.Parameters.AddWithValue("@marca", detalleinventario.Marca);
            cmd.Parameters.AddWithValue("@descripcion", detalleinventario.Descripcion);
            cmd.Parameters.AddWithValue("@estatus", detalleinventario.Estatus);
            cmd.Parameters.AddWithValue("@fechaentrada", detalleinventario.FechaEntrada);
            cmd.Parameters.AddWithValue("@fechasalida", detalleinventario.FechaSalida);
            cmd.ExecuteNonQuery();
        }
        //metodo actualizar DetalleInventario
        public static void ActualizarDetalleInventario(DetalleInventarioEntity detalleinventario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Inventario set NombreItems=@nombreitems, Tipo=@tipo " +
                "Kilo =@kilo,Cantidad =@cantidad, Precio =@precio,Marca =@marca,Descripcion=@descripcion,Estatus=@estatus,FechaEntrada=@fechaentrada,FechaSalida=@fechasalida where IDDetalleInventario= @iddetalleinventario ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@iddetalleinventario", detalleinventario.IDDetalleInventario);
            cmd.Parameters.AddWithValue("@nombreitems", detalleinventario.NombreItems);
            cmd.Parameters.AddWithValue("@tipo", detalleinventario.Tipo);
            cmd.Parameters.AddWithValue("@kilo", detalleinventario.Kilo);
            cmd.Parameters.AddWithValue("@cantidad", detalleinventario.Cantidad);
            cmd.Parameters.AddWithValue("@precio", detalleinventario.Precio);
            cmd.Parameters.AddWithValue("@marca", detalleinventario.Marca);
            cmd.Parameters.AddWithValue("@descripcion", detalleinventario.Descripcion);
            cmd.Parameters.AddWithValue("@estatus", detalleinventario.Estatus);
            cmd.Parameters.AddWithValue("@fechaentrada", detalleinventario.FechaEntrada);
            cmd.Parameters.AddWithValue("@fechasalida", detalleinventario.FechaSalida);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar DetalleInventario

        public static bool EliminarDetalleInventario(DetalleInventarioEntity detalleinventario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from DetalleInventario where IDDetalleInventario= @iddetalleinventario ";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@iddetalleinventario", detalleinventario.IDDetalleInventario);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }
        //metodo mostrar DetalleInventario
        public static DataTable MostrarDetalleInventario()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From DetalleInventario ";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        public static DataTable BuscarID(DetalleInventarioEntity detalleinventario)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From DetalleInventario where IDDetalleInventario= @iddetalleinventario ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@iddetalleinventario", detalleinventario.IDDetalleInventario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static DataTable ObtenerPorValor(DetalleInventarioEntity detalleinventario)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from DetalleInventario " +
                 "Where NombreItems Like '%' + @nombreitems + '%' or " +
                 "Tipo Like '%' + @tipo +'%' or Kilo Like '%' + @kilo +'%' or Cantidad Like '%' + @cantidad + '%' or Precio Like '%' + @precio + '%' or Marca Like '%' + @marca + '%' or Descripcion Like '%' + @descripcion + '%' or Estatus Like '%' + @estatus'%' or FechaEntrada Like '%' + @fechaentrada + or FechaSalida Like '%' + @fechasalida + '%' Order By NombresItems";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@nombreitems", detalleinventario.NombreItems);
            cmd.Parameters.AddWithValue("@tipo", detalleinventario.Tipo);
            cmd.Parameters.AddWithValue("@kilo", detalleinventario.Kilo);
            cmd.Parameters.AddWithValue("@cantidad", detalleinventario.Cantidad);
            cmd.Parameters.AddWithValue("@precio", detalleinventario.Precio);
            cmd.Parameters.AddWithValue("@marca", detalleinventario.Marca);
            cmd.Parameters.AddWithValue("@descripcion", detalleinventario.Descripcion);
            cmd.Parameters.AddWithValue("@estatus", detalleinventario.Estatus);
            cmd.Parameters.AddWithValue("@fechaentrada", detalleinventario.FechaEntrada);
            cmd.Parameters.AddWithValue("@fechasalida", detalleinventario.FechaSalida);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

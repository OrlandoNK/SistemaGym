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
    public class TiposActividadesDAL : ConexionDAL
    {
        //metodo insertar TiposActividades
        public static void InsertarCliente(TiposActividadesEntity TiposActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into TiposActividades(IDTiposActividades, Nombre, Descripcion,) " +
                " values(@idtiposactividades,  @nombre, @descripcion ) ";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", TiposActividades.IDTiposActividades);
            cmd.Parameters.AddWithValue("@nombre", TiposActividades.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", TiposActividades.Descripcion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar TiposActividades
        public static void ActualizarCliente(TiposActividadesEntity TiposActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update  TiposActividades set IDTiposActividades =@idtiposactividades, Nombre=@nombre, Descripcion =@descripcion ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", TiposActividades.IDTiposActividades);
            cmd.Parameters.AddWithValue("@nombre", TiposActividades.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", TiposActividades.Descripcion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar TiposActividades

        public static bool EliminarCliente(TiposActividadesEntity TiposActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from TiposActividades where IDTiposActividades= @idtiposactividades ";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", TiposActividades.IDTiposActividades);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar TiposActividades
        public static DataTable MostrarTiposActividades()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From TiposActividades Order By Nombre ";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(TiposActividadesEntity TiposActividades)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From TiposActividades where IDTiposActividades= @idtiposactividades ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", TiposActividades.IDTiposActividades);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(TiposActividadesEntity TiposActividades)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from TiposActividades " +
                 "Where IDTiposActividades Like '%' + @idtiposactividades + '%' or Nombre Like '%' + @nombre + '%' or Descripcion '%' + @descripcion + '%' or ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", TiposActividades.IDTiposActividades);
            cmd.Parameters.AddWithValue("@nombre", TiposActividades.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", TiposActividades.Descripcion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

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
        public static void InsertarTiposActividades(TiposActividadesEntity tiposActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into TiposActividades(Nombre, Descripcion,) " +
                " values(@nombre, @descripcion ) ";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", tiposActividades.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", tiposActividades.Descripcion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar TiposActividades
        public static void ActualizarTiposActividades(TiposActividadesEntity tiposActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update TiposActividades set Nombre=@nombre, Descripcion =@descripcion ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", tiposActividades.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", tiposActividades.Descripcion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar TiposActividades

        public static bool EliminarTiposActividades(TiposActividadesEntity tiposActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;
            Conexion.Open();
            string Eliminar = "Delete from TiposActividades where IDTipoActividad= @idtipoactividad ";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idtipoactividad", tiposActividades.IDTipoActividad);
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

        public static DataTable BuscarID(TiposActividadesEntity tiposActividades)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From TiposActividades where IDTipoActividad= @idtipoactividad ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", tiposActividades.IDTipoActividad);
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
                 "Where Nombre Like '%' + @nombre + '%' or Descripcion '%' + @descripcion + '%' or ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@nombre", TiposActividades.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", TiposActividades.Descripcion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

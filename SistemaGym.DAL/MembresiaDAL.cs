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
    public class MembresiaDAL : ConexionDAL
    {
        //metodo insertar membresia
        public static void InsertarMembresia(MembresiaEntity membresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Membresia(Nombre, Descripcion, Duracion, Valor , FechaCreacion, Estatus)" +
                " values(@nombre, @descripcion, @duracion, @valor, @fechacreacion, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", membresia.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", membresia.Descripcion);
            cmd.Parameters.AddWithValue("@duracion", membresia.Duracion);
            cmd.Parameters.AddWithValue("@valor", membresia.Valor);
            cmd.Parameters.AddWithValue("@fechacreacion", membresia.FechaCreacion);
            cmd.Parameters.AddWithValue("@estatus", membresia.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar membresia
        public static void ActualizarMembresia(MembresiaEntity membresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "UPDATE Membresia SET Nombre =@nombre, Descripcion =@descripcion, Duracion =@duracion, Valor =@valor, FechaCreacion =@fechacreacion, Estatus =@estatus WHERE IDMembresia= @idmembresia";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", membresia.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", membresia.Descripcion);
            cmd.Parameters.AddWithValue("@duracion", membresia.Duracion);
            cmd.Parameters.AddWithValue("@valor", membresia.Valor);
            cmd.Parameters.AddWithValue("@fechacreacion", membresia.FechaCreacion);
            cmd.Parameters.AddWithValue("@estatus", membresia.Estatus);
            cmd.Parameters.AddWithValue("@idmembresia", membresia.IDMembresia);
            cmd.ExecuteNonQuery();

        }
        //funcion eliminar membresia

        public static bool EliminarMembresia(int membresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string eliminar = "Delete from Membresia where IDMembresia= @idmembresia";
            SqlCommand cmd = new SqlCommand(eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", membresia);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar membresias
        public static DataTable MostrarMembresia()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Membresia";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        //buscar por id
        public static DataTable BuscarID(MembresiaEntity membresia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Membresia where IDMembresia= @idmembresia";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", membresia.IDMembresia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //obtener valor de la base de datos en tabla membresia
        public static DataTable ObtenerPorValor(MembresiaEntity membresia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from Membresia " +
                 "Where Nombre Like '%' + @nombre + '%' or Descripcion Like '%' + @descripcion + '%' or " +
                 "Descripcion Like '%' + @descripcion + '%' or Duracion Like '%' + @duracion + '%' or Valor Like '%' + @valor + '%' " +
                 " or FechaCreacion Like '%' + @fechacreacion + '%' or Estatus Like '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@nombre", membresia.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", membresia.Descripcion);
            cmd.Parameters.AddWithValue("@duracion", membresia.Duracion);
            cmd.Parameters.AddWithValue("@valor", membresia.Valor);
            cmd.Parameters.AddWithValue("@fechacreacion", membresia.FechaCreacion);
            cmd.Parameters.AddWithValue("@estatus", membresia.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}

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
    public class AsistenciaClientesDAL : ConexionDAL
    {
        //metodo insertar Asistencia
        public static void InsertarAsistencia(AsistenciaClientesEntity asistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into AsistenciaClientes(IDCliente, Asistencia, FechaAsistencia)" +
                " values(@idcliente, @asistencia, @fechaasistencia)";

            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", asistencia.IDCliente);
            cmd.Parameters.AddWithValue("@asistencia", asistencia.Asistencia);
            cmd.Parameters.AddWithValue("@fechaasistencia", asistencia.FechaAsistencia);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar Asistencia
        public static void ActualizarAsistencia(AsistenciaClientesEntity asistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update AsistenciaClientes Set IDCLiente =@idcliente, Asistencia =@asistencia, FechaAsistencia =@fechaasistencia where IDAsistenciaCliente= @idasistenciacliente ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idasistenciacliente", asistencia.IDAsistenciaCliente);
            cmd.Parameters.AddWithValue("@idcliente", asistencia.IDCliente);
            cmd.Parameters.AddWithValue("@asistencia", asistencia.Asistencia);
            cmd.Parameters.AddWithValue("@fechaasistencia", asistencia.FechaAsistencia);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar asistencia

        public static bool EliminarAsistencia(AsistenciaClientesEntity asistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from AsistenciaClientes where IDAsistenciaCliente= @idasistenciacliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idasistenciacliente", asistencia.IDAsistenciaCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar asistencia
        public static DataTable MostrarAsistencia()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From AsistenciaClientes Order By FechaAsistencia DESC";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(AsistenciaClientesEntity asistencia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From AsistenciaClientes where IDAsistenciaCliente =@idasistenciacliente";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idactividad", asistencia.IDAsistenciaCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(AsistenciaClientesEntity asistencia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from AsistenciaClientes " +
                 "Where IDCliente Like '%' + @idcliente + '%' or Asistencia Like '%' + @asistencia + '%' or FechaAsistecia '%' + @fechaasistencia + '%' Order By FechaAsistencia DESC";

            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", asistencia.IDCliente);
            cmd.Parameters.AddWithValue("@asistencia", asistencia.Asistencia);
            cmd.Parameters.AddWithValue("@fechaasistencia", asistencia.FechaAsistencia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

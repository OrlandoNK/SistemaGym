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
            string actualizar = "Update AsistenciaClientes Set IDCLiente =@idcliente, Asistencia =@asistencia, FechaAsistencia =@fechaasistencia";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", asistencia.IDCliente);
            cmd.Parameters.AddWithValue("@asistencia", asistencia.Asistencia);
            cmd.Parameters.AddWithValue("@fechaasistencia", asistencia.FechaAsistencia);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar asistencia

        public static bool EliminarActividad(ActividadesEntity actividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Actividades where IDActividad= @idactividad";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idactividad", actividades.IDActividad);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar asistencia
        public static DataTable MostrarActividades()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Actividades Order By Nombre";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(ActividadesEntity actividades)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Clientes where IDActividad =@idactividad";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idactividad", actividades.IDActividad);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(ActividadesEntity actividades)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from Actividades " +
                 "Where IDTipoActividades Like '%' + @idtipoactividades + '%' or Area Like '%' + @area + '%' or Nombre Like '%' + @nombre + '%' or " +
                 "EncargadoActividad Like '%' + @encargadoactividad + '%' or Dia Like '%' + @dia + '%' or HoraInicio Like '%' + @horainicio + '%' or " +
                 "HoraCierre Like '%' + @horacierre + '%' or Estatus Like '%' + @estatus + '%' Order By Nombre";

            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idtipoactividades", actividades.IDTipoActividades);
            cmd.Parameters.AddWithValue("@nombre", actividades.Nombre);
            cmd.Parameters.AddWithValue("@area", actividades.Area);
            cmd.Parameters.AddWithValue("@encargadoactividad", actividades.EncargadoActividad);
            cmd.Parameters.AddWithValue("@dia", actividades.Dia);
            cmd.Parameters.AddWithValue("@horainicio", actividades.HoraInicio);
            cmd.Parameters.AddWithValue("@horacierre", actividades.HoraCierre);
            cmd.Parameters.AddWithValue("@estatus", actividades.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

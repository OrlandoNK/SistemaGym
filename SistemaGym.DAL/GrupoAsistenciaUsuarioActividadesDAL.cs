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
    public class GrupoAsistenciaUsuarioActividadesDAL : ConexionDAL
    {
        //metodo insertar tipo GrupoUsuario
        public static void InsertarGrupoAsistenciaUsuario(GrupoAsistenciaUsuarioActividadesEntity grupoAsistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into GrupoAsistenciaUsuarioActividades(IDActividad, IDUsuario, Asistencia, Hora)" +
                " values(@idactividad, @idusuario, @asistencia, @hora)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idactividad", grupoAsistencia.IDActividad);
            cmd.Parameters.AddWithValue("@idusuario", grupoAsistencia.IDUsuario);
            cmd.Parameters.AddWithValue("@asistencia", grupoAsistencia.Asistencia);
            cmd.Parameters.AddWithValue("@hora", grupoAsistencia.Hora);


            cmd.ExecuteNonQuery();
        }

        //metodo actualizar grupo asistenciausuario
        public static void ActualizarGrupoAsistenciaUsuario(GrupoAsistenciaUsuarioActividadesEntity grupoAsistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update GrupoAsistenciaUsuarioActividades Set IDActividad =@actividad, IDUsuario =@idusuario, Asistencia =@asistencia, Hora =@hora";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idactividad", grupoAsistencia.IDActividad);
            cmd.Parameters.AddWithValue("@idusuario", grupoAsistencia.IDUsuario);
            cmd.Parameters.AddWithValue("@asistencia", grupoAsistencia.Asistencia);
            cmd.Parameters.AddWithValue("@hora", grupoAsistencia.Hora);
            cmd.ExecuteNonQuery();

        }
        //funcion eliminar grupo asistenciausuario

        public static bool EliminarGrupoAsistenciaUsuario(GrupoAsistenciaUsuarioActividadesEntity grupoAsistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from GrupoAsistenciaUsuarioActividades where IDGrupoAsistenciaUsuario= @idgrupoasistenciausuario";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciausuario", grupoAsistencia.ID);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar grupo asistenciausuario
        public static DataTable MostrarGrupoAsistenciaUsuario()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From GrupoAsistenciaUsuarioActividades";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        public static DataTable BuscarID(GrupoAsistenciaUsuarioActividadesEntity grupoAsistencia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From GrupoAsistenciaUsuarioActividades where IDGrupoAsistenciaUsuario= @idgrupoasistenciausuario";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciausuario", grupoAsistencia.ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(GrupoAsistenciaUsuarioActividadesEntity grupoAsistencia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from GrupoAsistenciaUsuarioActividades " +
                 "Where IDActividad Like '%' + @idactividad + '%' or IDUsuario Like '%' + @idusuario + '%' or " +
                 "Asistencia Like '%' + @asistencia + '%' or Hora Like '%' + @hora + '%' ORDER BY IDActividad";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

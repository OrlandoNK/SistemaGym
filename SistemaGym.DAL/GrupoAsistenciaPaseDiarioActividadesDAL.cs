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
    public class GrupoAsistenciaPaseDiarioActividadesDAL : ConexionDAL
    {
        //metodo insertar GrupoAsistenciaPaseDiarioActividades
        public static void InsertarCliente(GrupoAsistenciaPaseDiarioActividadesEntity grupoAsistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into GrupoAsistenciaPaseDiarioActividades(IDActividad, IDCliente, Asistencia," +
                " Hora, Monto)  " +
                " values(@idactividades, @idcliente, @asistencia, @hora, @monto) ";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
          
            cmd.Parameters.AddWithValue("@idactividad", grupoAsistencia.IDActividad);
            cmd.Parameters.AddWithValue("@idcliente", grupoAsistencia.IDCliente);
            cmd.Parameters.AddWithValue("@asistencia", grupoAsistencia.Asistencia);
            cmd.Parameters.AddWithValue("@hora", grupoAsistencia.Hora);
            cmd.Parameters.AddWithValue("@monto", grupoAsistencia.Monto);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar GrupoAsistenciaPaseDiarioActividades
        public static void ActualizarGrupoAsistenciaPaseDiario(GrupoAsistenciaPaseDiarioActividadesEntity grupoAsistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update GrupoAsistenciaPaseDiarioActividades set IDActividad=@actividades, IDCliente=@idcliente, " +
                "Asistencia =@asistencia, Hora=@hora, Monto =@monto ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idactividades", grupoAsistencia.IDActividades);
            cmd.Parameters.AddWithValue("@idcliente", grupoAsistencia.IDCliente);
            cmd.Parameters.AddWithValue("@asistencia", grupoAsistencia.Asistencia);
            cmd.Parameters.AddWithValue("@hora", grupoAsistencia.Hora);
            cmd.Parameters.AddWithValue("@monto", grupoAsistencia.Monto);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar GrupoAsistenciaPaseDiarioActividades

        public static bool EliminarGrupoAsistenciaPaseDiario(GrupoAsistenciaPaseDiarioActividadesEntity grupoAsistencia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from GrupoAsistenciaPaseDiarioActividades where IDGrupoAsistenciaPaseDiario= @idgrupoasistenciapasedirio";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciapasediario", grupoAsistencia.IDGrupoAsistenciaPaseDiario);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar GrupoAsistenciaPaseDiarioActividades
        public static DataTable MostrarGrupoAsistenciaPaseDiarioActividades()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From GrupoAsistenciaPaseDiarioActividades Order By Nombre ";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(GrupoAsistenciaPaseDiarioActividadesEntity GrupoAsistenciaPaseDiarioActividades)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From GrupoAsistenciaPaseDiarioActividades where IDGrupoAsistenciaPaseDiario= @idgrupoasistenciapasediario ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciapasediario", GrupoAsistenciaPaseDiarioActividades.IDGrupoAsistenciaPaseDiario);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(GrupoAsistenciaPaseDiarioActividadesEntity grupoAsistencia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from GrupoAsistenciaPaseDiarioActividades " +
                 "Where IDCliente Like '%' + @idcliente + '%' or IDActividad Like '%' + @actividad + '%' or " +
                 "Asistencia Like '%' + @asistencia '%' or Hora Like '%' + @hora + '%' or Monto Like '%' + @monto + '%' ";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
         
            cmd.Parameters.AddWithValue("@idactividad", grupoAsistencia.IDActividad);
            cmd.Parameters.AddWithValue("@idcliente", grupoAsistencia.IDCliente);
            cmd.Parameters.AddWithValue("@asistencia", grupoAsistencia.Asistencia);
            cmd.Parameters.AddWithValue("@hora", grupoAsistencia.Hora);
            cmd.Parameters.AddWithValue("@monto", grupoAsistencia.Monto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

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
        public static void InsertarCliente(GrupoAsistenciaPaseDiarioActividadesEntity GrupoAsistenciaPaseDiarioActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into GrupoAsistenciaPaseDiarioActividades (IDGrupoAsistenciaPaseDiarioActividades, IDCliente, IDActividades, Asistencia," +
                " Hora, Monto)  " +
                " values(@idgrupoasistenciapasadiarioactividades, @idcliente, @idactividades, @asistencia, @hora, @monto, ) ";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciapasadiarioactividades", GrupoAsistenciaPaseDiarioActividades.IDGrupoAsistenciaPaseDiarioActividades);
            cmd.Parameters.AddWithValue("@idcliente", GrupoAsistenciaPaseDiarioActividades.IDCliente);
            cmd.Parameters.AddWithValue("@idactividades", GrupoAsistenciaPaseDiarioActividades.IDActividades);
            cmd.Parameters.AddWithValue("@asistencia", GrupoAsistenciaPaseDiarioActividades.Asistencia);
            cmd.Parameters.AddWithValue("@hora", GrupoAsistenciaPaseDiarioActividades.Hora);
            cmd.Parameters.AddWithValue("@monto", GrupoAsistenciaPaseDiarioActividades.Monto);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar GrupoAsistenciaPaseDiarioActividades
        public static void ActualizarCliente(GrupoAsistenciaPaseDiarioActividadesEntity GrupoAsistenciaPaseDiarioActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update GrupoAsistenciaPaseDiarioActividades set IDGrupoAsistenciaPaseDiarioActividades =@idgrupoasistenciapasediarioactividades, IDCliente=@idcliente, IDActividades=@actividades " +
                "Asistencia =@asistencia, Hora=@hora, Monto =@monto ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciapasadiarioactividades", GrupoAsistenciaPaseDiarioActividades.IDGrupoAsistenciaPaseDiarioActividades);
            cmd.Parameters.AddWithValue("@idcliente", GrupoAsistenciaPaseDiarioActividades.IDCliente);
            cmd.Parameters.AddWithValue("@idactividades", GrupoAsistenciaPaseDiarioActividades.IDActividades);
            cmd.Parameters.AddWithValue("@asistencia", GrupoAsistenciaPaseDiarioActividades.Asistencia);
            cmd.Parameters.AddWithValue("@hora", GrupoAsistenciaPaseDiarioActividades.Hora);
            cmd.Parameters.AddWithValue("@monto", GrupoAsistenciaPaseDiarioActividades.Monto);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar GrupoAsistenciaPaseDiarioActividades

        public static bool EliminarCliente(GrupoAsistenciaPaseDiarioActividadesEntity GrupoAsistenciaPaseDiarioActividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from GrupoAsistenciaPaseDiarioActividades where IDGrupoAsistenciaPaseDiarioActividades= @idgrupoasistenciapasedirioactividades";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciapasediarioactividades", GrupoAsistenciaPaseDiarioActividades.IDGrupoAsistenciaPaseDiarioActividades);
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
            string buscar = "Select * From GrupoAsistenciaPaseDiarioActividades where IDGrupoAsistenciaPaseDiarioActividades= @idgrupoasistenciapasediarioactividades ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciapasediarioactividades", GrupoAsistenciaPaseDiarioActividades.IDGrupoAsistenciaPaseDiarioActividades);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(GrupoAsistenciaPaseDiarioActividadesEntity GrupoAsistenciaPaseDiarioActividades)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from GrupoAsistenciaPaseDiarioActividades " +
                 "Where IDGrupoAsistenciaPaseDiarioActividades Like '%' + @idgrupoclientepasediarioactividades + '%' or IDCliente Like '%' + @idcliente + '%' or IDActividades Like '%' + @actividades + '%' or " +
                 "Asistencia Like '%' + @asistencia '%' or Hora Like '%' + @hora + '%' or Monto Like '%' + @monto + '%' ";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idgrupoasistenciapasadiarioactividades", GrupoAsistenciaPaseDiarioActividades.IDGrupoAsistenciaPaseDiarioActividades);
            cmd.Parameters.AddWithValue("@idcliente", GrupoAsistenciaPaseDiarioActividades.IDCliente);
            cmd.Parameters.AddWithValue("@idactividades", GrupoAsistenciaPaseDiarioActividades.IDActividades);
            cmd.Parameters.AddWithValue("@asistencia", GrupoAsistenciaPaseDiarioActividades.Asistencia);
            cmd.Parameters.AddWithValue("@hora", GrupoAsistenciaPaseDiarioActividades.Hora);
            cmd.Parameters.AddWithValue("@monto", GrupoAsistenciaPaseDiarioActividades.Monto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

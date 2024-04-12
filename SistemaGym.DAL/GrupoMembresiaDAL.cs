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
    public class GrupoMembresiaDAL: ConexionDAL
    {
        //metodo insertar GrupoMembresia
        public static void InsertarGrupoMembresia(GrupoMembresiaEntity grupoMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into GrupoMembresia(IDMembresia, Nombre, MontoTotal, FechaRegistro, Estatus)" +
                " values(@idmembresia, @nombre, @MontoTotal, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", grupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@nombre", grupoMembresia.Nombre);
            cmd.Parameters.AddWithValue("@MontoTotal", grupoMembresia.MontoTotal);
            cmd.Parameters.AddWithValue("@fecharegistro", grupoMembresia.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", grupoMembresia.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar GrupoMembresia
        public static void ActualizarGrupoMembresia(GrupoMembresiaEntity grupoMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "UPDATE GrupoMembresia SET IDMembresia=@idmembresia, Nombre =@nombre, MontoTotal = @montoTotal, FechaRegistro =@fecharegistro, Estatus =@estatus where IDGrupoMembresia= @idgrupomembresia ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupomembresia", grupoMembresia.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idmembresia", grupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@nombre", grupoMembresia.Nombre);
            cmd.Parameters.AddWithValue("@montoTotal", grupoMembresia.MontoTotal);
            cmd.Parameters.AddWithValue("@fecharegistro", grupoMembresia.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", grupoMembresia.Estatus);
            cmd.ExecuteNonQuery();

        }
        //funcion eliminar GrupoMembresia

        public static bool EliminarGrupoMembresia(int grupoMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "DELETE FROM GrupoMembresia WHERE IDGrupoMembresia= @idgrupomembresia";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupomembresia", grupoMembresia);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar GrupoMembresia
        public static DataTable MostrarGrupoMembresia()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From GrupoMembresia";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        public static DataTable Buscar(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM GrupoMembresia WHERE Nombre LIKE @Busqueda OR IDMembresia LIKE @Busqueda OR Monto LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }
        public static DataTable BuscarID(GrupoMembresiaEntity grupoMembresia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From GrupoMembresia where IDGrupoMembresia= @idGrupoMembresia";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoMembresia", grupoMembresia.IDGrupoMembresia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(GrupoMembresiaEntity grupoMembresia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from GrupoMembresia " +
                 "Where IDMembresia Like '%' + @idmembresia + '%' or Nombre Like '%' + @nombre + '%' or FechaRegistro Like '%' + @FechaRegistro + '%' or Estatus Like '%' + @estatus + '%' " +
                " or Estatus Like '%' + @estatus ";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", grupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@nombre", grupoMembresia.Nombre);
            cmd.Parameters.AddWithValue("@FechaRegistro", grupoMembresia.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", grupoMembresia.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static GrupoMembresiaEntity GetByID(int Id)
        {
            GrupoMembresiaEntity grupoMembresia = null;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            string GetID = "SELECT * FROM GrupoMembresia WHERE IDGrupoMembresia = @IDGrupoMembresia";
            SqlCommand cmd = new SqlCommand(GetID, Conexion);
            cmd.Parameters.AddWithValue("@IDGrupoMembresia", Id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                grupoMembresia = ConvertToObject(reader);
            }
                    
            return grupoMembresia;
        }

        private static GrupoMembresiaEntity ConvertToObject(IDataReader reader)
        {
            GrupoMembresiaEntity grupoMembresia = new GrupoMembresiaEntity();

            grupoMembresia.IDGrupoMembresia = Convert.ToInt32(reader["IDGrupoMembresia"]);
            grupoMembresia.IDMembresia = Convert.ToInt32(reader["IDMembresia"]);
            grupoMembresia.Nombre = Convert.ToString(reader["Nombre"]);
            grupoMembresia.MontoTotal = Convert.ToDecimal(reader["MontoTotal"]);
            grupoMembresia.FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]);
            grupoMembresia.Estatus = Convert.ToString(reader["Estatus"]);

            return grupoMembresia;
        }
    }
}

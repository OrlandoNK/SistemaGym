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
            string insertar = "Insert into GrupoMembresia(IDMembresia, Nombre, FechaRegistro, Estatus)" +
                " values(@idmembresia, @nombre, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", grupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@nombre", grupoMembresia.Nombre);
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
            string actualizar = "Update GrupoMembresia set IDMembresia=@idmembresia, Nombre =@nombre, FechaRegistro =@fecharegistro, Estatus =@estatus where IDGrupoMembresia= @idgrupomembresia ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupomembresia", grupoMembresia.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idmembresia", grupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@nombre", grupoMembresia.Nombre);
            cmd.Parameters.AddWithValue("@fecharegistro", grupoMembresia.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", grupoMembresia.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar GrupoMembresia

        public static bool EliminarGrupoMembresia(GrupoMembresiaEntity grupoMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from GrupoMembresia where IDGrupoMembresia= @idgrupomembresia";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupomembresia", grupoMembresia.IDGrupoMembresia);
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
    }
}

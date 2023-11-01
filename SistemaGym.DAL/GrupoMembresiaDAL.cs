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
    public class GrupoMembresia : ConexionDAL
    {
        //metodo insertar GrupoMembresia
        public static void InsertarCliente(GrupoMembresiaEntity GrupoMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into GrupoMembresia(IDGrupoMembresia, IDMembresia, FechaRegistro, Estatus)" +
                " values(@idcliente, @idusuario, @idmembresia, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoMembresia", GrupoMembresia.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idmembresia", GrupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@fecharegistro", GrupoMembresia.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", GrupoMembresia.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar GrupoMembresia
        public static void ActualizarCliente(GrupoMembresiaEntity GrupoMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update GrupoMembresia set IDGrupoMembresia =@idGrupoMembresia, IDMembresia=@idmembresia, FechaRegistro =@fecharegistro, Estatus =@estatus ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoMembresia", GrupoMembresia.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idmembresia", GrupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@fecharegistro", GrupoMembresia.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", GrupoMembresia.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar GrupoMembresia

        public static bool EliminarCliente(GrupoMembresiaEntity GrupoMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from GrupoMembresia where IDGrupoMembresia= @idGrupoMembresia";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoMembresia", GrupoMembresia.IDGrupoMembresia);
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

        public static DataTable BuscarID(GrupoMembresiaEntity GrupoMembresia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From GrupoMembresia where IDGrupoMembresia= @idGrupoMembresia";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoMembresia", GrupoMembresia.IDGrupoMembresia);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(GrupoMembresiaEntity GrupoMembresia)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from GrupoMembresia " +
                 "Where IDGrupoMembresia Like '%' + @idGrupoMembresia + '%' or IDMembresia Like '%' + @idmembresia + '%' or FechaRegistro Like '%' + @FechaRegistro + '%' or Apellido Like '%' + @apellido + '%' or " +
                " or Estatus Like '%' + @estatus ";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoMembresia", GrupoMembresia.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idmembresia", GrupoMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@FechaRegistro", GrupoMembresia.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", GrupoMembresia.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

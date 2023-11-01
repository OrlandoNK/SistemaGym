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
    public class GrupoClienteDAL : ConexionDAL
    {
        //metodo insertar cliente
        public static void InsertarCliente(GrupoClienteEntity GrupoClienteDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into GruposCliente(IDGrupoCliente, IDGrupoMembresia, IdCliente, FechaRegistro, Estatus)" +
                " values(@idgrupocliente, @idgrupomembresia, @idcliente, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupocliente", GrupoClienteDAL.IDGrupoCliente);
            cmd.Parameters.AddWithValue("@idgrupomembresia", GrupoClienteDAL.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idcliente", GrupoClienteDAL.IDCliente);
            cmd.Parameters.AddWithValue("@fecharegistro", GrupoClienteDAL.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", GrupoClienteDAL.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar GrupoClienteDAL
        public static void ActualizarCliente(GrupoClienteEntity GrupoClienteDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update  GrupoClienteDAL set IDGrupoCliente =@idgrupocliente, IDGrupoMembresia=@idgrupomembresia, IDCliente=@idcliente " +
                " FechaRegistro =@fecharegistro, Estatus =@estatus ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoCliente", GrupoClienteDAL.IDGrupoCliente);
            cmd.Parameters.AddWithValue("@idgrupomembresia", GrupoClienteDAL.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idcliente", GrupoClienteDAL.IDCliente);
            cmd.Parameters.AddWithValue("@fecharegistro", GrupoClienteDAL.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", GrupoClienteDAL.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar GrupoClienteDAL

        public static bool EliminarCliente(GrupoClienteEntity GrupoClienteDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from GrupoClienteDAL where IDGrupoCliente= @idGrupoCliente ";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoCliente", GrupoClienteDAL.IDGrupoCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar GrupoCliente
        public static DataTable MostrarCliente()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Clientes Order By Nombre ";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(GrupoClienteEntity GrupoClienteDAL)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From GrupoCliente where IDGrupoCliente= @idGrupoCliente ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@GrupoCliente", GrupoClienteDAL.IDGrupoCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(GrupoClienteEntity GrupoClienteDAL)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from  " +
                 "Where IDGrupoMembresia Like '%' + @idgrupomembresia + '%' or IDcliente Like '%' + @idcliente + '%'" +
                 "FechaRegistro Like '%' + @FechaRegistro + '%' or Estatus Like '%' + @estatus + '%' ";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idgrupomembresia", GrupoClienteDAL.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idcliente", GrupoClienteDAL.IDCliente);
            cmd.Parameters.AddWithValue("@fecharegistro", GrupoClienteDAL.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", GrupoClienteDAL.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

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
        public static void InsertarGrupoCliente(GrupoClienteEntity grupoCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "INSERT INTO GrupoClientes(IDGrupoMembresia, IDCliente, Monto, FechaRegistro, Estatus)" +
                " values(@idgrupomembresia, @idcliente, @monto, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idgrupomembresia", grupoCliente.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idcliente", grupoCliente.IDCliente);
            cmd.Parameters.AddWithValue("@monto", grupoCliente.Monto);
            cmd.Parameters.AddWithValue("@fecharegistro", grupoCliente.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", grupoCliente.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar GrupoCliente
        public static void ActualizarGrupoCliente(GrupoClienteEntity grupoCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update GrupoClientes set IDGrupoMembresia=@idgrupomembresia, IDCliente=@idcliente, Monto = @monto, FechaRegistro =@fecharegistro, Estatus =@estatus where IDGrupoCliente= @idGrupoCliente ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoCliente", grupoCliente.IDGrupoCliente);
            cmd.Parameters.AddWithValue("@idgrupomembresia", grupoCliente.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idcliente", grupoCliente.IDCliente);
            cmd.Parameters.AddWithValue("@monto", grupoCliente.Monto);
            cmd.Parameters.AddWithValue("@fecharegistro", grupoCliente.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", grupoCliente.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar GrupoClienteDal

        public static bool EliminarCliente(int grupoCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "Delete from GrupoClientes where IDGrupoCliente= @idGrupoCliente ";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoCliente", grupoCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar GrupoCliente
        public static DataTable MostrarGrupoCliente()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From GrupoClientes ";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(GrupoClienteEntity grupoCliente)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From GrupoClientes where IDGrupoCliente= @idGrupoCliente ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idGrupoCliente", grupoCliente.IDGrupoCliente);
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
            string GetByValor = "SELECT * FROM GrupoClientes WHERE Monto LIKE @Busqueda OR IDCliente LIKE @Busqueda OR IDGrupoMembresia LIKE @Busqueda OR FechaRegistro LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

        //
        public static DataTable ObtenerPorValor(GrupoClienteEntity grupoCliente)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from GrupoClientes " +
                 "Where IDGrupoMembresia Like '%' + @idgrupomembresia + '%' or IDcliente Like '%' + @idcliente + '%' or " +
                 "FechaRegistro Like '%' + @FechaRegistro + '%' or Estatus Like '%' + @estatus + '%' Order By IDGrupoMembresia";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idgrupomembresia", grupoCliente.IDGrupoMembresia);
            cmd.Parameters.AddWithValue("@idcliente", grupoCliente.IDCliente);
            cmd.Parameters.AddWithValue("@fecharegistro", grupoCliente.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", grupoCliente.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

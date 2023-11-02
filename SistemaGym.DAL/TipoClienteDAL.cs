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
    public class TipoClienteDAL : ConexionDAL
    {
        //metodo insertar tipo cliente
        public static void InsertarTipoCliente(TipoClienteEntity tipoCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into TipoCliente(Nombre, Descripcion, FechaCreacion)" +
                " values(@nombre, @descripcion, @fechacreacion)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", tipoCliente.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", tipoCliente.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", tipoCliente.FechaCreacion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar tipocliente
        public static void ActualizarTipoCliente(TipoClienteEntity tipoCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update TipoCliente set Nombre =@nombre, Descripcion =@descripcion, FechaCreacion =@fechacreacion";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", tipoCliente.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", tipoCliente.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", tipoCliente.FechaCreacion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar tipocliente

        public static bool EliminarTipoCliente(TipoClienteEntity tipoCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from TipoCliente where IDTipoCliente= @idtipocliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idtipocliente", tipoCliente.IDTipoCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar tipocliente
        public static DataTable MostrarTipoCliente()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Clientes Order By Nombre";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

    }
}

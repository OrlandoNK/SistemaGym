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
            string actualizar = "UPDATE TipoCliente SET Nombre =@nombre, Descripcion =@descripcion, FechaCreacion =@fechacreacion WHERE IDTipoCliente = @idtipocliente";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", tipoCliente.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", tipoCliente.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", tipoCliente.FechaCreacion);
            cmd.Parameters.AddWithValue("@idtipocliente", tipoCliente.IDTipoCliente);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar tipocliente

        public static bool EliminarTipoCliente(int tipoCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "DELETE FROM TipoCliente WHERE IDTipoCliente= @idtipocliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idtipocliente", tipoCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }

        public static DataTable Buscar(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM TipoCliente WHERE Nombre LIKE @Busqueda OR Descripcion LIKE @Busqueda OR FechaCreacion LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

        //metodo mostrar tipocliente
        public static DataTable MostrarTipoCliente()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From TipoCliente";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

    }
}

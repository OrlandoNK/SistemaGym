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
    public class TipoListaClienteDAL : ConexionDAL
    {
        //metodo insertar tipo lista cliente
        public static void InsertarTipoListaCliente(TipoListaClienteEntity tipoListaCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into TipoListaCliente(Nombre, Descripcion)" +
                " values(@nombre, @descripcion)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", tipoListaCliente.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", tipoListaCliente.Descripcion);
           
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar tipolistacliente
        public static void ActualizarTipoListaCliente(TipoListaClienteEntity tipoListaCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update TipoListaCliente set Nombre =@nombre, Descripcion =@descripcion";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", tipoListaCliente.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", tipoListaCliente.Descripcion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar tipo listacliente

        public static bool EliminarTipoListaCliente(TipoListaClienteEntity tipoListaCliente)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from TipoListaCliente where IDTipoListaCliente= @idtipolistacliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idtipolistacliente", tipoListaCliente.IDTipoListaCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar tipo lista cliente
        public static DataTable MostrarTipoListaCliente()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From TipoListaCliente";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
    }
}

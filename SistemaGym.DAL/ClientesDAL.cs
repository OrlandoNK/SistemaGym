using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.Entities;
namespace SistemaGym.DAL
{
    public class ClientesDAL : ConexionDAL
    {

          
      
            

        
        public static void InsertarCliente(ClientesEntity clientes )
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            
            Conexion.Open();
            string insertar = "Insert into Clientes(IDUsuario, IDMembresia, TipoListaCliente, TipoCliente," +
                " Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus)" +
                " values(@idcliente, @idusuario, @idmembresia, @idtipolistacliente, @tipocliente, @nombre, @apellido " +
                "@tipodocumento, @documento, @direccion, @telcell, @telres, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand( insertar, Conexion );
            cmd.Parameters.AddWithValue("@idusuario", clientes.IDUsuario);
            cmd.Parameters.AddWithValue("@idmembresia", clientes.IDMembresia);
            cmd.Parameters.AddWithValue("@tipolistacliente", clientes.TipoListaCliente);
            cmd.Parameters.AddWithValue("@tipocliente", clientes.TipoCliente);
            cmd.Parameters.AddWithValue("@nombre", clientes.Nombre);
            cmd.Parameters.AddWithValue("@apellido", clientes.Apellido);
            cmd.Parameters.AddWithValue("@tipodocumento", clientes.TipoDocumento);
            cmd.Parameters.AddWithValue("@documento", clientes.Documento);
            cmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            cmd.Parameters.AddWithValue("@telcell", clientes.TelCell);
            cmd.Parameters.AddWithValue("@telres", clientes.TelRes);
            cmd.Parameters.AddWithValue("@fecharegistro", clientes.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", clientes.Estatus);
            cmd.ExecuteNonQuery();    
        }

        public static void ActualizarCliente(ClientesEntity clientes)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            
            Conexion.Open();
            string actualizar = "Update Clientes set IDUsuario =@idusuario, IDMembresia=@idmembresia, TipoListaCliente=@tipolistacliente " +
                "TipoCliente =@tipocliente, Nombre=@nombre, Apellido =@apellido, TipoDocumento=@tipodocumento, documento=@documento " +
                "Direccion =@direccion, Telcell=@telcell, TelRes=@telres, FechaRegistro =@fecharegistro, Estatus =@estatus ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idusuario", clientes.IDUsuario);
            cmd.Parameters.AddWithValue("@idmembresia", clientes.IDMembresia);
            cmd.Parameters.AddWithValue("@tipolistacliente", clientes.TipoListaCliente);
            cmd.Parameters.AddWithValue("@tipocliente", clientes.TipoCliente);
            cmd.Parameters.AddWithValue("@nombre", clientes.Nombre);
            cmd.Parameters.AddWithValue("@apellido", clientes.Apellido);
            cmd.Parameters.AddWithValue("@tipodocumento", clientes.TipoDocumento);
            cmd.Parameters.AddWithValue("@documento", clientes.Documento);
            cmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            cmd.Parameters.AddWithValue("@telcell", clientes.TelCell);
            cmd.Parameters.AddWithValue("@telres", clientes.TelRes);
            cmd.Parameters.AddWithValue("@fecharegistro", clientes.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", clientes.Estatus);
            cmd.ExecuteNonQuery();


        }


         public bool EliminarCliente (int id ) 
        {
            bool seElimino;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Eliminar = "Delete from Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idusuario", id);
            seElimino = cmd.ExecuteNonQuery() > 0 ;
            return seElimino;

        }


        

    }
}

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
      //metodo insertar cliente
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

        //metodo actualizar cliente
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
        //funcion eliminar cliente

        public static bool EliminarCliente(ClientesEntity clientes) 
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            

            Conexion.Open();
            string Eliminar = "Delete from Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            seElimino = cmd.ExecuteNonQuery() > 0 ;
            return seElimino;

        }
        

        //metodo mostrar cliente
        public static DataTable MostrarCliente()
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

        public static DataTable BuscarID(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from Clientes " +
                 "Where IDMembresia Like '%' + @idmembresia + '%' or Nombre Like '%' + @nombre + '%' or Apellido Like '%' + @apellido + '%' or " +
                 "Documento Like '%' + @Documento '%' or Direccion Like '%' + @Direccion + '%' or TelCell Like '%' + @telcell + '%' " +
                 "TelRes Like '%' + @telres + '%' or Estatus Like '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", clientes.IDMembresia);           
            cmd.Parameters.AddWithValue("@nombre", clientes.Nombre);
            cmd.Parameters.AddWithValue("@apellido", clientes.Apellido);
            cmd.Parameters.AddWithValue("@documento", clientes.Documento);
            cmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            cmd.Parameters.AddWithValue("@telcell", clientes.TelCell);
            cmd.Parameters.AddWithValue("@telres", clientes.TelRes);
            cmd.Parameters.AddWithValue("@estatus", clientes.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static ClientesEntity GetById(int IdCliente)
        {
            ClientesEntity cliente = null;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string query = "SELECT * FROM Clientes WHERE IDCliente = @IDCliente";
            using (SqlCommand cmd = new SqlCommand(query, Conexion))
            {
                cmd.Parameters.AddWithValue("@IDCliente", IdCliente);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = ConvertToMembresiaObject(reader);
                    }
                }
                return cliente;
            }
        }


        private static ClientesEntity ConvertToMembresiaObject(IDataReader reader)
        {
            ClientesEntity clientes = new ClientesEntity();

            clientes.IDCliente = Convert.ToInt32(reader["IDCliente"]);
            clientes.Nombre = Convert.ToString(reader["Nombre"]);
            clientes.Documento = Convert.ToString(reader["Documento"]);
            clientes.TipoDocumento = Convert.ToString(reader["TipoDocumento"]);

            return clientes;
        }

    }
}

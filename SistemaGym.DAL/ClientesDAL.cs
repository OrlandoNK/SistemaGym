﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            string insertar = "INSERT INTO Clientes(IDUsuario, IDMembresia, TipoListaCliente, TipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus) VALUES(@idusuario, @idmembresia, @idtipolistacliente, @idtipocliente, @nombre, @apellido, @tipodocumento, @documento, @direccion, @telcell, @telres, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand( insertar, Conexion );
            cmd.Parameters.AddWithValue("@idusuario", clientes.IDUsuario);
            cmd.Parameters.AddWithValue("@idmembresia", clientes.IDMembresia);
            cmd.Parameters.AddWithValue("@idtipolistacliente", clientes.TipoListaCliente);
            cmd.Parameters.AddWithValue("@idtipocliente", clientes.TipoCliente);
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
        public static void InsertarClientePaseDiario(ClientesEntity clientes)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "INSERT INTO Clientes(IDUsuario, TipoListaCliente, TipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus) VALUES(@idusuario, @idtipolistacliente, @idtipocliente, @nombre, @apellido, @tipodocumento, @documento, @direccion, @telcell, @telres, @fecharegistro, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idusuario", clientes.IDUsuario);
            cmd.Parameters.AddWithValue("@idtipolistacliente", clientes.TipoListaCliente);
            cmd.Parameters.AddWithValue("@idtipocliente", clientes.TipoCliente);
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
            string actualizar = "Update Clientes set IDUsuario =@idusuario, IDMembresia=@idmembresia, TipoListaCliente=@tipolistacliente, " +
                "TipoCliente =@tipocliente, Nombre=@nombre, Apellido =@apellido, TipoDocumento=@tipodocumento, documento=@documento, " +
                "Direccion =@direccion, Telcell=@telcell, TelRes=@telres, FechaRegistro =@fecharegistro, Estatus =@estatus where IDCliente = @idcliente";
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
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar cliente

        public static bool EliminarCliente(int clientes) 
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "Delete from Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes);
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
            string mostrar = "SELECT * FROM Clientes";
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
            string GetByValor = "SELECT * FROM Clientes WHERE Nombre LIKE @Busqueda OR Documento LIKE @Busqueda OR Telefono LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }
        public static DataTable GetClients()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "SELECT IDCliente, IDUsuario, IDMembresia, TipoListaCliente, TipoCliente, Nombre, Apellido, TipoDocumento, Documento, Direccion, TelCell, TelRes, FechaRegistro, Estatus FROM Clientes";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        /* public static DataTable BuscarID(int id)
         {

             ConexionDAL instancia = Instancia();
             SqlConnection Conexion = instancia.Conexion();

             Conexion.Open();
             DataTable dt = new DataTable();
             string buscar = "Select * From Clientes where IDCliente= @idcliente";
             SqlCommand cmd = new SqlCommand(buscar, Conexion);
             cmd.Parameters.AddWithValue("@idcliente", id);
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             return dt;
         }*/
        public static ClientesEntity BuscarPorID(int id)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string buscar = "SELECT * FROM Clientes WHERE IDCliente = @idcliente";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", id);

            SqlDataReader reader = cmd.ExecuteReader();
            ClientesEntity clienteEncontrado = null;

            if (reader.Read())
            {
                TipoClienteEntity tipoCliente = new TipoClienteEntity();
                clienteEncontrado = new ClientesEntity();
                clienteEncontrado.IDCliente = Convert.ToInt32(reader["IDCliente"]);
                clienteEncontrado.Nombre = reader["Nombre"].ToString();
                clienteEncontrado.Documento = reader["Documento"].ToString();
                clienteEncontrado.TipoCliente = Convert.ToInt32(reader["TipoCliente"]);

            }

            Conexion.Close();
            return clienteEncontrado;
        }
        //
        public static DataTable ObtenerPorValor(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "SELECT * FROM Clientes " +
                "WHERE IDMembresia LIKE '%' + @idmembresia + '%' OR " +
                "Nombre LIKE '%' + @nombre + '%' OR " +
                "Apellido LIKE '%' + @apellido + '%' OR " +
                "Documento LIKE '%' + @documento + '%' OR " +
                "Direccion LIKE '%' + @direccion + '%' OR " +
                "TelCell LIKE '%' + @telcell + '%' OR " +
                "TelRes LIKE '%' + @telres + '%' OR " +
                "Estatus LIKE '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", "%" + clientes.IDMembresia + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + clientes.Nombre + "%");
            cmd.Parameters.AddWithValue("@apellido", "%" + clientes.Apellido + "%");
            cmd.Parameters.AddWithValue("@documento", "%" + clientes.Documento + "%");
            cmd.Parameters.AddWithValue("@direccion", "%" + clientes.Direccion + "%");
            cmd.Parameters.AddWithValue("@telcell", "%" + clientes.TelCell + "%");
            cmd.Parameters.AddWithValue("@telres", "%" + clientes.TelRes + "%");
            cmd.Parameters.AddWithValue("@estatus", "%" + clientes.Estatus + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static ClientesEntity GetByID(int? Id)
        {
            ClientesEntity cliente = null;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            string GetID = "SELECT * FROM Clientes WHERE IDCliente = @IDCliente";
            SqlCommand cmd = new SqlCommand(GetID, Conexion);
            cmd.Parameters.AddWithValue("@IDCliente", Id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente = ConvertToObject(reader);
            }

            return cliente;
        }

        private static ClientesEntity ConvertToObject(IDataReader reader)
        {
            ClientesEntity cliente = new ClientesEntity();

            cliente.IDCliente = Convert.ToInt32(reader["IDCliente"]);
            cliente.Nombre = Convert.ToString(reader["Nombre"]);
            cliente.Apellido = Convert.ToString(reader["Apellido"]);
            cliente.TipoDocumento = Convert.ToString(reader["TipoDocumento"]);
            cliente.Documento = Convert.ToString(reader["Documento"]);
            cliente.Direccion = Convert.ToString(reader["Direccion"]);
            cliente.TelCell = Convert.ToString(reader["TelCell"]);
            cliente.TelRes = Convert.ToString(reader["TelRes"]);
            cliente.FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]);
            cliente.Estatus = Convert.ToString(reader["Estatus"]);


            return cliente;
        }

        public DataTable GetClientWithMembership(int idCliente)
        {
            DataTable DT = new DataTable();

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string GetMemberClient = @"SELECT C.*, M.Nombre as NombreMembresia, M.Descripcion, M.Valor 
                                 FROM Clientes C 
                                 LEFT JOIN Membresia M ON C.IDMembresia = M.IDMembresia 
                                 WHERE C.IDCliente = @IDCliente";
            using (SqlCommand cmd = new SqlCommand(GetMemberClient, Conexion))
            {
                cmd.Parameters.AddWithValue("@IDCliente", idCliente);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(DT);
            }

            return DT;
        }

        public DataTable GetClientWithCargos(int idCliente)
        {
            DataTable DT = new DataTable();

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string GetMemberClient = @"SELECT C.*, 
                M.Nombre as NombreMembresia, 
                M.Descripcion, 
                M.Valor,
                CC.IDCargoCredito,
                CC.Cargo as CargoCredito,
                CC.Monto as MontoCredito,
                CC.FechaCargo as FechaCargoCredito,
                CC.Estatus as EstatusCredito,
                CD.IDCargoDebito,
                CD.Cargo as CargoDebito,
                CD.Monto as MontoDebito,
                CD.FechaCargo as FechaCargoDebito,
                CD.Estatus as EstatusDebito
                FROM Clientes C 
                LEFT JOIN Membresia M ON C.IDMembresia = M.IDMembresia 
                LEFT JOIN CargoCredito CC ON C.IDCliente = CC.IDCliente
                LEFT JOIN CargoDebito CD ON C.IDCliente = CD.IDCliente
                WHERE C.IDCliente = @IDCliente";
            using (SqlCommand cmd = new SqlCommand(GetMemberClient, Conexion))
            {
                cmd.Parameters.AddWithValue("@IDCliente", idCliente);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(DT);
            }

            return DT;
        }

        public DataTable GetClientWithCargosAndGroups(int idCliente)
        {
            DataTable DT = new DataTable();

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string GetMemberClient = @"SELECT C.IDCliente, C.IDUsuario, C.IDMembresia, C.Nombre, C.Apellido, C.TipoDocumento, 
                C.Documento, C.Direccion, C.TelCell, C.TelRes, C.FechaRegistro, C.Estatus,
                M.Nombre as NombreMembresia, M.Descripcion, M.Valor,
                CC.IDCargoCredito, CC.Cargo as CargoCredito, CC.Monto as MontoCredito,
                CC.FechaCargo as FechaCargoCredito, CC.Estatus as EstatusCredito,
                CD.IDCargoDebito, CD.Cargo as CargoDebito, CD.Monto as MontoDebito,
                CD.FechaCargo as FechaCargoDebito, CD.Estatus as EstatusDebito,
                GC.IDGrupoCliente, GM.Nombre as NombreGrupoMembresia, GM.MontoTotal as MontoTotalGrupo,
                GC.Monto as MontoGrupoCliente, GC.FechaRegistro as FechaRegistroGrupo, 
                GC.Estatus as EstatusGrupo, 
                    COUNT(C.IDCliente) as ClientesActivos
                    FROM Clientes C 
                    LEFT JOIN Membresia M ON C.IDMembresia = M.IDMembresia 
                    LEFT JOIN CargoCredito CC ON C.IDCliente = CC.IDCliente
                    LEFT JOIN CargoDebito CD ON C.IDCliente = CD.IDCliente
                    LEFT JOIN GrupoClientes GC ON C.IDCliente = GC.IDCliente
                    INNER JOIN GrupoMembresia GM ON GC.IDGrupoMembresia = GM.IDGrupoMembresia
                    WHERE C.IDCliente = @IDCliente AND GC.Estatus = 'Activo'
                    GROUP BY C.IDCliente, C.IDUsuario, C.IDMembresia, C.Nombre, C.Apellido, C.TipoDocumento, 
                C.Documento, C.Direccion, C.TelCell, C.TelRes, C.FechaRegistro, C.Estatus,
                M.Nombre, M.Descripcion, M.Valor,
                CC.IDCargoCredito, CC.Cargo, CC.Monto, CC.FechaCargo, CC.Estatus,
                CD.IDCargoDebito, CD.Cargo, CD.Monto, CD.FechaCargo, CD.Estatus,
                GC.IDGrupoCliente, GM.Nombre, GM.MontoTotal, GC.Monto, GC.FechaRegistro, GC.Estatus";
            using (SqlCommand cmd = new SqlCommand(GetMemberClient, Conexion))
            {
                cmd.Parameters.AddWithValue("@IDCliente", idCliente);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(DT);
            }

            return DT;
        }



        public DataTable GetClientWithCargosAndGroupsMejorado(int idCliente)
        {
            DataTable DT = new DataTable();

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string GetMemberClient = @"SELECT C.IDCliente, C.IDUsuario, C.IDMembresia, C.Nombre, C.Apellido, C.TipoDocumento, 
       C.Documento, C.Direccion, C.TelCell, C.TelRes, C.FechaRegistro, C.Estatus,
       M.Nombre as NombreMembresia, M.Descripcion, M.Valor,
       CC.IDCargoCredito, CC.Cargo as CargoCredito, CC.Monto as MontoCredito,
       CC.FechaCargo as FechaCargoCredito, CC.Estatus as EstatusCredito,
       CD.IDCargoDebito, CD.Cargo as CargoDebito, CD.Monto as MontoDebito,
       CD.FechaCargo as FechaCargoDebito, CD.Estatus as EstatusDebito,
       GC.IDGrupoCliente, GM.IDGrupoMembresia, GM.Nombre as NombreGrupoMembresia,
       GM.MontoTotal as MontoTotalGrupo, GC.Monto as MontoGrupoCliente, 
       GC.FechaRegistro as FechaRegistroGrupo, GC.Estatus as EstatusGrupo,
       (SELECT COUNT(DISTINCT C2.IDCliente)
        FROM GrupoClientes GC2
        INNER JOIN Clientes C2 ON GC2.IDCliente = C2.IDCliente
        WHERE GC2.IDGrupoMembresia = GM.IDGrupoMembresia AND C2.Estatus = 'Activo') as ClientesActivos
FROM Clientes C 
LEFT JOIN Membresia M ON C.IDMembresia = M.IDMembresia 
LEFT JOIN CargoCredito CC ON C.IDCliente = CC.IDCliente
LEFT JOIN CargoDebito CD ON C.IDCliente = CD.IDCliente
LEFT JOIN GrupoClientes GC ON C.IDCliente = GC.IDCliente
INNER JOIN GrupoMembresia GM ON GC.IDGrupoMembresia = GM.IDGrupoMembresia
WHERE C.IDCliente = @IDCliente AND GC.Estatus = 'Activo'
GROUP BY C.IDCliente, C.IDUsuario, C.IDMembresia, C.Nombre, C.Apellido, C.TipoDocumento, 
         C.Documento, C.Direccion, C.TelCell, C.TelRes, C.FechaRegistro, C.Estatus,
         M.Nombre, M.Descripcion, M.Valor,
         CC.IDCargoCredito, CC.Cargo, CC.Monto, CC.FechaCargo, CC.Estatus,
         CD.IDCargoDebito, CD.Cargo, CD.Monto, CD.FechaCargo, CD.Estatus,
         GC.IDGrupoCliente, GM.IDGrupoMembresia, GM.Nombre, GM.MontoTotal, GC.Monto, GC.FechaRegistro, GC.Estatus";
            using (SqlCommand cmd = new SqlCommand(GetMemberClient, Conexion))
            {
                cmd.Parameters.AddWithValue("@IDCliente", idCliente);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DA.Fill(DT);
            }

            return DT;
        }
    }
}

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
    public class CargoCreditoDAL : ConexionDAL
    {
        //metodo insertar cliente
        public static void InsertarCargoCredito(CargoCreditoEntity cargoCredito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Clientes(IDCliente, Cargo, Monto, FechaCargo, Estatus)" +
                " values(@idcliente, @cargo, @monto, @fechacargo, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", cargoCredito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoCredito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoCredito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoCredito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoCredito.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar cliente
        public static void ActualizarCargoCredito(CargoCreditoEntity cargoCredito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Clientes set IDCliente =@idcliente, Cargo =@cargo, FechaCargo =@fechacargo, Estatus =@estatus";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", cargoCredito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoCredito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoCredito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoCredito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoCredito.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar cliente

        public static bool EliminarCargoCredito(CargoCreditoEntity cargoCredito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar cliente
        public static DataTable MostrarCargoCredito()
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

        public static DataTable BuscarID(CargoCreditoEntity cargoCredito)
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
        public static DataTable ObtenerPorValor(CargoCreditoEntity cargoCredito)
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
    }
}

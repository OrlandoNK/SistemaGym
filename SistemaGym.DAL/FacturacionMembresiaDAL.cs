using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class FacturacionMembresiaDAL : ConexionDAL
    {
        /* Metodo Insertar */

        public static void Insertar(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Insertar = "INSERT INTO FacturaMembresia(IDMembresia, IDCliente, IDUsuario, CargoCredito, CargoDebito, NCF, Valorfactura, FechaEmision, FechaVencimiento, Estatus) " +
                              " VALUES(@IDMembresia, @IDCliente, @IDUsuario, @CargoCredito, @CargoDebito, @NCF, @ValorFactura, @FechaEmision, @FechaVencimiento, @Estatus)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion);
            cmd.Parameters.AddWithValue("@IDMembresia", facturaMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@IDCliente", facturaMembresia.IDCliente);
            cmd.Parameters.AddWithValue("@IDUsuario", facturaMembresia.IDUsuario);
            cmd.Parameters.AddWithValue("@CargoCredito", facturaMembresia.CargoCredito);
            cmd.Parameters.AddWithValue("@CargoDebito", facturaMembresia.CargoDebito);
            cmd.Parameters.AddWithValue("@NCF", facturaMembresia.NCF);
            cmd.Parameters.AddWithValue("@ValorFactura", facturaMembresia.ValorFactura);
            cmd.Parameters.AddWithValue("@FechaEmision", facturaMembresia.FechaEmision);
            cmd.Parameters.AddWithValue("@FechaVencimiento", facturaMembresia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", facturaMembresia.Estatus);

            cmd.ExecuteNonQuery();

        }

        /* Metodo Actualizar */

        public static void Actualizar(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Actualizar = "UPDATE FacturaMembresia SET IDMembresia = @IDMembresia, IDCliente = @IDCliente, IDUsuario = @IDUsuario, NCF = @NCF, ValorFactura = @ValorFactura, FechaEmision = @FechaEmision, FechaVencimiento = @FechaVencimiento, Estatus = @Estatus Where IDFactura = @IDFactura";

            SqlCommand cmd = new SqlCommand(Actualizar, Conexion);
            cmd.Parameters.AddWithValue("@IDMembresia", facturaMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@IDCliente", facturaMembresia.IDCliente);
            cmd.Parameters.AddWithValue("@IDUsuario", facturaMembresia.IDUsuario);
            cmd.Parameters.AddWithValue("@CargoCredito", facturaMembresia.CargoCredito);
            cmd.Parameters.AddWithValue("@CargoDebito", facturaMembresia.CargoDebito);
            cmd.Parameters.AddWithValue("@NCF", facturaMembresia.NCF);
            cmd.Parameters.AddWithValue("@ValorFactura", facturaMembresia.ValorFactura);
            cmd.Parameters.AddWithValue("@FechaEmision", facturaMembresia.FechaEmision);
            cmd.Parameters.AddWithValue("@FechaVencimiento", facturaMembresia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", facturaMembresia.Estatus);

            cmd.Parameters.AddWithValue("@IDFactura", facturaMembresia.IDFactura);
            cmd.ExecuteNonQuery();

        }

        /* Metodo Eliminar */

        public static bool EliminarByID(int Id)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "DELETE FROM FacturaMembresia WHERE IDFactura = @IDFactura";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);

            cmd.Parameters.AddWithValue("@IDFactura", Id);
            seElimino = cmd.ExecuteNonQuery() > 0;

            return seElimino;

        }

        /* Metodo para Mostrar */

        public static DataTable Mostrar()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            DataTable dataTBL = new DataTable();

            Conexion.Open();

            string Mostrar = "SELECT * FROM FacturaMembresia ORDER BY IDFactura";
            SqlCommand cmd = new SqlCommand(Mostrar, Conexion);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
            adapterDT.Fill(dataTBL);

            return dataTBL;
        }

        /* Metodo para Mostrar Datos en Mantenimiento Factura Membresia */

        public static DataTable MostrarFacturaMembresia()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            DataTable dataTBL = new DataTable();

            Conexion.Open();

            string Mostrar = "SELECT IDMembresia, IDCliente, IDUsuario, CargoCredito, CargoDebito, NCF, Valorfactura, FechaEmision, FechaVencimiento, Estatus FROM FacturaMembresia";
            SqlCommand cmd = new SqlCommand(Mostrar, Conexion);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
            adapterDT.Fill(dataTBL);

            return dataTBL;
        }

        /* Metodo Buscar por ID */

        public static DataTable BuscarByID(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string Buscar = "SELECT * FROM FacturaMembresia WHERE IDFactura = @IDFactura";
            SqlCommand cmd = new SqlCommand(Buscar, Conexion);

            cmd.Parameters.AddWithValue("@IDFactura", facturaMembresia.IDFactura);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
            adapterDT.Fill(dataTBL);

            return dataTBL;

        }

        /* Metodo Obtener por Valor */

        public static DataTable ObtenerByValor(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM FacturaMembresia WHERE IDMembresia LIKE '%' + @IDMembresia + '%' or IDCliente LIKE '%' + @IDCliente + '%' or IDUsuario LIKE '%' + @IDUsuario + '%' or NCF LIKE '%' + @NCF + '%' or ValorFactura LIKE '%' + @ValorFactura + '%' or FechaEmision LIKE '%' + @FechaEmision + '%' or FechaVencimiento LIKE '%' + @FechaVencimiento + '%' or Estatus LIKE '%' + @Estatus + '%' ORDER BY IDFactura";
            SqlCommand cmd = new SqlCommand(GetByValor, Conexion);
            cmd.Parameters.AddWithValue("@IDMembresia", facturaMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@IDCliente", facturaMembresia.IDCliente);
            cmd.Parameters.AddWithValue("@IDUsuario", facturaMembresia.IDUsuario);
            cmd.Parameters.AddWithValue("@NCF", facturaMembresia.NCF);
            cmd.Parameters.AddWithValue("@FechaEmision", facturaMembresia.FechaEmision);
            cmd.Parameters.AddWithValue("@FechaVencimiento", facturaMembresia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", facturaMembresia.Estatus);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
            adapterDT.Fill(dataTBL);

            return dataTBL;

        }

    }
}

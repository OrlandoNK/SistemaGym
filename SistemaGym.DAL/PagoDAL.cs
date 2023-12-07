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
    public class PagoDAL : ConexionDAL
    {
        
        
            /* Metodo para Insertar Pago */
            public static void InsertarPago(PagoEntity pago)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = new SqlConnection();

                Conexion.Open();
                string Insertar = "INSERT INTO Pago (IDFacturaProductos, IDFacturaMembresia, MetodoPago, Monto,FechaPago,Estatus, ) VALUES(@idpago, @idfacturaproducto, @idfacturamembresia, @metodopago,@monto, @fechapago, @estatus )";
                SqlCommand cmd = new SqlCommand(Insertar, Conexion);
                cmd.Parameters.AddWithValue("@idfacturaproductos", pago.IDFacturaProductos);
                cmd.Parameters.AddWithValue("@idfacturamembresia", pago.IDFacturaMembresia);
                cmd.Parameters.AddWithValue("@metodopago", pago.MetodoPago);
                cmd.Parameters.AddWithValue("@monto", pago.Monto);
                cmd.Parameters.AddWithValue("@fechapago", pago.FechaPago);
                cmd.Parameters.AddWithValue("@estatus", pago.Estatus);
                cmd.ExecuteNonQuery();

            }

            /* Metodo para Actualizar Pago */

            public static void Update(PagoEntity pago)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = new SqlConnection();

                Conexion.Open();
                string UpdateProduct = "UPDATE Pago SET IDFacturaProductos = @idfacturaproductos, IDFacturaMembresia = @idfacturamembresia, MetodoPago = @metodopago, Monto = @monto, FechaPago = @fechapago, Estatus = @estatus";
                SqlCommand cmd = new SqlCommand(UpdateProduct, Conexion);
                cmd.Parameters.AddWithValue("@idfacturaproductos", pago.IDFacturaProductos);
                cmd.Parameters.AddWithValue("@idfacturamembresia", pago.IDFacturaMembresia);
                cmd.Parameters.AddWithValue("@metodopago", pago.MetodoPago);
                cmd.Parameters.AddWithValue("@monto", pago.Monto);
                cmd.Parameters.AddWithValue("@fechapago", pago.FechaPago);
                cmd.Parameters.AddWithValue("@estatus", pago.Estatus);
                cmd.ExecuteNonQuery();

            cmd.ExecuteNonQuery();

            }

            /* Metodo para Eliminar un Pago por ID */
            public static bool DeletePago(PagoEntity pago)
            {
                bool productDeleted;

                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = new SqlConnection();

                Conexion.Open();
                string Delete = "DELETE FROM Pago WHERE IDProducto = @IDPago";
                SqlCommand cmd = new SqlCommand(Delete, Conexion);
                cmd.Parameters.AddWithValue("@IDPago", pago.IDPago);
                productDeleted = cmd.ExecuteNonQuery() > 0;

                return productDeleted;

            }

            /* Metodo para Mostrar Pago */
            public static DataTable mostrarPago()
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = new SqlConnection();

                DataTable dataTBL = new DataTable();

                Conexion.Open();
                string Mostrar = "SELECT * FROM Pago Order by FechaPago DESC";
                SqlCommand cmnd = new SqlCommand(Mostrar, Conexion);
                SqlDataAdapter adapterDTBL = new SqlDataAdapter(cmnd);
                adapterDTBL.Fill(dataTBL);

                return dataTBL;
            }

            /* Metodo par Buscar por ID */
            public static DataTable BuscarByID(PagoEntity pago)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = new SqlConnection();

                Conexion.Open();
                DataTable dataTBL = new DataTable();

                string Buscar = "SELECT * FROM Pago WHERE IDPago = @IDPago";
                SqlCommand cmnd = new SqlCommand(Buscar, Conexion);
                cmnd.Parameters.AddWithValue("@IDPago", pago.IDPago);
                SqlDataAdapter adapterDTBL = new SqlDataAdapter(cmnd);
                adapterDTBL.Fill(dataTBL);

                return dataTBL;
            }

            /* Metodo Obtener por Valor */
            public static DataTable GetByValor(PagoEntity pago)
            {
                ConexionDAL instancia = Instancia();
                SqlConnection Conexion = new SqlConnection();

                Conexion.Open();
                DataTable dataTBL = new DataTable();
                string GetValor = "SELECT * FROM Pago " +
                                  "WHERE IDFacturaProductos LIKE '%' + @idfacturaproductos + '%' or IDFacturaMembresia LIKE '%' + @idfacturamembresia + '%' or MetodoPago LIKE '%' + @metodopago + '%' or Monto LIKE '%' + @monto + '%' or FechaPago LIKE '%' + @fechapago + '%' or Estatus LIKE '%' + @estatus + '%' ORDER BY FechaPago DESC";

                SqlCommand cmd = new SqlCommand(GetValor, Conexion);
                cmd.Parameters.AddWithValue("@idfacturaproductos", pago.IDFacturaProductos);
                cmd.Parameters.AddWithValue("@idfacturamembresia", pago.IDFacturaMembresia);
                cmd.Parameters.AddWithValue("@metodopago", pago.MetodoPago);
                cmd.Parameters.AddWithValue("@monto", pago.Monto);
                cmd.Parameters.AddWithValue("@fechapago", pago.FechaPago);
                cmd.Parameters.AddWithValue("@estatus", pago.Estatus);
            SqlDataAdapter adaptTBL = new SqlDataAdapter(cmd);
                adaptTBL.Fill(dataTBL);

                return dataTBL;
            }
        }
  }     

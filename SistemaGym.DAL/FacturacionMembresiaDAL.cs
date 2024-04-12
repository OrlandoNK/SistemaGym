using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
            SqlTransaction transaccion = Conexion.BeginTransaction();

            try
            {
                

            string Insertar = "INSERT INTO FacturaMembresia(IDMembresia, IDCliente, IDUsuario, CargoCredito, CargoDebito, NCF, Valorfactura, FechaEmision, FechaVencimiento, Estatus) " +
                              " VALUES(@IDMembresia, @IDCliente, @IDUsuario, @CargoCredito, @CargoDebito, @NCF, @ValorFactura, @FechaEmision, @FechaVencimiento, @Estatus)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion, transaccion);
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

                facturaMembresia.IDFactura = Convert.ToInt32(cmd.ExecuteScalar());
                string insertarPagoQuery = "INSERT INTO Pago(IDFacturaMembresia, MetodoPago, Monto, Pagado, Devuelta, FechaPago, Estatus) " +
       "VALUES(@idfacturamembresia, @metodopago, @monto, @pagado, @devuelta, @fechapago, @estatus); " +
       "SELECT SCOPE_IDENTITY();";

                SqlCommand cmdPago = new SqlCommand(insertarPagoQuery, Conexion, transaccion);

                foreach (var pago in facturaMembresia.Pagos)
                {
                    cmdPago.Parameters.Clear();
                 
                    cmdPago.Parameters.AddWithValue("@idfacturamembresia", facturaMembresia.IDFactura);
                    cmdPago.Parameters.AddWithValue("@metodopago", pago.MetodoPago);
                    cmdPago.Parameters.AddWithValue("@monto", pago.Monto);
                    cmdPago.Parameters.AddWithValue("@pagado", pago.Pagado);
                    cmdPago.Parameters.AddWithValue("@devuelta", pago.Devuelta);
                    cmdPago.Parameters.AddWithValue("@fechapago", pago.FechaPago);
                    cmdPago.Parameters.AddWithValue("@estatus", pago.Estatus);
                    pago.IDPago = Convert.ToInt32(cmdPago.ExecuteScalar());
                }


                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                Conexion.Close();
            }
        }
            
        public static void InsertarSinCargos(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
           
            SqlTransaction transaccion = Conexion.BeginTransaction();

            try
            {

                string Insertar = "INSERT INTO FacturaMembresia(IDMembresia, IDCliente, IDUsuario, NCF, Valorfactura, FechaEmision, FechaVencimiento, Estatus) " +
                              " VALUES(@IDMembresia, @IDCliente, @IDUsuario, @NCF, @ValorFactura, @FechaEmision, @FechaVencimiento, @Estatus)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion, transaccion);
            cmd.Parameters.AddWithValue("@IDMembresia", facturaMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@IDCliente", facturaMembresia.IDCliente);
            cmd.Parameters.AddWithValue("@IDUsuario", facturaMembresia.IDUsuario);
            cmd.Parameters.AddWithValue("@NCF", facturaMembresia.NCF);
            cmd.Parameters.AddWithValue("@ValorFactura", facturaMembresia.ValorFactura);
            cmd.Parameters.AddWithValue("@FechaEmision", facturaMembresia.FechaEmision);
            cmd.Parameters.AddWithValue("@FechaVencimiento", facturaMembresia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", facturaMembresia.Estatus);

                facturaMembresia.IDFactura = Convert.ToInt32(cmd.ExecuteScalar());

                string insertarPagoQuery = "INSERT INTO Pago(IDFacturaMembresia, MetodoPago, Monto, Pagado, Devuelta, FechaPago, Estatus) " +
       "VALUES(@idfacturamembresia, @metodopago, @monto, @pagado, @devuelta, @fechapago, @estatus); " +
       "SELECT SCOPE_IDENTITY();";

                SqlCommand cmdPago = new SqlCommand(insertarPagoQuery, Conexion, transaccion);

                foreach (var pago in facturaMembresia.Pagos)
                {
                    cmdPago.Parameters.Clear();
                    
                    cmdPago.Parameters.AddWithValue("@idfacturamembresia", facturaMembresia.IDFactura);
                    cmdPago.Parameters.AddWithValue("@metodopago", pago.MetodoPago);
                    cmdPago.Parameters.AddWithValue("@monto", pago.Monto);
                    cmdPago.Parameters.AddWithValue("@pagado", pago.Pagado);
                    cmdPago.Parameters.AddWithValue("@devuelta", pago.Devuelta);
                    cmdPago.Parameters.AddWithValue("@fechapago", pago.FechaPago);
                    cmdPago.Parameters.AddWithValue("@estatus", pago.Estatus);
                    pago.IDPago = Convert.ToInt32(cmdPago.ExecuteScalar());
                }


                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                Conexion.Close();
            }


        }
        public static void InsertarSoloCargoCredito(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            SqlTransaction transaccion = Conexion.BeginTransaction();

            try
            {
                string Insertar = "INSERT INTO FacturaMembresia(IDMembresia, IDCliente, IDUsuario, CargoCredito, NCF, Valorfactura, FechaEmision, FechaVencimiento, Estatus) " +
                              " VALUES(@IDMembresia, @IDCliente, @IDUsuario, @CargoCredito, @NCF, @ValorFactura, @FechaEmision, @FechaVencimiento, @Estatus)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion, transaccion);
            cmd.Parameters.AddWithValue("@IDMembresia", facturaMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@IDCliente", facturaMembresia.IDCliente);
            cmd.Parameters.AddWithValue("@IDUsuario", facturaMembresia.IDUsuario);
            cmd.Parameters.AddWithValue("@CargoCredito", facturaMembresia.CargoCredito);
            cmd.Parameters.AddWithValue("@NCF", facturaMembresia.NCF);
            cmd.Parameters.AddWithValue("@ValorFactura", facturaMembresia.ValorFactura);
            cmd.Parameters.AddWithValue("@FechaEmision", facturaMembresia.FechaEmision);
            cmd.Parameters.AddWithValue("@FechaVencimiento", facturaMembresia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", facturaMembresia.Estatus);

            facturaMembresia.IDFactura = Convert.ToInt32(cmd.ExecuteScalar());
            string insertarPagoQuery = "INSERT INTO Pago(IDFacturaMembresia, MetodoPago, Monto, Pagado, Devuelta, FechaPago, Estatus) " +
   "VALUES(@idfacturamembresia, @metodopago, @monto, @pagado, @devuelta, @fechapago, @estatus); " +
   "SELECT SCOPE_IDENTITY();";

            SqlCommand cmdPago = new SqlCommand(insertarPagoQuery, Conexion, transaccion);

            foreach (var pago in facturaMembresia.Pagos)
            {
                cmdPago.Parameters.Clear();
                
                cmdPago.Parameters.AddWithValue("@idfacturamembresia", facturaMembresia.IDFactura);
                cmdPago.Parameters.AddWithValue("@metodopago", pago.MetodoPago);
                cmdPago.Parameters.AddWithValue("@monto", pago.Monto);
                cmdPago.Parameters.AddWithValue("@pagado", pago.Pagado);
                cmdPago.Parameters.AddWithValue("@devuelta", pago.Devuelta);
                cmdPago.Parameters.AddWithValue("@fechapago", pago.FechaPago);
                cmdPago.Parameters.AddWithValue("@estatus", pago.Estatus);
                pago.IDPago = Convert.ToInt32(cmdPago.ExecuteScalar());
            }


            transaccion.Commit();
        }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                Conexion.Close();
            }

        }
        public static void InsertarSoloCargoDebito(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

           

            Conexion.Open();

            SqlTransaction transaccion = Conexion.BeginTransaction();

            try
            {
                string Insertar = "INSERT INTO FacturaMembresia(IDMembresia, IDCliente, IDUsuario, CargoDebito, NCF, Valorfactura, FechaEmision, FechaVencimiento, Estatus) " +
                              " VALUES(@IDMembresia, @IDCliente, @IDUsuario, @CargoDebito, @NCF, @ValorFactura, @FechaEmision, @FechaVencimiento, @Estatus)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion, transaccion);
            cmd.Parameters.AddWithValue("@IDMembresia", facturaMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@IDCliente", facturaMembresia.IDCliente);
            cmd.Parameters.AddWithValue("@IDUsuario", facturaMembresia.IDUsuario);
            cmd.Parameters.AddWithValue("@CargoDebito", facturaMembresia.CargoDebito);
            cmd.Parameters.AddWithValue("@NCF", facturaMembresia.NCF);
            cmd.Parameters.AddWithValue("@ValorFactura", facturaMembresia.ValorFactura);
            cmd.Parameters.AddWithValue("@FechaEmision", facturaMembresia.FechaEmision);
            cmd.Parameters.AddWithValue("@FechaVencimiento", facturaMembresia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", facturaMembresia.Estatus);

                facturaMembresia.IDFactura = Convert.ToInt32(cmd.ExecuteScalar());
                string insertarPagoQuery = "INSERT INTO Pago(IDFacturaMembresia, MetodoPago, Monto, Pagado, Devuelta, FechaPago, Estatus) " +
       "VALUES(@idfacturamembresia, @metodopago, @monto, @pagado, @devuelta, @fechapago, @estatus); " +
       "SELECT SCOPE_IDENTITY();";

                SqlCommand cmdPago = new SqlCommand(insertarPagoQuery, Conexion, transaccion);

                foreach (var pago in facturaMembresia.Pagos)
                {
                    cmdPago.Parameters.Clear();
                   
                    cmdPago.Parameters.AddWithValue("@idfacturamembresia", facturaMembresia.IDFactura);
                    cmdPago.Parameters.AddWithValue("@metodopago", pago.MetodoPago);
                    cmdPago.Parameters.AddWithValue("@monto", pago.Monto);
                    cmdPago.Parameters.AddWithValue("@pagado", pago.Pagado);
                    cmdPago.Parameters.AddWithValue("@devuelta", pago.Devuelta);
                    cmdPago.Parameters.AddWithValue("@fechapago", pago.FechaPago);
                    cmdPago.Parameters.AddWithValue("@estatus", pago.Estatus);
                    pago.IDPago = Convert.ToInt32(cmdPago.ExecuteScalar());
                }


                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                Conexion.Close();
            }

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

        public static DataTable ObtenerByValor(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM FacturaMembresia WHERE IDMembresia LIKE @Busqueda OR IDCliente LIKE @Busqueda OR IDUsuario LIKE @Busqueda OR NCF LIKE @Busqueda OR ValorFactura LIKE @Busqueda OR FechaEmision LIKE @Busqueda OR FechaVencimiento LIKE @Busqueda OR Estatus LIKE @Busqueda ORDER BY IDFactura";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

        
        

    }
}

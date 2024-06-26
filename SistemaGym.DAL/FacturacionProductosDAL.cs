﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.Entities;
using System.Reflection.Metadata;
using System.Data.Entity.Core.Common.EntitySql;

namespace SistemaGym.DAL
{
    public class FacturacionProductosDAL : ConexionDAL
    {
      
        public static void InsertarFactura(FacturaProductoEntity factura)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            SqlTransaction transaccion = Conexion.BeginTransaction();

            try
            {
                string insertarFacturaQuery = "INSERT INTO FacturaProductos(IDCliente, IDUsuario, NCF, Subtotal, TotalDescuento, TotalItbis, Total, FechaEmision, FechaVencimiento, Estatus) " +
                    "VALUES(@idcliente, @idusuario, @ncf, @subtotal, @totaldescuento, @totalitbis, @total, @fechaemision, @fechavencimiento, @estatus); " +
                    "SELECT SCOPE_IDENTITY();"; // Obtener el ID generado para la factura

                SqlCommand cmd = new SqlCommand(insertarFacturaQuery, Conexion, transaccion);
                cmd.Parameters.AddWithValue("@idcliente", factura.IDCliente);
                cmd.Parameters.AddWithValue("@idusuario", factura.IDUsuario);
                cmd.Parameters.AddWithValue("@ncf", factura.NCF);
                cmd.Parameters.AddWithValue("@subtotal", factura.SubTotal);
                cmd.Parameters.AddWithValue("@totaldescuento", factura.TotalDescuento);
                cmd.Parameters.AddWithValue("@totalitbis", factura.TotalItbis);
                cmd.Parameters.AddWithValue("@total", factura.Total);
                cmd.Parameters.AddWithValue("@fechaemision", factura.FechaEmision);
                cmd.Parameters.AddWithValue("@fechavencimiento", factura.FechaVencimiento);
                cmd.Parameters.AddWithValue("@estatus", factura.Estatus);

                factura.IDFactura = Convert.ToInt32(cmd.ExecuteScalar());

                string insertarDetalleQuery = "INSERT INTO DetalleFacturaProductos(IDFacturaProducto, IDProducto, Precio, Cantidad, Subtotal, Descuento, Itbis, Total) " +
                    "VALUES(@idfacturaproducto, @idproducto, @precio, @cantidad, @subtotal, @descuento, @itbis, @total); " +
                    "SELECT SCOPE_IDENTITY();";

                SqlCommand cmddetalle = new SqlCommand(insertarDetalleQuery, Conexion, transaccion);

                foreach (var detalle in factura.Detalles)
                {
                    cmddetalle.Parameters.Clear();
                    cmddetalle.Parameters.AddWithValue("@idfacturaproducto", factura.IDFactura);
                    cmddetalle.Parameters.AddWithValue("@idproducto", detalle.IDProducto);
                    cmddetalle.Parameters.AddWithValue("@precio", detalle.Precio);
                    cmddetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmddetalle.Parameters.AddWithValue("@subtotal", detalle.SubTotal);
                    cmddetalle.Parameters.AddWithValue("@descuento", detalle.Descuento);
                    cmddetalle.Parameters.AddWithValue("@itbis", detalle.Itbis);
                    cmddetalle.Parameters.AddWithValue("@total", detalle.Total);
                    detalle.IDDetalleFacturaProducto = Convert.ToInt32(cmddetalle.ExecuteScalar());

                    ProductoDAL.ActualizarStock(detalle.IDProducto, detalle.Cantidad);

                }

                string insertarPagoQuery = "INSERT INTO Pago(IDFacturaProducto, MetodoPago, Monto, Pagado, Devuelta, FechaPago, Estatus) " +
           "VALUES(@idfacturaproducto, @metodopago, @monto, @pagado, @devuelta, @fechapago, @estatus); " +
           "SELECT SCOPE_IDENTITY();";

                SqlCommand cmdPago = new SqlCommand(insertarPagoQuery, Conexion, transaccion);

                foreach (var pago in factura.Pagos)
                {
                    cmdPago.Parameters.Clear();
                    cmdPago.Parameters.AddWithValue("@idfacturaproducto", factura.IDFactura);
                    cmdPago.Parameters.AddWithValue("@idfacturamembresia", pago.IDFacturaMembresia);
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
        public static void Actualizar(FacturaProductoEntity factura)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update FacturaProducto set IDCliente= @idcliente, IDUsuario= @idusuario, NCF= @ncf, SubTotal= @subtotal, TotalDescuento= @TotalDescuento, TotalItbis= @totalitbis, Total= @total, FechaEmision= @fechaemision, FechaVencimiento= @fechavencimiento, Estatus= @estatus where IDFactura = @idfactura";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", factura.IDCliente);
            cmd.Parameters.AddWithValue("@idusuario", factura.IDUsuario);
            cmd.Parameters.AddWithValue("@idfactura", factura.IDFactura);
            cmd.Parameters.AddWithValue("@ncf", factura.NCF);
            cmd.Parameters.AddWithValue("@subtotal", factura.SubTotal);
            cmd.Parameters.AddWithValue("@totaldescuento", factura.TotalDescuento);
            cmd.Parameters.AddWithValue("@totalitbis", factura.TotalItbis);
            cmd.Parameters.AddWithValue("@total", factura.Total);
            cmd.Parameters.AddWithValue("@fechaemision", factura.FechaEmision);
            cmd.Parameters.AddWithValue("@fechavencimiento", factura.FechaVencimiento);
            cmd.Parameters.AddWithValue("@estatus", factura.Estatus);
            cmd.ExecuteNonQuery();

        }
        

        public static DataTable Mostrar()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            Conexion.Open();

            string mostrar = "SELECT * FROM FacturaProductos ORDER BY FechaEmision DESC";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.Close();

            return dt;
        }
        public static DataTable MostrarDetalle()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            Conexion.Open();

            string mostrar = "SELECT * FROM DetalleFacturaProductos";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Conexion.Close();

            return dt;
        }
        public static DataTable GetByID(FacturaMembresiaEntity factura)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From FacturaProductos Where IDFactura = @idfactura ";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idfactura", factura.IDFactura);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
        public static bool EliminarByID(int Id)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "DELETE FROM FacturaProductos WHERE IDFactura = @IDFactura";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);

            cmd.Parameters.AddWithValue("@IDFactura", Id);
            seElimino = cmd.ExecuteNonQuery() > 0;

            return seElimino;

        }

        /* Metodo Buscar */

        public static DataTable Buscar(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM FacturaProductos WHERE IDCliente LIKE @Busqueda OR IDUsuario LIKE @Busqueda OR Subtotal LIKE @Busqueda OR Total LIKE @Busqueda OR FechaEmision LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

        public static bool Exist(int id)
        {
            ConexionDAL instancia = ConexionDAL.Instancia();
            SqlConnection Conexion = instancia.Conexion();
            Conexion.Open();
            string consulta = "SELECT COUNT(*) FROM FacturaProductos WHERE IDFactura = @IDFactura";
            SqlCommand cmd = new SqlCommand(consulta, Conexion);

            cmd.Parameters.AddWithValue("@IDFactura", id);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        public static void ConvertToObject(IDataReader reader)
        {

        }

    }

}





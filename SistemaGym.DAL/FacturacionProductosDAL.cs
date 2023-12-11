using System;
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
       /* public static void InsertarFactura(FacturaProductoEntity factura)
        {


            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            SqlTransaction transaccion = Conexion.BeginTransaction();
            try
            {
                string insertarfactura = "Insert Into FacturaProductos(IDCliente, IDUsuario, NCF, Subtotal, TotalDescuento, TotalItbis, Total, FechaEmision, FechaVencimiento, Estatus)" +
                " Values(@idcliente, @idusuario, @ncf, @subtotal, @totaldescuento, @totalitbis, @total, @fechaemision, @fechavencimiento, @estatus)";
                SqlCommand cmd = new SqlCommand(insertarfactura, Conexion);
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

                string insertardetalle = "Insert Into DetalleFacturaProductos(IDFacturaProducto, IDProducto, Precio, Cantidad, Subtotal, Descuento, Itbis, Total)" +
                " Values(@idfacturaproducto, @idproducto, @precio, @cantidad, @subtotal, @descuento, @itbis, @total)";
                SqlCommand cmddetalle = new SqlCommand(insertardetalle, Conexion);
                foreach (var detalle in factura.Detalles)
                {
                    cmddetalle.Parameters.Clear();
                    cmddetalle.Parameters.AddWithValue("@idfacturaproducto", factura.IDFactura);
                    cmddetalle.Parameters.AddWithValue("@idusuario", detalle.IDProducto);
                    cmddetalle.Parameters.AddWithValue("@ncf", detalle.Precio);
                    cmddetalle.Parameters.AddWithValue("@subtotal", detalle.Cantidad);
                    cmddetalle.Parameters.AddWithValue("@totaldescuento", detalle.SubTotal);
                    cmddetalle.Parameters.AddWithValue("@totalitbis", detalle.Descuento);
                    cmddetalle.Parameters.AddWithValue("@total", detalle.Itbis);
                    cmddetalle.Parameters.AddWithValue("@fechaemision", detalle.Total);
                    detalle.IDDetalleFacturaProducto = Convert.ToInt32(cmd.ExecuteScalar());

               }

                transaccion.Commit();

            } catch (Exception ex)
            {
                transaccion.Rollback();
                throw;
            }
        }*/
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
            string actualizar = "Update FacturaProducto set IDCliente= @idcliente, IDUsuario= @idusuario, NCF= @ncf, SubTotal= @subtotal, TotalDescuento= @TotalDescuento, TotalItbis= @totalitbis, Total= @total" +
                " FechaEmision= @fechaemision, FechaVencimiento= @fechavencimiento, Estatus= @estatus where IDFactura = @idfactura";
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





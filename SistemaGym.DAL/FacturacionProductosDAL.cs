using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.Entities;
using System.Reflection.Metadata;

namespace SistemaGym.DAL
{
    public class FacturacionProductosDAL : ConexionDAL
    {
        public static DataTable InsertarFactura(FacturaProductoEntity factura)
        {
            
            
                 ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();
                
                Conexion.Open();
                SqlTransaction transaccion = Conexion.BeginTransaction();
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
                
                factura.IDFactura = Convert.ToInt32(cmd.ExecuteScalar());

            }
            }
        }

    }


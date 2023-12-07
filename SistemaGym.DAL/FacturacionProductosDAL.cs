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
        public static void InsertarFactura(FacturaProductoEntity factura)
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

            } catch(Exception ex)
            {
                transaccion.Rollback();
                throw;
            } 
           }
         public static List<FacturaProductoEntity> GetAll()
        {
            List<FacturaProductoEntity> list = new List<FacturaProductoEntity>();
           
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            Conexion.Open();
            DataTable dt = new DataTable();
            string mostrar = "Select * From FacturaProductos Order By Fecha DESC ";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                FacturaProductoEntity oFactura= new FacturaProductoEntity();
                oFactura.IDFactura = Convert.ToInt32(dr["IDFactura"]);
                oFactura.IDCliente = Convert.ToInt32(dr["IDCliente"]);
                oFactura.IDUsuario= Convert.ToInt32(dr["IDUsuario"]);
                oFactura.NCF = Convert.ToString(dr["NCF"]);
               // oFactura.SubTotal = Convert.ToDecimal(dr["SubTotal"]);
                //oFactura.TotalDescuento = Convert.ToDecimal(dr["TotalDescuento"]);
               // oFactura.TotalItbis = Convert.ToDecimal(dr["TotalItbis"]);
                //oFactura.Total = Convert.ToDecimal(dr["Total"]);
                oFactura.FechaEmision = Convert.ToDateTime(dr["FechaEmision"]);
                oFactura.FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"]);
                oFactura.Estatus = Convert.ToString(dr["Estatus"]);
                list.Add(oFactura);
            }

          
            return list;
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

        }

    }


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
            
            {
                 ConexionDAL instancia = Instancia();
                SqlConnection Conexion = instancia.Conexion();
                
                Conexion.Open();
                string insertar = "Insert Into FacturaProductos(IDCliente, IDUsuario, NCF, Subtotal, TotalDescuento, TotalItbis, Total, FechaEmision, FechaVencimiento, Estatus)" +
                " Values(@idcliente, @idusuario, @ncf, @subtotal, @totaldescuento, @totalitbis, @total, @fechaemision, @fechavencimiento, @estatus)";
                SqlCommand cmd = new SqlCommand(insertar, Conexion);
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
               
                string selectOrder = "select OrderID from orders order by orderID desc limit 1;";
                MySqlCommand slCommand = new MySqlCommand(selectOrder);
               
                DataTable dt = clsConexion.ejecutarConsulta(slCommand);
                int orderID = 0;
                foreach (DataRow ultimaOrden in dt.Rows)
                {
                    orderID = Convert.ToInt32(ultimaOrden[0].ToString());
                }
                if (orderID == 0)
                {
                    orderID = 1;
                }
                
                foreach (DataGridViewRow x in dg.Rows)
                {
                    if (x.Cells["Codigo"].Value != null)
                    {

                        clsDetallesOrden od = new clsDetallesOrden();
                        clsProductos p = new clsProductos();

                    
                        string selectID = "select idproducts from products where codigo = @Codigo";
                        MySqlCommand select_id_producto = new MySqlCommand(selectID);
                        select_id_producto.Parameters.AddWithValue("Codigo", x.Cells["Codigo"].Value.ToString());
                        DataTable tabla_id_producto = clsConexion.ejecutarConsulta(select_id_producto);
                        int id_producto = -1;
                        foreach (DataRow id_obtenido in tabla_id_producto.Rows)
                        {
                            id_producto = Convert.ToInt32(id_obtenido[0].ToString());
                        }
                       
                        od.ProductID = id_producto;
                        od.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                        od.PrecioUnitario = Convert.ToDouble(x.Cells["PrecioUnitario"].Value.ToString());
                    
                        p.Codigo = x.Cells["Codigo"].Value.ToString();
                        p.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                       
                        daoT.insertar_detalle_orden(od);

                        
                        bool up = daoT.update_producto_inevntario(p);
                    }


                }


                // si todo esta bien se hace la transaccion
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {

                trans.Rollback();
                return false;
            }
            finally
            {

            }
        }

    }
}

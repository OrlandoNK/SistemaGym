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
    public class DetalleFacturaProductoDAL : ConexionDAL
    {
        public static void Actualizar(DetalleFacturaProductoEntity detallefactura)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update DetalleFacturaProducto set IDFacturaProducto = @idfacturaproducto, IDProducto= @idproducto, precio= @precio, cantidad= @cantidad, Subototal= @subtotal, Descuento= @descuento, Itbis = @itbis, Total= @total WHERE IDDetalleFacturaProductos = @idfactura";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idfacturaproducto", detallefactura.IDFacturaProducto);
            cmd.Parameters.AddWithValue("@idproducto", detallefactura.IDProducto);
            cmd.Parameters.AddWithValue("@precio", detallefactura.Precio);
            cmd.Parameters.AddWithValue("@cantidad", detallefactura.Cantidad);
            cmd.Parameters.AddWithValue("@subtotal", detallefactura.SubTotal);
            cmd.Parameters.AddWithValue("@descuento", detallefactura.Descuento);
            cmd.Parameters.AddWithValue("@itbis", detallefactura.Itbis);
            cmd.Parameters.AddWithValue("@total", detallefactura.Total);
            cmd.ExecuteNonQuery();

        }

        /* Metodo Buscar */

        public static DataTable Buscar(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM DetalleFacturaProductos WHERE IDProducto LIKE @Busqueda OR Subototal LIKE @Busqueda OR cantidad LIKE @Busqueda OR precio LIKE @Busqueda OR Total LIKE @Busqueda OR Descuento LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

        public static bool EliminarByID(int Id)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "DELETE FROM DetalleFacturaProductos WHERE IDDetalleFacturaProductos = @IDDetalleFacturaProducto";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);

            cmd.Parameters.AddWithValue("@IDDetalleFacturaProducto", Id);
            seElimino = cmd.ExecuteNonQuery() > 0;

            return seElimino;

        }
    }
}

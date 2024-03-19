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
    public class ProductoDAL : ConexionDAL
    {
        /* Metodo para Insertar Producto */
        public static void InsertarProductos(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Insertar = "INSERT INTO Productos (Categoria, IDProveedor, Nombre, PrecioUnitario, Stock) VALUES(@Categoria, @IDProveedor, @Nombre, @PrecioUnitario, @Stock)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion);

            cmd.Parameters.AddWithValue("@Categoria", producto.IDCategoria);
            cmd.Parameters.AddWithValue("@IDProveedor", producto.IDProveedor);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);
            
           

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Actualizar Productos */

        public static void UpdateProduct(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string UpdateProduct = "UPDATE Productos SET Categoria = @Categoria, IDProveedor= @IDProveedor, Nombre = @Nombre, PrecioUnitario = @PrecioUnitario, Stock = @Stock Where IDProducto= @IDProducto";
            SqlCommand cmd = new SqlCommand(UpdateProduct, Conexion);

            cmd.Parameters.AddWithValue("@Categoria", producto.IDCategoria);
            cmd.Parameters.AddWithValue("@IDProducto", producto.IDProducto);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@IDProveedor", producto.IDProveedor);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Eliminar un Producto por ID */
        public bool DeleteProduct(int producto)
        {
            bool productDeleted;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Delete = "DELETE FROM Productos WHERE IDProducto = @IDProducto";
            SqlCommand cmd = new SqlCommand(Delete, Conexion);

            cmd.Parameters.AddWithValue("@IDProducto", producto);
            productDeleted = cmd.ExecuteNonQuery() > 0;

            return productDeleted;

        }

        /* Metodo para Mostrar Productos */
        public static DataTable mostrarProductos()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            DataTable dataTBL = new DataTable();

            Conexion.Open();
            string Mostrar = "SELECT * FROM Productos";
            SqlCommand cmnd = new SqlCommand(Mostrar, Conexion);
            SqlDataAdapter adapterDTBL = new SqlDataAdapter(cmnd);
            adapterDTBL.Fill(dataTBL);

            return dataTBL;

        }

        /* Metodo par Buscar por ID */
        public static ProductoEntity BuscarByID(int id)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dataTBL = new DataTable();

            string Buscar = "SELECT * FROM Productos WHERE IDProducto = @IDProducto";
            SqlCommand cmd = new SqlCommand(Buscar, Conexion);
            cmd.Parameters.AddWithValue("@IDProducto", id);
            SqlDataReader reader = cmd.ExecuteReader();
           ProductoEntity productoEncontrado = null;

            if (reader.Read())
            {
                productoEncontrado = new ProductoEntity();
                productoEncontrado.IDProducto = Convert.ToInt32(reader["IDProducto"]);
                productoEncontrado.Nombre = reader["Nombre"].ToString();
                productoEncontrado.PrecioUnitario = Convert.ToInt32(reader["PrecioUnitario"]);
            }

            Conexion.Close();
            return productoEncontrado;
        }

        /* Metodo Obtener por Valor */
        public static DataTable ObtenerPorValor(ProductoEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "SELECT * FROM Productos " +
                "WHERE Categoria LIKE '%' + @categoria + '%' OR " +
                "IDProveedor LIKE '%' + @proveedor + '%' OR " +
                "Nombre LIKE '%' + @nombre + '%' OR " +
                "PrecioUnitario LIKE '%' + @precio + '%' OR " +
                "Stock LIKE '%' + @stock + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@categoria", "%" + clientes.IDCategoria + "%");
            cmd.Parameters.AddWithValue("@proveedor", "%" + clientes.IDProveedor + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + clientes.Nombre + "%");
            cmd.Parameters.AddWithValue("@precio", "%" + clientes.PrecioUnitario + "%");
            cmd.Parameters.AddWithValue("@stock", "%" + clientes.Stock + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static DataTable Buscar(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM Productos WHERE Categoria LIKE @Busqueda OR IDProveedor LIKE @Busqueda OR Nombre LIKE @Busqueda OR PrecioUnitario LIKE @Busqueda OR Stock LIKE @Busqueda";
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

using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class ProductoBLL
    {
        ProductoDAL productoDAL = new ProductoDAL();

        public static void InsertarProducto(ProductoEntity producto)
        {
            ProductoDAL.InsertarProductos(producto);
        }

        public static void UpdateProduct(ProductoEntity producto)
        {
            ProductoDAL.UpdateProduct(producto);
        }

        public bool DeleteProduct(ProductoEntity producto)
        {
            return productoDAL.DeleteProduct(producto);
        }

        public static DataTable GetAll()
        {
            return ProductoDAL.mostrarProductos();
        }

        public static DataTable searchById(ProductoEntity producto)
        {
            return ProductoDAL.BuscarByID(producto);
        }

        public static DataTable GetByValor(ProductoEntity producto)
        {
            return ProductoDAL.GetByValor(producto);
        }
    }
}

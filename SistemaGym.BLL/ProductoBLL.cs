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

        public static void Guardar(ProductoEntity producto)
        {
           
            if (producto.IDProducto == 0)
            {
               ProductoDAL.InsertarProductos(producto);
            } else
            {
                ProductoDAL.UpdateProduct(producto);
            }
           
        }

     

        public bool DeleteProduct(ProductoEntity producto)
        {
            return productoDAL.DeleteProduct(producto);
        }

        public static DataTable GetAll()
        {
            return ProductoDAL.mostrarProductos();
        }

        public static ProductoEntity searchById(int id)
        {
            return ProductoDAL.BuscarByID(id);
        }

        public static DataTable GetByValor(ProductoEntity producto)
        {
            return ProductoDAL.GetByValor(producto);
        }
    }
}

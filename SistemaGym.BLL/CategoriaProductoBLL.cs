using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class CategoriaProductoBLL
    {
        public static void Guardar(CategoriaProductoEntity categoria)
        {
            CategoriaProductoDAL.InsertarCategoriaProducto(categoria);
        }
        public static void Actualizar(CategoriaProductoEntity categoria)
        {
            CategoriaProductoDAL.ActualizarCategoriaProducto(categoria);
        }
        public static DataTable Buscar(string busqueda)
        {
            return CategoriaProductoDAL.ObtenerByValor(busqueda);
        }
        public static bool Eliminar(int categoria)
        {
            return CategoriaProductoDAL.EliminarCategoriaProducto(categoria);
        }

        public static DataTable Mostrar()
        {
            return CategoriaProductoDAL.MostrarCategoria();
            
        }
        public static DataTable MostrarCategoria()
        {
            return CategoriaProductoDAL.Mostrar();

        }

        public  static DataTable BuscarIDcategoria (CategoriaProductoEntity categoria)
        {
            DataTable dataTable = CategoriaProductoDAL.BuscarIDCategoria(categoria);
            return dataTable;
        }

        public static DataTable ObtenerByID (CategoriaProductoEntity categoria)
        {
            DataTable dataTable = CategoriaProductoDAL.ObtenerCategoriaProducto(categoria);
            return dataTable;
        }
    }
}

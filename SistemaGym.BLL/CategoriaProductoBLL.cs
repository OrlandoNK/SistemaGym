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
    public class CategoriaProductoBLL
    {
        public void Insertar (CategoriaProductoEntity categoria)
        {
            CategoriaProductoDAL.InsertarCategoriaProducto(categoria);
        }

        public void Actualizar (CategoriaProductoEntity categoria)
        {
            CategoriaProductoDAL.ActualizarCategoriaProducto(categoria);
        }

        public bool Eliminar(CategoriaProductoEntity categoria)
        {
            return CategoriaProductoDAL.EliminarCategoriaProducto(categoria);
        }

        public DataTable Mostrar()
        {
            DataTable dataTable = CategoriaProductoDAL.MostrarCategoria();
            return dataTable;
        }

        public DataTable BuscarIDcategoria (CategoriaProductoEntity categoria)
        {
            DataTable dataTable = CategoriaProductoDAL.BuscarIDCategoria(categoria);
            return dataTable;
        }

        public DataTable ObtenerByID (CategoriaProductoEntity categoria)
        {
            DataTable dataTable = CategoriaProductoDAL.ObtenerCategoriaProducto(categoria);
            return dataTable;
        }
    }
}

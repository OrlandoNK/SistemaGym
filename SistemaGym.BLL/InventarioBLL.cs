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
    public class InventarioBLL
    {
        public void Insertar(InventarioEntity inventario)
        {
            InventarioDAL.InsertarInventario(inventario);
        }

        public void Actualizar(InventarioEntity inventario)
        {
            InventarioDAL.ActualizarInventario(inventario);
        }

        public bool Eliminar(InventarioEntity inventario)
        {
            return InventarioDAL.EliminarInventario(inventario);
        }

        public DataTable Mostrar()
        {
            DataTable dataTable =InventarioDAL.MostrarInventario();
            return dataTable;
        }
        public static DataTable ObtenerPorValor(InventarioEntity inventario)
        {
            return InventarioDAL.ObtenerPorValor(inventario);
        }

        public DataTable BuscarByID(InventarioEntity inventario)
        {
            DataTable dataTable = InventarioDAL.BuscarID(inventario);
            return dataTable;
        }
    }
}

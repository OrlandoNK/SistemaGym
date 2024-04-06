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
    internal class DetalleInventarioBLL
    {
        public void Insertar(DetalleInventarioEntity detalleinventario)
        {
            DetalleInventarioDal.InsertarDetalleInventario(detalleinventario);
        }

        public void Actualizar(DetalleInventarioEntity detalleinventario)
        {
            DetalleInventarioDal.ActualizarDetalleInventario(detalleinventario);
        }

        public bool Eliminar(DetalleInventarioEntity detalleinventario)
        {
            return DetalleInventarioDal.EliminarDetalleInventario(detalleinventario);
        }

        public DataTable Mostrar()
        {
            DataTable dataTable = DetalleInventarioDal.MostrarDetalleInventario();
            return dataTable;
        }
        public static DataTable ObtenerPorValor(DetalleInventarioEntity detalleinventario)
        {
            return DetalleInventarioDal.ObtenerPorValor(detalleinventario);
        }

        public DataTable BuscarByID(DetalleInventarioEntity detalleinventario)
        {
            DataTable dataTable = DetalleInventarioDal.BuscarID(detalleinventario);
            return dataTable;
        }
    }
}

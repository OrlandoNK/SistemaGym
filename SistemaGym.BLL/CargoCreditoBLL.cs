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
    public class CargoCreditoBLL
    {

        public void Insertar (CargoCreditoEntity cargoCredito)
        {
            CargoCreditoDAL.InsertarCargoCredito(cargoCredito);
        }

        public void Actualizar (CargoCreditoEntity cargoCredito)
        {
            CargoCreditoDAL.ActualizarCargoCredito(cargoCredito);
        }

        public bool Eliminar (CargoCreditoEntity cargoCredito)
        {
            return CargoCreditoDAL.EliminarCargoCredito(cargoCredito);
        }

        public DataTable Mostrar()
        {
            DataTable dataTable = CargoCreditoDAL.MostrarCargoCredito();
            return dataTable;
        }

        public static DataTable BuscarByID (CargoCreditoEntity cargoCredito)
        {
            DataTable dataTable = CargoCreditoDAL.BuscarID(cargoCredito);
            return dataTable;
        }

        public static DataTable GetByValor(CargoCreditoEntity cargoCredito)
        {
            DataTable dataTable = CargoCreditoDAL.ObtenerPorValor(cargoCredito);
            return dataTable;
        }

    }
}

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
        readonly CargoCreditoDAL cargoCreditoDAL = new CargoCreditoDAL();
        public static void Guardar(CargoCreditoEntity cargoCredito)
        {
            if (cargoCredito.IDCargoCredito == 0)
            {
                //agregar
                CargoCreditoDAL.InsertarCargoCredito(cargoCredito);
            }
            else
            {
                //Actualizar
                CargoCreditoDAL.ActualizarCargoCredito(cargoCredito);

            }
        }

        public static bool Eliminar(CargoCreditoEntity cargoCredito)
        {
            return CargoCreditoDAL.EliminarCargoCredito(cargoCredito);
        }

        public static DataTable MostrarCargoCredito(CargoCreditoDAL cargoCredito)
        {
            return CargoCreditoDAL.MostrarCargoCredito();

        }

        public static DataTable BuscarID(CargoCreditoEntity cargoCredito)
        {
            return CargoCreditoDAL.BuscarID(cargoCredito);
        }

        public static DataTable ObtenerPorValor(CargoCreditoEntity cargoCredito)
        {
            return CargoCreditoDAL.ObtenerPorValor(cargoCredito);
        }
    }
}

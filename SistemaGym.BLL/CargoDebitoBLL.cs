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
    public class CargoDebitoBLL
    {
        readonly CargoDebitoDAL cargoDebitoDAL = new CargoDebitoDAL();
        public static void Guardar(CargoDebitoEntity cargoDebito)
        {
            if (cargoDebito.IDCargoDebito == 0)
            {
                //agregar
                CargoDebitoDAL.InsertarCargoDebito(cargoDebito);
            }
            else
            {
                //Actualizar
                CargoDebitoDAL.ActualizarCargoDebito(cargoDebito);

            }
        }

        public static bool Eliminar(CargoDebitoEntity cargoDebito)
        {
            return CargoDebitoDAL.EliminarCargoDebito(cargoDebito);
        }

        public static DataTable MostrarCargoDebito(CargoDebitoDAL cargoDebito)
        {
            return CargoDebitoDAL.MostrarCargoDebito();

        }

        public static DataTable BuscarID(CargoDebitoEntity cargoDebito)
        {
            return CargoDebitoDAL.BuscarID(cargoDebito);
        }

        public static DataTable ObtenerPorValor(CargoDebitoEntity cargoDebito)
        {
            return CargoDebitoDAL.ObtenerPorValor(cargoDebito);
        }
    }
}

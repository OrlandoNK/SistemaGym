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
        public static void Insertar (CargoDebitoEntity cargoDebito)
        {
            CargoDebitoDAL.InsertarCargoDebito(cargoDebito);
        }

        public static void Actualizar (CargoDebitoEntity cargoDebito)
        {
            CargoDebitoDAL.ActualizarCargoDebito(cargoDebito);
        }

        public static bool Eliminar (CargoDebitoEntity cargoDebito)
        {
            return CargoDebitoDAL.EliminarCargoDebito(cargoDebito);
        }

        public static DataTable Mostrar()
        {
            DataTable dataTable = CargoDebitoDAL.MostrarCargoCredito();
            return dataTable;
        }

        public static DataTable BuscarByID (CargoDebitoEntity cargoDebito)
        {
            DataTable dataTable = CargoDebitoDAL.BuscarID(cargoDebito);
            return dataTable;
        }

        public static DataTable ObtenerByValor(CargoDebitoEntity cargoDebito)
        {
            DataTable dataTable = CargoDebitoDAL.ObtenerPorValor(cargoDebito);
            return dataTable;
        }

    }
}

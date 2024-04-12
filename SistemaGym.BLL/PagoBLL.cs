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
    public class PagoBLL
    {
        readonly PagoDAL pagoDAL = new PagoDAL();
        public static void guardar(PagoEntity pago)
        {
            if (pago.IDPago == 0)
            {
                //agregar
                PagoDAL.InsertarPago(pago);
            }
            else
            {
                //Actualizar
                PagoDAL.Update(pago);
            }

        }
        public static bool Eliminar(PagoEntity pago)
        {
            return PagoDAL.DeletePago(pago);
        }
        public static DataTable BuscarPago (string buscar)
        {
            return PagoDAL.Buscar(buscar);
        }
        public static DataTable Mostrarpago()
        {
            return PagoDAL.mostrarPago();
        }
        public static DataTable BucarID(PagoEntity pago)
        {
            return PagoDAL.BuscarByID(pago);
        }
        public static DataTable ObtenerPorValor(PagoEntity pago)
        {
            return PagoDAL.GetByValor(pago);
        }
    }
}

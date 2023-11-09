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
                PagoDAL.Insertarpago(pago);
            }
            else
            {
                //Actualizar
                PagoDAL.Actualizarpago(pago);
            }

        }
        public static bool Eliminar(PagoEntity pago)
        {
            return PagoDAL.Eliminarpago(pago);
        }
        public static DataTable Mostrarpago(PagoEntity pago)
        {
            return PagoDAL.Mostrarpago();
        }
        public static DataTable BucarID(PagoEntity pago)
        {
            return PagoDAL.BuscarID(pago);
        }
        public static DataTable ObtenerPorValor(PagoEntity pago)
        {
            return PagoDAL.ObtenerPorValor(pago);
        }
    }
}

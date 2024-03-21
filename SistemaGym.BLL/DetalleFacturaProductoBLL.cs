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
    public class DetalleFacturaProductoBLL
    {
        public static void ActualizarDetalle(DetalleFacturaProductoEntity detallefactura)
        {
            DetalleFacturaProductoDAL.Actualizar(detallefactura);
        }
        public static bool EliminarDetalle(int Id)
        {
            return DetalleFacturaProductoDAL.EliminarByID(Id);
        }
        public static DataTable BuscarDetalle(string busqueda)
        {
            return DetalleFacturaProductoDAL.Buscar(busqueda);
        }
    }
}

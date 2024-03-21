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
    public class FacturacionProductoBLL
    {
        public static void Guardar(FacturaProductoEntity factura)
        {
            FacturacionProductosDAL.InsertarFactura(factura);
        }
        public static void Actualizar(FacturaProductoEntity factura)
        {
            FacturacionProductosDAL.Actualizar(factura);
        }
        public static DataTable BuscarFacturaProducto(string busqueda)
        {
            return FacturacionProductosDAL.Buscar(busqueda);
        }
        public static bool DeleteByID(int Id)
        {
            return FacturacionProductosDAL.EliminarByID(Id);
        }
        public static DataTable Mostrar()
        {
            return FacturacionProductosDAL.Mostrar();
        }
        public static DataTable MostrarDetalle()
        {
            return FacturacionProductosDAL.MostrarDetalle();
        }

    }
}

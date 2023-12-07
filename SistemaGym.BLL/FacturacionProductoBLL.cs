using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class FacturacionProductoBLL
    {
        public static void Guardar(FacturaProductoEntity factura)
        {
            if (FacturacionProductosDAL.Exist(factura.IDFactura))
            {
                FacturacionProductosDAL.Actualizar(factura);


            }else
            {
                FacturacionProductosDAL.InsertarFactura(factura);
            }
            
        }

    }
}

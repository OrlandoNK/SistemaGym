﻿using SistemaGym.DAL;
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
            if (FacturacionProductosDAL.Exist(factura.IDFactura))
            {
                FacturacionProductosDAL.Actualizar(factura);


            }else
            {
                FacturacionProductosDAL.InsertarFactura(factura);
            }
            
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

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
    public class FacturaMembresiaBLL
    {
        FacturacionMembresiaDAL facturacionMembresiaDAL = new FacturacionMembresiaDAL();
        public void Insertar (FacturaMembresiaEntity facturacionMembresia)
        {
            FacturacionMembresiaDAL.Insertar(facturacionMembresia);
        }

        public void Actualizar (FacturaMembresiaEntity facturaMembresia)
        {
            FacturacionMembresiaDAL.Actualizar(facturaMembresia);
        }


        public bool Eliminar (int Id)
        {
            return FacturacionMembresiaDAL.EliminarByID(Id);
        }

        public DataTable Mostrar()
        {
            DataTable dataTable = FacturacionMembresiaDAL.Mostrar();
            return dataTable;
        }

        public DataTable MostrarFacturaMembresia()
        {
            DataTable dataTbl = FacturacionMembresiaDAL.MostrarFacturaMembresia();
            return dataTbl;
        }

        public DataTable BuscarByID(FacturaMembresiaEntity facturaMembresia)
        {
            DataTable dataTable = FacturacionMembresiaDAL.BuscarByID(facturaMembresia);
            return dataTable;
        }

        public DataTable ObtenerByValor(string busqueda)
        {
            DataTable dataTable = FacturacionMembresiaDAL.ObtenerByValor(busqueda);
            return dataTable;
        }
    }
}

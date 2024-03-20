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
    public class TipoClienteBLL
    {
        readonly TipoClienteDAL tipoClienteDAL = new TipoClienteDAL();
        public static void Guardar(TipoClienteEntity tipoCliente)
        {   
            //agregar
            TipoClienteDAL.InsertarTipoCliente(tipoCliente);
        }
        public static void Actualizar(TipoClienteEntity tipoCliente)
        {
            //agregar
            TipoClienteDAL.ActualizarTipoCliente(tipoCliente);
        }
        public static DataTable BuscarCliente(string busqueda)
        {
            return TipoClienteDAL.Buscar(busqueda);
        }

        public static bool Eliminar(int tipoCliente)
        {
            return TipoClienteDAL.EliminarTipoCliente(tipoCliente);
        }

        public static DataTable MostrarTipoCliente()
        {
            return TipoClienteDAL.MostrarTipoCliente();
        }

    }
}

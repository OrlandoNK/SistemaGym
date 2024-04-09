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
    public class TipoListaClienteBLL
    {
        readonly TipoListaClienteDAL tipoListaClienteDAL = new TipoListaClienteDAL();
        public static void Guardar(TipoListaClienteEntity tipoListaCliente)
        {
           //agregar
           TipoListaClienteDAL.InsertarTipoListaCliente(tipoListaCliente);
        }
        public static void Actualizar(TipoListaClienteEntity tipoListaCliente)
        {
            //Actualizar
            TipoListaClienteDAL.ActualizarTipoListaCliente(tipoListaCliente);
        }

        public static bool Eliminar(int tipoListaCliente)
        {
            return TipoListaClienteDAL.EliminarTipoListaCliente(tipoListaCliente);
        }

        public static DataTable MostrarTipoListaCliente()
        {
            return TipoListaClienteDAL.MostrarTipoListaCliente();

        }

        
    }
}

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
            if (tipoListaCliente.IDTipoListaCliente == 0)
            {
                //agregar
                TipoListaClienteDAL.InsertarTipoListaCliente(tipoListaCliente);
            }
            else
            {
                //Actualizar
                TipoListaClienteDAL.ActualizarTipoListaCliente(tipoListaCliente);

            }
        }

        public static bool Eliminar(TipoListaClienteEntity tipoListaCliente)
        {
            return TipoListaClienteDAL.EliminarTipoListaCliente(tipoListaCliente);
        }

        public static DataTable MostrarTipoListaCliente(TipoListaClienteDAL tipoListaCliente)
        {
            return TipoListaClienteDAL.MostrarTipoListaCliente();

        }

        
    }
}

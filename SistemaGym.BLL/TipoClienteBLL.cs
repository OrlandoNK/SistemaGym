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
            if (tipoCliente.IDTipoCliente == 0)
            {
                //agregar
               TipoClienteDAL.InsertarTipoCliente(tipoCliente);
            }
            else
            {
                //Actualizar
                TipoClienteDAL.ActualizarTipoCliente(tipoCliente);

            }
        }

        public static bool Eliminar(TipoClienteEntity tipoCliente)
        {
            return TipoClienteDAL.EliminarTipoCliente(tipoCliente);
        }

        public static DataTable MostrarTipoCliente()
        {
            return TipoClienteDAL.MostrarTipoCliente();
        }

    }
}

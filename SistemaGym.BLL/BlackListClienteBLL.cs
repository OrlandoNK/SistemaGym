using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.DAL;
using SistemaGym.Entities;

namespace SistemaGym.BLL
{
    public class BlackListClienteBLL
    {

        public void Create(BlacklistClienteEntity blacklistCliente)
        {
            BlacklistClienteDAL.Insertar(blacklistCliente);
        }

        public void Update(BlacklistClienteEntity blacklistCliente)
        {
            BlacklistClienteDAL.Actualizar(blacklistCliente);
        }

        public bool DeleteByID(BlacklistClienteEntity blacklistcliente)
        {
            return BlacklistClienteDAL.EliminarByID(blacklistcliente);
        }

        public DataTable GetBlacklistCliente()
        {
            DataTable dataTable = BlacklistClienteDAL.Mostrar();
            return dataTable;
        }

        public DataTable SearchByID (BlacklistClienteEntity blacklist)
        {
            DataTable dataTable = BlacklistClienteDAL.BuscarByID(blacklist);
            return dataTable;
        }

        public DataTable GetByValor(BlacklistClienteEntity blacklist)
        {
            DataTable dataTable = BlacklistClienteDAL.ObtenerByValor(blacklist);
            return dataTable;
        }

    }
}

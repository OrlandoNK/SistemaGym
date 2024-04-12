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
    public class GrupoClienteBLL
    {
        public static void Insertar (GrupoClienteEntity grupoCliente)
        {
            GrupoClienteDAL.InsertarGrupoCliente(grupoCliente);
        }

        public static void Actualizar (GrupoClienteEntity grupoCliente)
        {
            GrupoClienteDAL.ActualizarGrupoCliente(grupoCliente);
        }
        public static DataTable Buscar (string buscar)
        {
            return GrupoClienteBLL.Buscar(buscar);
        }
        public static bool Eliminar (int grupoCliente)
        {
            return GrupoClienteDAL.EliminarCliente(grupoCliente);
        }

        public static DataTable Mostrar()
        {
            DataTable dataTable = GrupoClienteDAL.MostrarGrupoCliente();
            return dataTable;
        }

        public static DataTable BuscarByID(GrupoClienteEntity grupoCliente)
        {
            DataTable dataTable = GrupoClienteDAL.BuscarID(grupoCliente);
            return dataTable;
        }

        public static DataTable ObtenerByValor (GrupoClienteEntity grupoCliente)
        {
            DataTable dataTable = GrupoClienteDAL.ObtenerPorValor(grupoCliente);
            return dataTable;
        }
    }
}

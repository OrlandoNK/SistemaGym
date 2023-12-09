using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class GrupoMembresiaBLL
    {
        readonly GrupoMembresiaDAL grupoMembresiaDAL = new GrupoMembresiaDAL();
        public static void guardar(GrupoMembresiaEntity grupoMembresia)
        {
            if (grupoMembresia.IDGrupoMembresia == 0)
            {
                //agregar
                GrupoMembresiaDAL.InsertarGrupoMembresia(grupoMembresia);
            }
            else
            {
                //Actualizar
                GrupoMembresiaDAL.ActualizarGrupoMembresia(grupoMembresia);
            }
        }
        public static bool Eliminar(int Id)
        {
            return GrupoMembresiaDAL.EliminarGrupoMembresia(Id);
        }
        public static DataTable MostrarGrupoMembresia()
        {
            return GrupoMembresiaDAL.MostrarGrupoMembresia();
        }
        public static DataTable BuscarID(GrupoMembresiaEntity grupoMembresia)
        {
            return GrupoMembresiaDAL.BuscarID(grupoMembresia);
        }
        public static DataTable ObtenerPorValor(GrupoMembresiaEntity grupoMembresia)
        {
            return GrupoMembresiaDAL.ObtenerPorValor(grupoMembresia);
        }
    }
}

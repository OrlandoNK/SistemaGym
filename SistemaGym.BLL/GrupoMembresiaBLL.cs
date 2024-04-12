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
            //agregar
            GrupoMembresiaDAL.InsertarGrupoMembresia(grupoMembresia);
        }
        public static DataTable Buscar(string buscar)
        {
            return GrupoMembresiaDAL.Buscar(buscar);
        }
        public static void actualizar(GrupoMembresiaEntity grupoMembresia)
        {
            //Actualizar
            GrupoMembresiaDAL.ActualizarGrupoMembresia(grupoMembresia);
        }
        public static bool Eliminar(int grupoMembresia)
        {
            return GrupoMembresiaDAL.EliminarGrupoMembresia(grupoMembresia);
        }
        public static DataTable MostrarGrupoMembresia()
        {
            return GrupoMembresiaDAL.MostrarGrupoMembresia();
        }
        public static DataTable BuscarID(GrupoMembresiaEntity grupoMembresia)
        {
            return GrupoMembresiaDAL.BuscarID(grupoMembresia);
        }
        public static GrupoMembresiaEntity GetByID(int Id)
        {
            return GrupoMembresiaDAL.GetByID(Id);
        }
        public static DataTable ObtenerPorValor(GrupoMembresiaEntity grupoMembresia)
        {
            return GrupoMembresiaDAL.ObtenerPorValor(grupoMembresia);
        }
    }
}

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
    public class RolBLL
    {
        readonly RolDAL rolDAL = new RolDAL();
        public static void Guardar(RolEntity rol)
        {
           RolDAL.InsertarRolDal(rol);
        }

        public static void ActualizarRol(RolEntity rol)
        {
            RolDAL.ActualizarRolDal(rol);
        }

        public static string ObtenerRolUsuario(string usuario, string contraseña)
        {
            return RolDAL.ObtenerRolUsuario(usuario, contraseña);
        }

        public static DataTable ObtenerByValor(string busqueda)
        {
            return RolDAL.ObtenerByValor(busqueda);
        }

        public static bool EliminarRol(int rol)
        {
            return RolDAL.EliminarRolDal(rol);
        }

        public static DataTable MostrarRol()
        {
            return RolDAL.MostrarRol();

        }

        public static DataTable BuscarID(RolEntity rol)
        {
            return RolDAL.BuscarID(rol);
        }

    }
}

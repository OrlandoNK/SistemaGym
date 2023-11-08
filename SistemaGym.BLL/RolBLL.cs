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
            if (rol.IDRol == 0)
            {
                //agregar
                RolDAL.InsertarRolDal(rol);
            }
            else
            {
                //Actualizar
                RolDAL.ActualizarRolDal(rol);

            }
        }

        public static bool EliminarRol(RolEntity rol)
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

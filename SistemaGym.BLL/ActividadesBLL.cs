using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class ActividadesBLL
    {
        readonly ActividadesDAL actividadesDAL = new ActividadesDAL();
        public static void Guardar(ActividadesEntity actividades)
        {
            if (actividades.IDActividad == 0)
            {
                //agregar
                ActividadesDAL.InsertarActividad(actividades);
            }
            else
            {
                //Actualizar
                ActividadesDAL.ActualizarActividad(actividades);

            }
        }

        public static bool Eliminar(ActividadesEntity actividades)
        {
            return ActividadesDAL.EliminarActividad(actividades);
        }

        public static DataTable MostrarActividades(ActividadesEntity actividades)
        {
            return ActividadesDAL.MostrarActividades();

        }

        public static DataTable BuscarID(ActividadesEntity actividades)
        {
            return ActividadesDAL.BuscarID(actividades);
        }

        public static DataTable ObtenerPorValor(ActividadesEntity actividades)
        {
            return ActividadesDAL.ObtenerPorValor(actividades);
        }
    }
}

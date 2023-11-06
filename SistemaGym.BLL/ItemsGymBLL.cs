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
    public class ItemsGymBLL
    {
        readonly ItemsGymDAL itemsGymDAL = new ItemsGymDAL();
        public static void guardar(ItemsGymEntity itemsGym)
        {
            if (itemsGym.IDItem == 0)
            {
                //Agregar
                ItemsGymDAL.InsertarItemsGym(itemsGym);
            }
            else
            {
                //Actualizar
                ItemsGymDAL.ActualizarItemsGym(itemsGym);
            }

        }
        public static bool Eliminar(ItemsGymEntity itemsGym)
        {
            return ItemsGymDAL.EliminarItemsGym(itemsGym);
        }
        public static DataTable MostrarItemsGym(ItemsGymEntity itemsGym)
        {
            return ItemsGymDAL.MostrarItemsGym();
        }
        public static DataTable BuscarID(ItemsGymEntity itemsGym)
        {
            return ItemsGymDAL.BuscarID(itemsGym);
        }
        public static DataTable ObtenerPorValor(ItemsGymEntity itemsGym)
        {
            return ItemsGymDAL.ObtenerPorValor(itemsGym);
        }
    }
}

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
    public class MembresiaBLL
    {
        public static void Insertar(MembresiaEntity membresia)
        {
            if (membresia.IDMembresia == 0){             
                MembresiaDAL.InsertarMembresia(membresia);
            }
            else
            {          
                    MembresiaDAL.ActualizarMembresia(membresia);
            }         
        }

   public static void ActualizarMembresia(MembresiaEntity membresia)
        {
            MembresiaDAL.ActualizarMembresia(membresia);
        }

    public static bool Eliminar(int membresia)
    {
        return MembresiaDAL.EliminarMembresia(membresia);
    }

    public static DataTable Mostrar()
    {
        return MembresiaDAL.MostrarMembresia();
        }

    public static DataTable BuscarByID(MembresiaEntity membresia)
    {
            return MembresiaDAL.BuscarID(membresia);
        
    }
    public static DataTable BuscarByValor(MembresiaEntity membresia)
        {
            return MembresiaDAL.ObtenerPorValor(membresia);
           
        }

    public static MembresiaEntity GetById(int Id)
        {
           return MembresiaDAL.GetByID(Id);
        }
    }
        
        

}

    

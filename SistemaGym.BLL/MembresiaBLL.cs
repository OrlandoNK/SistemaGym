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

   

    public static bool Eliminar(MembresiaEntity membresia)
    {
        return MembresiaDAL.EliminarMembresia(membresia);
    }

    public static DataTable Mostrar()
    {
        DataTable dataTable = MembresiaDAL.MostrarMembresia();
        return dataTable;
    }

    public static DataTable BuscarByID(MembresiaEntity membresia)
    {
        DataTable dataTable = MembresiaDAL.BuscarID(membresia);
        return dataTable;
    }
    public static DataTable BuscarByValor(MembresiaEntity membresia)
        {
            DataTable dataTable = MembresiaDAL.ObtenerPorValor(membresia);
            return dataTable;
        }
    }
        
        

}

    

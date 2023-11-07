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
        public void Insertar(MembresiaEntity membresia)
        {
            MembresiaDAL .InsertarMembresia(membresia);
        }

    public void Actualizar(MembresiaEntity membresia)
    {
        MembresiaDAL.ActualizarMembresia(membresia);
    }

    public bool Eliminar(MembresiaEntity membresia)
    {
        return MembresiaDAL.EliminarMembresia(membresia);
    }

    public DataTable Mostrar()
    {
        DataTable dataTable = MembresiaDAL.MostrarMembresia();
        return dataTable;
    }

    public DataTable BuscarByID(MembresiaEntity membresia)
    {
        DataTable dataTable = MembresiaDAL.BuscarID(membresia);
        return dataTable;
    }
    public DataTable BuscarByValor(MembresiaEntity membresia)
        {
            DataTable dataTable = MembresiaDAL.ObtenerPorValor(membresia);
            return dataTable;
        }
    }
        
        

}

    

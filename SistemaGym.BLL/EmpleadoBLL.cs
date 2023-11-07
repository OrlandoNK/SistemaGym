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
    public class EmpleadoBLL
    {
        private EmpleadoDAL empleadoDAL;

        public void insertarEmpleado (EmpleadoEntity empleado)
        {
            EmpleadoDAL.insertarEmpleado(empleado);
        }

        public void actualizarEmpleado(EmpleadoEntity empleado)
        {
            EmpleadoDAL.actualizarEmpleado(empleado);
        }

        public void eliminarEmpleado(EmpleadoEntity empleado)
        {
            empleadoDAL.eliminarEmpleado(empleado);
        }

        public DataTable mostrarEmpleado()
        {
            DataTable dataTBL = EmpleadoDAL.mostrarEmpleado();
            return dataTBL;
        }

        public DataTable buscarByID(EmpleadoEntity empleado)
        {
            DataTable DTtbl = empleadoDAL.SearchByID(empleado);
            return DTtbl;
        }

        public static DataTable GetByValor (EmpleadoEntity empleado)
        {
            DataTable dataTable = EmpleadoDAL.GetByValor(empleado);
            return dataTable;
        }

    }
}

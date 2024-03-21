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
        EmpleadoDAL empleadoDAL = new EmpleadoDAL();

        public static void Create(EmpleadoEntity empleado)
        {
            EmpleadoDAL.insertarEmpleado(empleado);
        }
        public static void Update(EmpleadoEntity empleado)
        {
            EmpleadoDAL.actualizarEmpleado(empleado);
        }
        public static DataTable BuscarEmpleado(string busqueda)
        {
            return EmpleadoDAL.Buscar(busqueda);
        }
        public static EmpleadoEntity GetByID(int Id)
        {
            return EmpleadoDAL.GetByID(Id);
        }
        public static DataTable GetEmpleados()
        {
            return EmpleadoDAL.mostrarEmpleado();
        }
        public bool Delete(int ID)
        {
            return empleadoDAL.eliminarEmpleado(ID);
        }
    }
}

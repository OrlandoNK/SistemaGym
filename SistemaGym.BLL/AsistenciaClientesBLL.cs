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
    public class AsistenciaClientesBLL
    {
        readonly AsistenciaClientesDAL asistenciaClientesDAL = new AsistenciaClientesDAL();     
        public static void Guardar(AsistenciaClientesEntity asistencia)
        {
            //agregar
            AsistenciaClientesDAL.InsertarAsistencia(asistencia);
        }
        public static void Actualizar(AsistenciaClientesEntity asistencia)
        {
            //Actualizar
            AsistenciaClientesDAL.ActualizarAsistencia(asistencia);
        }
        public DataTable MostrarAsistenciasHOY()
        {
            return AsistenciaClientesDAL.MostrarAsistenciaHOY();
        }

        public static bool Eliminar(int asistencia)
        {
            return AsistenciaClientesDAL.EliminarAsistencia(asistencia);
        }

        public static DataTable MostrarAsistencia()
        {
            return AsistenciaClientesDAL.MostrarAsistencia();

        }

        public static DataTable BuscarID(AsistenciaClientesEntity asistencia)
        {
            return AsistenciaClientesDAL.BuscarID(asistencia);
        }

        public static DataTable ObtenerPorValor(AsistenciaClientesEntity asistencia)
        {
            return AsistenciaClientesDAL.ObtenerPorValor(asistencia);
        }


    }
}

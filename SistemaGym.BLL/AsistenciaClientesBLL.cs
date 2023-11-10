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
            if (asistencia.IDAsistenciaCliente == 0)
            {
                //agregar
                AsistenciaClientesDAL.InsertarAsistencia(asistencia);
            }
            else
            {
                //Actualizar
                AsistenciaClientesDAL.ActualizarAsistencia(asistencia);

            }
        }

        public static bool Eliminar(AsistenciaClientesEntity asistencia)
        {
            return AsistenciaClientesDAL.EliminarAsistencia(asistencia);
        }

        public static DataTable MostrarAsistencia(AsistenciaClientesEntity asistencia)
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

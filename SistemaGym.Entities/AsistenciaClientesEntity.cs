using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
     public class AsistenciaClientesEntity
    {
        public int IDAsistenciaCliente { get; set; }
        public int IDCliente { get; set;}
        public Boolean Asistencia {  get; set;}   
        public DateTime FechaAsistencia { get; set; }
    }
}

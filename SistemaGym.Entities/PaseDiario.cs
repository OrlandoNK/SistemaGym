using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class PaseDiario
    {
        public int IDPaseDiario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaAsistencia { get; set; }
    }
}

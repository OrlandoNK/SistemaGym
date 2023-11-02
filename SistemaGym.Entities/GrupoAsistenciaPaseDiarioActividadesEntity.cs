using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class GrupoAsistenciaPaseDiarioActividadesEntity
    {
        public int IDGrupoAsistenciaPaseDiarioActividades { get; set; }
        public int IDCliente {  get; set; }
        public int IDActividades {  get; set; } 
        public bool Asistencia { get; set; }
        public TimeOnly Hora { get; set; }
        public decimal Monto { get; set; }  

      
        
    }
}

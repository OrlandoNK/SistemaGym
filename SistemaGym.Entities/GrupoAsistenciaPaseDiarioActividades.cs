using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class GrupoAsistenciaPaseDiarioActividades
    {
        public int ID { get; set; }
        public int IDPaseDiario {  get; set; }
        public int IDActividades {  get; set; }
    }
}

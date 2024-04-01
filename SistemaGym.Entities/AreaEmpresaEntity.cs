using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class AreaEmpresaEntity
    {
        public int IDArea { set; get; }
        public int Encargado { set; get; }
        public string Nombre { set; get; }
        public string Descripcion {  set; get; }
        public DateTime FechaRegistro { set; get; }
        
    }
}

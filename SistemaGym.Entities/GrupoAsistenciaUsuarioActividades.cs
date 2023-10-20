using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    internal class GrupoAsistenciaUsuarioActividades
    {
        public int ID { get; set; }
        public int IDActividad { get; set; }
        public int IDUsuario { get; set; }
    }
}

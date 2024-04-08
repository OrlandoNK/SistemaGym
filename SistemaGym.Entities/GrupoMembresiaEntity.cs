using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class GrupoMembresiaEntity
    {
        public int IDGrupoMembresia { get; set; }

        public int IDMembresia { get; set; }
        public string Nombre { get; set; }  
        public Decimal MontoTotal { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string Estatus { get; set; }

    }
}

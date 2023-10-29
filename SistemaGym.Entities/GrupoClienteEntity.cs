using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class GrupoClienteEntity
    {
        public int IDGrupoCliente { get; set; }
        public int IDGrupoMembresia { get; set; }
        public int IDCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Estatus { get; set; }

    }
}

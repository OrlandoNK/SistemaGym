using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
     public class Proveedores
    {
        public int IDProveedores { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string Estatus { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class FacturaMembresia
    {
        public int IDFactura { get; set; }
        public int IDMembresia { get; set; }
        public int IDCliente { get; set; }

        public int IDUsuario { get; set; }

        public string NCF { get; set; }

        public int CargoCredito { get; set; }

        public int CargoDebito { get; set; }

        public DateTime FechaEmision { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string Estatus { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class CargoCredito
    {
        public int IDCargoCredito { get; set; }

        public int IDCliente { get; set; }

        public string Cargo { get; set; }
        public decimal Monto { get; set; }

        public DateTime FechaCargo { get; set; }

        public string Estatus { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class PagoEntity
    {
        public int IDPago { get; set; }

        public int IDFacturaProductos { get; set; }

        public int IDFacturaMembresia { get; set; }
        public string MetodoPago { get; set; }

        public decimal Monto { get; set; }
        
        public decimal Pagado { get; set; }

        public decimal Devuelta { get; set; }

        public DateTime FechaPago { get; set; }

        public string Estatus { get; set; }
    }
}

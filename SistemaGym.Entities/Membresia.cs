using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class Membresia
    {
        public int IDMembresia { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Duracion {  get; set; }

        public decimal Valor { get; set; }


    }
}

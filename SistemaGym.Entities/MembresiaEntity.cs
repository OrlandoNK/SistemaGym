using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class MembresiaEntity
    {
        public int? IDMembresia { get; set; }
        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public int? Duracion {  get; set; }

        public int? CantidadPersonas { get; set; }

        public decimal? Valor { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public string? Estatus { get; set; } 


    }
}

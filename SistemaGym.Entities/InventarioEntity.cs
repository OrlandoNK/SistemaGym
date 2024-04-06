using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class InventarioEntity
    {
        public int IDInventario { get; set; }
        public string NombreItems { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Ubicacion { get; set; }
        public decimal Cantidad { get; set; }
        public string EstatusItems { get; set; }
    }
}

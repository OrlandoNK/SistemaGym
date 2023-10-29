using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class ProductoEntity
    {
        public int IDProductos { get; set; }

        public int Categorias { get; set; }
        public int No_Existencias { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
   }
}

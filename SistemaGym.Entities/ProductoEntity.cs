using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class ProductoEntity
    {
        public int IDProducto { get; set; }
        public int IDCategoria { get; set; }
        public int IDProveedor { get; set; }
        public string Nombre { get; set; }
   
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }
       
       
   }
}

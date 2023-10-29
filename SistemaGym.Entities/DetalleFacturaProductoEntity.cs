using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class DetalleFacturaProductoEntity
    {
        public int ID {  get; set; }
        public int IDFacturaProducto {  get; set; }
        public int IDProducto {  get; set; }
        public int Cantidad {  get; set; }
        public decimal SubTotal {  get; set; }
        public decimal Impuesto {  get; set; }
    }
}

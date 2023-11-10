using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class DetalleFacturaProductoEntity
    {
        public int IDDetallesFacturaProducto {  get; set; }
        public int IDFacturaProducto {  get; set; }
        public int IDProducto {  get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal{ get{ return Cantidad * Precio; } set { } }
        public decimal Descuento { get; set; }
        public decimal Itbis { get { return SubTotal * (18 / 100); } set { } }
        public decimal Total { get {  return SubTotal - Descuento + Itbis; } set { } }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class FacturaProductoEntity
    {

        public List<DetalleFacturaProductoEntity> Detalles { get; set; }
        public int IDFactura { get; set; }
        public int IDCliente { get; set; }
        public int IDUsuario { get; set; }
        public string NCF { get; set; }
        public decimal SubTotal { get { return Detalles.Sum(d => d.SubTotal); } set { } }
        public decimal TotalDescuento { get { return Detalles.Sum(d => d.Descuento); } set { } }
        public decimal TotalItbis { get { return Detalles.Sum(d => d.Itbis); } set { } }
        public decimal Total { get { return Detalles.Sum(d => d.Total); } set { } }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estatus { get; set; }
    }
}

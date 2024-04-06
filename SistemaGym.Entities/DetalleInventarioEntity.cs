using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class DetalleInventarioEntity
    {
        public int IDDetalleInventario { get; set; }
        public string NombreItems { get; set; } 
        public string Tipo { get; set; }
        public double Kilo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Estatus { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
    }
}

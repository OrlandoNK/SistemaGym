using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class ItemsGymEntity
    {
        public int IDItem { get; set; }
        public int Proveedor {  get; set; }
        public string Nombre {  get; set; }

        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
    }
}

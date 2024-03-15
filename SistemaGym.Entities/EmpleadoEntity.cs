using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class EmpleadoEntity
    {
        public int IDEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
        public string TellCell { get; set; }
        public string TelRes { get; set;}
        public DateTime FechaRegistro { get; set; }
        public string Estatus { get; set; }
    }
}

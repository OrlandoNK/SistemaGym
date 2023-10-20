using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class Actividades
    {
        public int ID { get; set; }
        public int IDTipoActividades { get; set; }
        public int Area {  get; set; }
        public string EncargadoActividad {  get; set; }
        public DateTime HorarioInicio {  get; set; }
        public DateTime HorarioCierre { get; set; }
        public string Estatus {  get; set; }
    }
}

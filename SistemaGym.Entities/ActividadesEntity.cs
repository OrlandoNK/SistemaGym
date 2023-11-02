using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class ActividadesEntity
    {
        public int IDActividad { get; set; }
        public int IDTipoActividades { get; set; }
        public int Area {  get; set; }
        public string EncargadoActividad {  get; set; }

        public string Dia  { get; set; }
        public TimeOnly HoraInicio {  get; set; }
        public TimeOnly HoraCierre { get; set; }
        public string Estatus {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    internal class BlacklistCliente
    {
        public int IDBlackListCliente { get; set; }
        public int IDListaCliente { get; set; }
        public int IDCliente { get; set; }

        public string Razones { get; set; }
        public DateTime FechaInicial {get; set;}
        public DateTime FechaVencimiento { get; set; }

        public string Estatus {  get; set; }
    }
}

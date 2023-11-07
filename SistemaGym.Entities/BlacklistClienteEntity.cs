using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class BlacklistClienteEntity
    {
        public int IDBlackListCliente { get; set; }
        public int IDTipoListaCliente { get; set; }
        public int IDCliente { get; set; }

        public string Razones { get; set; }
        public DateTime FechaInicial {get; set;}
        public DateTime FechaVencimiento { get; set; }

        public string Estatus {  get; set; }
    }
}

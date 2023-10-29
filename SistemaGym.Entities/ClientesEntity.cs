using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class ClientesEntity
    {
     public int IDCliente { get; set; }    

        public int IDUsuario { get; set; }

        public int IDMembresia { get; set; }
        public int TipoListaCliente { get; set; }

        public int TipoCliente {  get; set; }

        public string Nombre { get; set; }

        public string Apellido {  get; set; }

        public string TipoDocumento { get; set; }

        public string Documento {  get; set; }

        public string Direccion { get; set; }

        public string TelCell { get; set; }
        public string TelRes { get; set; }
        public DateTime FechaRegistro { get; set; }

        public string Estatus { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class Usuario
    {
        public int IDUsuario {get ; set;}

    public string Nombre {get ; set; }
    public string Apellido { get; set; }
    public string Sexo { get; set; }
    public string Rol { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public DateTime FechaRegistro { get; set; }
        public string NombreUsuario {  get; set; } 
        public string Contraseña { get; set; }
       
    }
}

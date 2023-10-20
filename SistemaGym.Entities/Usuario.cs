using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    internal class Usuario
    {
        public int IDUsuario {get ; set;}

    public string Nombre {get ; set; }
    public string Apellido { get; set; }
    public string Sexo { get; set; }
    public  Rol { get; set; }
    public int Correo { get; set; }
    public int Direccion { get; set; }
    public DateTime FechaRegistro { get; set; }
        public int Contraseña { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.Entities
{
    public class UsuarioEntity
    {
        public int IDUsuario {get ; set;}
        public string IDRol { get; set; }
        public string Nombre {get ; set; }
    public string Apellido { get; set; }
    public string Sexo { get; set; }
  
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public DateTime FechaRegistro { get; set; }
        public string NombreUsuario {  get; set; } 
        public string Contrasena { get; set; }

        public UsuarioEntity(string nombreUsuario, string contrasena)
        {
           NombreUsuario = nombreUsuario;
           Contrasena = contrasena;
        }
    }
}

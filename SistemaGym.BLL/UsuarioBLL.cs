using SistemaGym.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class UsuarioBLL
    {
         readonly UsuarioDAL usuarioDAL = new UsuarioDAL();
        public int ConultaLogin(string usuario, string contrasena)
        {
            return usuarioDAL.ConsultaLogin(usuario, contrasena);
        }
    }
}

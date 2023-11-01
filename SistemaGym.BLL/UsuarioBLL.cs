using SistemaGym.DAL;
using SistemaGym.Entities;
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
        public  int ConsultaLogin(UsuarioEntity usuario)
        {


            return usuarioDAL.ConsultaLogin(usuario);
        }
    }
}

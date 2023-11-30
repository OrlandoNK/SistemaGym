using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.Entities;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace SistemaGym.BLL
{
    public class UsuarioBLL
    {
         readonly UsuarioDAL usuarioDAL = new UsuarioDAL();
        public int ConsultaLogin(UsuarioEntity usuario)
        {
            return usuarioDAL.ConsultaLogin(usuario);
        }

        public static void Guardar(UsuarioEntity usuario)
        {
            if (usuario.IDUsuario == 0)
            {
                //agregar
                UsuarioDAL.InsertarUsuario(usuario);
            }
            else
            {
                //Actualizacion de clientes
                UsuarioDAL.ActualizarUsuario(usuario);
            }      
       }

        public static bool Eliminar(int idUsuario)
        {
            return UsuarioDAL.EliminarUsuario(idUsuario);
        }

        public static DataTable Mostrar()
        {
            return UsuarioDAL.MostrarUsuario();

        }

        public static DataTable BuscarID(UsuarioEntity usuario)
        {
            return UsuarioDAL.BuscarID(usuario);
        }

        public static DataTable ObtenerPorValor(UsuarioEntity usuario)
        {
            return UsuarioDAL.ObtenerPorValor(usuario);
        }



    }
}

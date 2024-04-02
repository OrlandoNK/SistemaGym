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
using System.Net.NetworkInformation;

namespace SistemaGym.BLL
{
    public class UsuarioBLL
    {
         readonly UsuarioDAL usuarioDAL = new UsuarioDAL();
        public int ConsultaLogin(UsuarioEntity usuario)
        {
            return usuarioDAL.ConsultaLogin(usuario);
        }

        public static UsuarioEntity GetByID(int Id)
        {
            return UsuarioDAL.GetByID(Id);
        }
        public string GetNameFromUser(string usuario, string contraseña)
        {
           return usuarioDAL.GetNameFromUser(usuario, contraseña);
        }
        public string GetIDFromUser(string usuario, string contraseña)
        {
            return usuarioDAL.GetIDFromUser(usuario, contraseña);
        }
        public static DataTable BuscarUsuario(string busqueda)
        {
            return UsuarioDAL.Buscar(busqueda);
        }
        public static void Guardar(UsuarioEntity usuario)
        {
                UsuarioDAL.InsertarUsuario(usuario);     
        }

        public static void Update(UsuarioEntity usuario)
        {
            UsuarioDAL.ActualizarUsuario(usuario);
        }

        public static bool Eliminar(int idUsuario)
        {
            return UsuarioDAL.EliminarUsuario(idUsuario);
        }

        public static DataTable Mostrar()
        {
            return UsuarioDAL.MostrarUsuario();

        }

        public static UsuarioEntity BuscarID(int id)
        {
            return UsuarioDAL.BuscarID(id);
        }

        public static DataTable ObtenerPorValor(UsuarioEntity usuario)
        {
            return UsuarioDAL.ObtenerPorValor(usuario);
        }



    }
}

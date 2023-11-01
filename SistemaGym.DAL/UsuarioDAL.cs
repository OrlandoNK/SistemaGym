using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.Entities;

namespace SistemaGym.DAL
{
    public class UsuarioDAL : ConexionDAL
    {
        public int ConsultaLogin(UsuarioEntity usuario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            int count;
            Conexion.Open();
            string Query = "SELECT COUNT(*) FROM Usuario WHERE usuario = @Usuario AND contraseña = @Contraseña";
            SqlCommand cmd = new SqlCommand(Query, Conexion);
            cmd.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@Contraseña", usuario.Contrasena);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;
        }
    }
}

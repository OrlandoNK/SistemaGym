using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class UsuarioDAL : ConexionDAL
    {
        public int ConsultaLogin(string usuario, string contrasena)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();


            int count;
            Conexion.Open();
            string Query = "Select Count(*) From Usuario where usuario = '" + usuario + "'" +
                "and contraseña = '" + contrasena + "'";
            SqlCommand cmd = new SqlCommand(Query, Conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            Conexion.Close();

            return count;

        }
    }
}

using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace SistemaGym.DAL
{
    public class RolDAL : ConexionDAL
    {
        //metodo insertar Rol
        public static void InsertarRolDal(RolEntity rol)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Rol(Nombre, Descripcion)" +
                " values(@Nombre, @Descripcion)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@Nombre", rol.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", rol.Descripcion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar RolDal
        public static void ActualizarRolDal(RolEntity rol)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Rol set Nombre=@Nombre, Descripcion=@Descripcion where IDRol= @idRol ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);

            cmd.Parameters.AddWithValue("@Nombre", rol.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", rol.Descripcion);
            cmd.Parameters.AddWithValue("@idRol", rol.IDRol);
            cmd.ExecuteNonQuery();


        }

        public static string ObtenerRolUsuario(string usuario, string contraseña)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            string rol = string.Empty;

            try
            {
                
                {
                    Conexion.Open();
                    string consultaRol = "SELECT Rol.Nombre FROM Usuarios INNER JOIN Rol ON Usuarios.IDRol = Rol.IDRol WHERE NombreUsuario = @Usuario AND Contrasena = @Contrasena";

                    using (SqlCommand cmd = new SqlCommand(consultaRol, Conexion))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contraseña);

                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                                rol = lector["Nombre"].ToString();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                
            }
            return rol;
        }

        //funcion eliminar Rol

        public static bool EliminarRolDal(int rol)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Rol where IDRol= @idRol";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idRol", rol);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }

        public static DataTable ObtenerByValor(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM Rol WHERE IDRol LIKE @Busqueda OR Nombre LIKE @Busqueda OR Descripcion LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

        //metodo mostrar Rol
        public static DataTable MostrarRol()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Rol";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(RolEntity rol)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Rol where IDRol= @idrol";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idrol", rol.IDRol);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        
    }
}

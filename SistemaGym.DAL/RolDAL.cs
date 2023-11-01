using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class RolDAL : ConexionDAL
    {
        //metodo insertar Rol
        public static void InsertarRolDal(RolEntity RolDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into RolDal(IDRol, Nombre, Descripcion)" +
                " values(@idRol, Nombre, Descripcion)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idRol", RolDAL.IDRol);
            cmd.Parameters.AddWithValue("@Nombre", RolDAL.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", RolDAL.Descripcion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar RolDal
        public static void ActualizarRolDal(RolEntity RolDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update RolDAL set IDRol =@idRol, Nombre=@idNombre, Descripcion=@Descripcion ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idRol", RolDAL.IDRol);
            cmd.Parameters.AddWithValue("@Nombre", RolDAL.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", RolDAL.Descripcion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar Rol

        public static bool EliminarRolDal(RolEntity RolDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from RolDal where IDRol= @idRol";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idRol", RolDAL.IDRol);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar Rol
        public static DataTable MostrarRolDal()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From RolDal";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(RolEntity RolDAL)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From RolDal where IDRolDal= @idRolDal";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idRol", RolDAL.IDRol);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(RolEntity RolDAL)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from RolDal " +
                 "Where IdRol Like '%' + @idRol + '%' or Nombre Like '%' + @nombre + '%' or Descripcion Like '%' + @Descripcion";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idRol", RolDAL.IDRol);
            cmd.Parameters.AddWithValue("@nombre", RolDAL.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", RolDAL.Descripcion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

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
    public class AreaEmpresaDAL : ConexionDAL
    {
        //metodo insertar AreaEmpresa
        public static void InsertarArea(AreaEmpresaEntity areaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into AreasEmpresa(Encargado, Nombre, Descripcion, FechaCreacion" +
                " values(@encargado, @nombre, @descripcion, @fechacreacion)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@encargado", areaEmpresa.Encargado);
            cmd.Parameters.AddWithValue("@nombre", areaEmpresa.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", areaEmpresa.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", areaEmpresa.FechaCreacion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar AreaEmpresa
        public static void ActualizarArea(AreaEmpresaEntity areaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update AreasEmpresa set Encargado=@encargado, Nombre=@nombre " +
                "Descripcion =@descripcion, FechaCreacion = @fechacreacion Where IDArea = @idarea";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", areaEmpresa.IDArea);
            cmd.Parameters.AddWithValue("@encargado", areaEmpresa.Encargado);
            cmd.Parameters.AddWithValue("@nombre", areaEmpresa.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", areaEmpresa.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", areaEmpresa.FechaCreacion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar AreaEmpresa

        public static bool EliminarArea(AreaEmpresaEntity areaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from AreasEmpresa where IDArea= @idarea";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", areaEmpresa.IDArea);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar AreaEmpresa
        public static DataTable MostrarAreaEmpresa()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From AreasEmpresa Order By Nombre";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(AreaEmpresaEntity areaEmpresa)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From AreasEmpresa where IDArea= @idarea";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", areaEmpresa.IDArea);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        
       
        }
    }


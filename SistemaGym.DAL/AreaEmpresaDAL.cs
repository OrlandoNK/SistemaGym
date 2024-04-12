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
            string insertar = "INSERT INTO AreasEmpresa(Encargado, Nombre, Descripcion, FechaRegistro) VALUES(@encargado, @nombre, @descripcion, @FechaRegistro)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@encargado", areaEmpresa.Encargado);
            cmd.Parameters.AddWithValue("@nombre", areaEmpresa.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", areaEmpresa.Descripcion);
            cmd.Parameters.AddWithValue("@FechaRegistro", areaEmpresa.FechaRegistro);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar AreaEmpresa
        public static void ActualizarArea(AreaEmpresaEntity areaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "UPDATE AreasEmpresa SET Encargado = @encargado, Nombre = @nombre, Descripcion = @descripcion, FechaRegistro = @FechaRegistro WHERE IDArea = @idarea";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", areaEmpresa.IDArea);
            cmd.Parameters.AddWithValue("@encargado", areaEmpresa.Encargado);
            cmd.Parameters.AddWithValue("@nombre", areaEmpresa.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", areaEmpresa.Descripcion);
            cmd.Parameters.AddWithValue("@FechaRegistro", areaEmpresa.FechaRegistro);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar AreaEmpresa

        public static bool EliminarArea(int areaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "Delete from AreasEmpresa where IDArea= @idarea";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", areaEmpresa);
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

        public static DataTable Buscar(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM AreasEmpresa WHERE Nombre LIKE @Busqueda OR Descripcion LIKE @Busqueda OR Encargado LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

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


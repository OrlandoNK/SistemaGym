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
        public static void InsertarCliente(AreaEmpresaEntity AreaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into AreaEmpresa(IDArea, Encargado, Nombre, Descripcion, FechaCreacion" +
                " values(@idarea, @encargado, @nombre, @descripcion, @fechacreacion)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", AreaEmpresa.IDArea);
            cmd.Parameters.AddWithValue("@encargado", AreaEmpresa.Encargado);
            cmd.Parameters.AddWithValue("@nombre", AreaEmpresa.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", AreaEmpresa.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", AreaEmpresa.FechaCreacion);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar AreaEmpresa
        public static void ActualizarCliente(AreaEmpresaEntity AreaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update AreaEmpresa set IDArea =@idarea, Encargado=@encargado, Nombre=@nombre " +
                "Descripcion =@descripcion, FechaCreacion = @fechacreacion";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", AreaEmpresa.IDArea);
            cmd.Parameters.AddWithValue("@encargado", AreaEmpresa.Encargado);
            cmd.Parameters.AddWithValue("@nombre", AreaEmpresa.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", AreaEmpresa.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", AreaEmpresa.FechaCreacion);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar AreaEmpresa

        public static bool EliminarCliente(AreaEmpresaEntity AreaEmpresa)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from AreaEmpresa where IDArea= @idarea";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", AreaEmpresa.IDArea);
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
            string mostrar = "Select * From AreaEmpresa Order By Nombre";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(AreaEmpresaEntity AreaEmpresa)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From AreaEmpresa where IDArea= @idarea";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idarea", AreaEmpresa.IDArea);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(AreaEmpresaEntity AreaEmpresa)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from AreaEmpresa " +
                 "Where IDArea Like '%' + @idarea + '%' or Encargo Like '%' + @encargo + '%' or Nombre Like '%' + @nombre + '%' or " +
                 "Descripcion Like '%' + @descripcion + '%' or FechaCreacion Like '%' + @fechacreacion + '%'";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idarea", AreaEmpresa.IDArea);
            cmd.Parameters.AddWithValue("@encargado", AreaEmpresa.Encargado);
            cmd.Parameters.AddWithValue("@nombre", AreaEmpresa.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", AreaEmpresa.Descripcion);
            cmd.Parameters.AddWithValue("@fechacreacion", AreaEmpresa.FechaCreacion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

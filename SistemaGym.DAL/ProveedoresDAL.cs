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
    public class ProveedoresDAL : ConexionDAL
    {
        //metodo insertar cliente
        public static void InsertarCliente(ProveedoresEntity ProveedoresDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into ProveedoresDAL(IDProveedores, Nombre, Telefono, Direccion," +
                " FechaRegistro, Estatus)" +
                " values(@idProveedores, @Nombre, @Telefono, @Direccion, @FechaRegistro, @Estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idProveedores", ProveedoresDAL.IDProveedores);
            cmd.Parameters.AddWithValue("@Nombre", ProveedoresDAL.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", ProveedoresDAL.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", ProveedoresDAL.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", ProveedoresDAL.FechaRegistro);
            cmd.Parameters.AddWithValue("@Estatus", ProveedoresDAL.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar ProveedoresDAl
        public static void ActualizarCliente(ProveedoresEntity ProveedoresDAL)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update ProveedoresDAL set IDProveedores =@idProveedores, Nombre=@Nombre, Telefono=@Telefono " +
                "Direccion =@Direccion, FechaRegistro=@FechaRegistro, Estatus =@Estatus";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idProveedores", ProveedoresDAL.IDProveedores);
            cmd.Parameters.AddWithValue("@Nombre", ProveedoresDAL.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", ProveedoresDAL.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", ProveedoresDAL.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", ProveedoresDAL.FechaRegistro);
            cmd.Parameters.AddWithValue("@Estatus", ProveedoresDAL.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar ProveedoresDAL

        public static bool EliminarCliente(ProveedoresEntity ProveedoresDAl)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from ProveedoresDAL where IDProveedores= @idProveedores";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idProveedores", ProveedoresDAl.IDProveedores);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar cliente
        public static DataTable MostrarProveedoresDAL()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From ProveedoresDAL";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(ProveedoresEntity ProveedoresDAL)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From ProveedoresDAL where IDProveedores= @idProveedores";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idProveedores", ProveedoresDAL.IDProveedores);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(ProveedoresEntity ProveedoresDAL)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from ProveedoresDAL " +
                 "Where IDProveedores Like '%' + @idProveedores + '%' or Nombre Like '%' + @nombre + '%' or Telefono Like '%' + @Telefono + '%' or " +
                 "Direccion Like '%' + @Direccion '%' or FechaRegistro Like '%' + @FechaRegistro + '%' or Estatus Like '%' + @Estatus + '%' " +
                 "TelRes Like '%' + @telres + '%' or Estatus Like '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idProveedores", ProveedoresDAL.IDProveedores);
            cmd.Parameters.AddWithValue("@nombre", ProveedoresDAL.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", ProveedoresDAL.Telefono);
            cmd.Parameters.AddWithValue("@direccion", ProveedoresDAL.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", ProveedoresDAL.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", ProveedoresDAL.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

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
        public static void InsertarProveedores(ProveedoresEntity proveedores)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Proveedores(Nombre, Telefono, Direccion," +
                " FechaRegistro, Estatus)" +
                " values(@Nombre, @Telefono, @Direccion, @FechaRegistro, @Estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@Nombre", proveedores.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", proveedores.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", proveedores.FechaRegistro);
            cmd.Parameters.AddWithValue("@Estatus", proveedores.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar ProveedoresDAl
        public static void ActualizarProveedores(ProveedoresEntity proveedores)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update ProveedoresDAL set Nombre=@Nombre, Telefono=@Telefono " +
                "Direccion =@Direccion, FechaRegistro=@FechaRegistro, Estatus =@Estatus";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@Nombre", proveedores.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", proveedores.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", proveedores.FechaRegistro);
            cmd.Parameters.AddWithValue("@Estatus", proveedores.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar ProveedoresDAL

        public static bool EliminarProveedores(int Id)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Proveedores where IDProveedor= @idProveedor";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idProveedor", Id);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }

        //metodo mostrar cliente
        public static DataTable MostrarProveedores()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Proveedores";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(ProveedoresEntity proveedores)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Proveedores where IDProveedor= @idproveedor";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idproveedor", proveedores.IDProveedor);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(ProveedoresEntity proveedores)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from Proveedores " +
                 "Where Nombre Like '%' + @nombre + '%' or Telefono Like '%' + @Telefono + '%' or " +
                 "Direccion Like '%' + @Direccion '%' or FechaRegistro Like '%' + @FechaRegistro + '%' or Estatus Like '%' + @Estatus + '%' " +
                 "TelRes Like '%' + @telres + '%' or Estatus Like '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@nombre", proveedores.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", proveedores.Telefono);
            cmd.Parameters.AddWithValue("@direccion", proveedores.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", proveedores.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", proveedores.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}

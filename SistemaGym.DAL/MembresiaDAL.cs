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
    public class MembresiaDAL : ConexionDAL
    {
        //metodo insertar membresia
        public static void InsertarMembresia(MembresiaEntity membresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Membresia(Nombre, Descripcion, Duracion, Valor , FechaCreacion, Estatus)" +
                " values(@idmembresia, @nombre, @descripcion, @duracion, @valor, @fechacreacion, @estatus ";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", membresia.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", membresia.Descripcion);
            cmd.Parameters.AddWithValue("@duracion", membresia.Duracion);
            cmd.Parameters.AddWithValue("@valor", membresia.Valor);
            cmd.Parameters.AddWithValue("@fechacreacion", membresia.FechaCreacion);
            cmd.Parameters.AddWithValue("@estatus", membresia.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar membresia
        public static void ActualizarMembresia(MembresiaEntity membresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Membresia Set Nombre =@idnombre, Descripcion =@descripcion," + 
                " Duracion =@duracion, Valor =@Valor, FechaCreacion =@fechacreacion, Estatus =@estatus";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@nombre", membresia.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", membresia.Descripcion);
            cmd.Parameters.AddWithValue("@duracion", membresia.Duracion);
            cmd.Parameters.AddWithValue("@valor", membresia.Valor);
            cmd.Parameters.AddWithValue("@fechacreacion", membresia.FechaCreacion);
            cmd.Parameters.AddWithValue("@estatus", membresia.Estatus);
            cmd.ExecuteNonQuery();

        }
        //funcion eliminar membresia

        public static bool EliminarMembresia(MembresiaEntity membresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string eliminar = "Delete from Membresia where IDMembresia= @idmembresia";
            SqlCommand cmd = new SqlCommand(eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", membresia.IDMembresia);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar membresias
        public static DataTable MostrarMembresia()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Membresia";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        //buscar por id
        public static DataTable BuscarID(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Clientes where IDMembresia= @idmembresia";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //obtener valor de la base de datos en tabla membresia
        public static DataTable ObtenerPorValor(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from Clientes " +
                 "Where IDMembresia Like '%' + @idmembresia + '%' or Nombre Like '%' + @nombre + '%' or Apellido Like '%' + @apellido + '%' or " +
                 "Documento Like '%' + @Documento '%' or Direccion Like '%' + @Direccion + '%' or TelCell Like '%' + @telcell + '%' " +
                 "TelRes Like '%' + @telres + '%' or Estatus Like '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", clientes.IDMembresia);
            cmd.Parameters.AddWithValue("@nombre", clientes.Nombre);
            cmd.Parameters.AddWithValue("@apellido", clientes.Apellido);
            cmd.Parameters.AddWithValue("@documento", clientes.Documento);
            cmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            cmd.Parameters.AddWithValue("@telcell", clientes.TelCell);
            cmd.Parameters.AddWithValue("@telres", clientes.TelRes);
            cmd.Parameters.AddWithValue("@estatus", clientes.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}

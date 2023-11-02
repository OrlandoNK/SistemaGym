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
    public class ActividadesDAL :ConexionDAL
    {
        //metodo insertar Actividades
        public static void InsertarActividad(ActividadesEntity actividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Actividades(IDTiposActividades, Area, EncargadoActividad, Dia, HoraInicio, HoraCierre, Estatus) " +
                "values(@idtiposactividades, @area, @encargadoactividad, @dia, @horainicio, @horacierre, @estatus)";
                
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", actividades.IDTipoActividades);
            cmd.Parameters.AddWithValue("@area", actividades.Area);
            cmd.Parameters.AddWithValue("@encargadoactividad", actividades.EncargadoActividad);
            cmd.Parameters.AddWithValue("@dia", actividades.Dia);
            cmd.Parameters.AddWithValue("@horainicio", actividades.HoraInicio);
            cmd.Parameters.AddWithValue("@horacierre", actividades.HoraCierre);
            cmd.Parameters.AddWithValue("@estatus", actividades.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar cliente
        public static void ActualizarActividad(ClientesEntity clientes)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Clientes set IDUsuario =@idusuario, IDMembresia=@idmembresia, TipoListaCliente=@tipolistacliente " +
                "TipoCliente =@tipocliente, Nombre=@nombre, Apellido =@apellido, TipoDocumento=@tipodocumento, documento=@documento " +
                "Direccion =@direccion, Telcell=@telcell, TelRes=@telres, FechaRegistro =@fecharegistro, Estatus =@estatus ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idusuario", clientes.IDUsuario);
            cmd.Parameters.AddWithValue("@idmembresia", clientes.IDMembresia);
            cmd.Parameters.AddWithValue("@tipolistacliente", clientes.TipoListaCliente);
            cmd.Parameters.AddWithValue("@tipocliente", clientes.TipoCliente);
            cmd.Parameters.AddWithValue("@nombre", clientes.Nombre);
            cmd.Parameters.AddWithValue("@apellido", clientes.Apellido);
            cmd.Parameters.AddWithValue("@tipodocumento", clientes.TipoDocumento);
            cmd.Parameters.AddWithValue("@documento", clientes.Documento);
            cmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            cmd.Parameters.AddWithValue("@telcell", clientes.TelCell);
            cmd.Parameters.AddWithValue("@telres", clientes.TelRes);
            cmd.Parameters.AddWithValue("@fecharegistro", clientes.FechaRegistro);
            cmd.Parameters.AddWithValue("@estatus", clientes.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar cliente

        public static bool EliminarActividad(ClientesEntity clientes)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar cliente
        public static DataTable MostrarCliente()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Clientes";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
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

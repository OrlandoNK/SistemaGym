using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace SistemaGym.DAL
{
    public class EmpleadoDAL : ConexionDAL
    {
        /* Metodo para Insertar Empleado */

        public static void insertarEmpleado(EmpleadoEntity empleado)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Insertar = "INSERT INTO Empleados(Nombre, Apellido, TipoDocumento, Documento, Direccion, TellCell, TellRes, FechaRegistro, Estatus)" +
                              " VALUES(@Nombre, @Apellido, @TipoDocumento, @Documento, @Direccion, @TellCell, @TellRes, @FechaRegistro, @Estatus)";

            SqlCommand cmnd = new SqlCommand(Insertar, Conexion);
            cmnd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmnd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmnd.Parameters.AddWithValue("@TipoDocumento", empleado.TipoDocumento);
            cmnd.Parameters.AddWithValue("@Documento", empleado.Documento);
            cmnd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
            cmnd.Parameters.AddWithValue("@TellCell", empleado.TellCell);
            cmnd.Parameters.AddWithValue("@TellRes", empleado.TelRes);
            cmnd.Parameters.AddWithValue("@FechaRegistro", empleado.FechaRegistro);
            cmnd.Parameters.AddWithValue("@Estatus", empleado.Estatus);

            cmnd.ExecuteNonQuery();

        }

        /* Metodo para Actualizar Empleado */

        public static void actualizarEmpleado(EmpleadoEntity empleado)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Actualizar = "UPDATE Empleados SET Nombre = @Nombre, Apellido = @Apellido, TipoDocumento = @Tipodocumento, Documento = @Documento, Direccion = @Direccion, TellCell = @TellCell, TellRes = @TellRes, FechaRegistro = @FechaRegistro, Estatus = @Estatus WHERE IDEmpleado = @IDEmpleado";

            SqlCommand cmd = new SqlCommand(Actualizar, Conexion);
            cmd.Parameters.AddWithValue("@IDEmpleado", empleado.IDEmpleado);
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@TipoDocumento", empleado.TipoDocumento);
            cmd.Parameters.AddWithValue("@Documento", empleado.Documento);
            cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
            cmd.Parameters.AddWithValue("@TellCell", empleado.TellCell);
            cmd.Parameters.AddWithValue("@TellRes", empleado.TelRes);
            cmd.Parameters.AddWithValue("@FechaRegistro", empleado.FechaRegistro);
            cmd.Parameters.AddWithValue("@Estatus", empleado.Estatus);

            cmd.ExecuteNonQuery();

        }

        /* Metodo Eliminar Empleado poor ID */

        public bool eliminarEmpleado(int empleado)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            bool seElimino;


            Conexion.Open();
            string Delete = "DELETE FROM Empleados WHERE IDEmpleado = @IDEmpleado";
            SqlCommand cmnd = new SqlCommand(Delete, Conexion);

            cmnd.Parameters.AddWithValue("@IDEmpleado", empleado);
            seElimino = cmnd.ExecuteNonQuery() > 0;


            return seElimino;

        }

        /* Metodo para Mostrar Empleados */

        public static DataTable mostrarEmpleado()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            DataTable dtbl = new DataTable();
            Conexion.Open();
            string mostrar = "SELECT * FROM Empleados";
            SqlCommand cmnd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmnd);
            adapterDT.Fill(dtbl);

            return dtbl;

        }

        public DataTable SearchByID(EmpleadoEntity empleado)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            DataTable dataTBL = new DataTable();
            string Buscar = "SELECT * FROM Empleados WHERE IDEmpleado = @IDEmpleado";
            SqlCommand command = new SqlCommand(Buscar, Conexion);
            command.Parameters.AddWithValue("@IDEmpleado", empleado.IDEmpleado);
            SqlDataAdapter adaptDT = new SqlDataAdapter(command);
            adaptDT.Fill(dataTBL);

            return dataTBL;
        }


        /* Metodo Obtener por Valor */
        public static DataTable GetByValor(EmpleadoEntity empleado)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            DataTable dataTBL = new DataTable();
            string GetValor = "SELECT * FROM Empleados " + 
                              "WHERE Nombre LIKE '%' + @Nombre + '%' OR Apellido LIKE '%' @Apellido + '%' OR" +
                              "TipoDocumento LIKE '%' + @TipoDocumento + '%' OR Documento LIKE '%' + @Documento + '%' OR Direccion LIKE '%' + @Direccion + '%' OR" +
                              "TellCell LIKE '%' + @TellCell + '%' OR TelRes LIKE '%' + @TelRes + '%' OR FechaRegistro LIKE '%' + @FechaRegistro + '%' OR Estatus LIKE '%' + @Estatus + '% ORDER BY Nombre'";

            SqlCommand cmnd = new SqlCommand(GetValor, Conexion);
            cmnd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            cmnd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
            cmnd.Parameters.AddWithValue("@TipoDocumento", empleado.TipoDocumento);
            cmnd.Parameters.AddWithValue("@Docuemnto", empleado.Documento);
            cmnd.Parameters.AddWithValue("@Direccion", empleado.Direccion);
            cmnd.Parameters.AddWithValue("@TellCell", empleado.TellCell);
            cmnd.Parameters.AddWithValue("@TelRes", empleado.TelRes);
            cmnd.Parameters.AddWithValue("@FechaRegistro", empleado.FechaRegistro);
            cmnd.Parameters.AddWithValue("@Estatus", empleado.Estatus);

            SqlDataAdapter adapterDT = new SqlDataAdapter(cmnd);
            adapterDT.Fill(dataTBL);

            return dataTBL;

        }

        /* Metodo Buscar */

        public static DataTable Buscar(string busqueda)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM Empleados WHERE Nombre LIKE @Busqueda OR Apellido LIKE @Busqueda OR Documento LIKE @Busqueda OR TellCell LIKE @Busqueda OR TellRes LIKE @Busqueda";
            using (SqlCommand cmd = new SqlCommand(GetByValor, Conexion))
            {
                cmd.Parameters.AddWithValue("@Busqueda", "%" + busqueda + "%");
                SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
                adapterDT.Fill(dataTBL);
            }
            return dataTBL;

        }

        /* GETBYID */

        public static EmpleadoEntity GetByID(int Id)
        {
            EmpleadoEntity empleado = null;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            string GetID = "SELECT * FROM Empleados WHERE IDEmpleado = @IDEmpleado";
                SqlCommand cmd = new SqlCommand(GetID, Conexion);
                cmd.Parameters.AddWithValue("@IDEmpleado", Id);
                SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                empleado = ConvertToObject(reader);
            }
            

            return empleado;
        }

        private static EmpleadoEntity ConvertToObject(IDataReader reader)
        {
            EmpleadoEntity empleado = new EmpleadoEntity();

            empleado.IDEmpleado = Convert.ToInt32(reader["IDEmpleado"]);
            empleado.Nombre = Convert.ToString(reader["Nombre"]);
            empleado.Apellido = Convert.ToString(reader["Apellido"]);
            empleado.Direccion = Convert.ToString(reader["Direccion"]);

            return empleado;
        }

    }
}

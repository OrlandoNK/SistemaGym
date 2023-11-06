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
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Insertar = "INSERT INTO Empleados(IDUsuario, Nombre, Apellido, TipoDocumento, Documento, Direccion, TellCell, TelRes, FechaRegistro, Estatus)" +
                              " VALUES(@IDUsuario, @Nombre, @Apellido, @TipoDocumento, @Documento, @Direccion, @TellCell, @TelRes, @FechaRegistro, @Estatus)";

            SqlCommand cmnd = new SqlCommand(Insertar, Conexion);
            cmnd.Parameters.AddWithValue("@IDUsuario", empleado.IDUsuario);
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
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Actualizar = "UPDATE Empleados SET IDUsuario = @IDUsuario, Nombre = @Nombre, Apellido = @Apellido, TipoDocumento = @Tipodocumento, Documento = @Documento, Direccion = @Direccion, TellCell = @TellCell, TelRes = @TelRes, FechaRegistro = @FechaRegistro, Estatus = @Estatus";

            SqlCommand cmd = new SqlCommand(Actualizar, Conexion);
            cmd.Parameters.AddWithValue("@IDUsuario", empleado.IDUsuario);
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

        public bool eliminarEmpleado(EmpleadoEntity empleado)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            bool seElimino;


            Conexion.Open();
            string Delete = "DELETE FROM Empleados WHERE IDEmpleado = @IDEmpleado";
            SqlCommand cmnd = new SqlCommand(Delete, Conexion);

            cmnd.Parameters.AddWithValue("@IDEmpleado", empleado.IDEmpleado);
            seElimino = cmnd.ExecuteNonQuery() > 0;


            return seElimino;

        }

        /* Metodo para Mostrar Empleados */

        public static DataTable mostrarEmpleado()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

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
                              "WHERE IDUsuario LIKE '%' + @IDUsuario + '%' OR Nombre LIKE '%' + @Nombre + '%' OR Apellido LIKE '%' @Apellido + '%' OR" +
                              "TipoDocumento LIKE '%' + @TipoDocumento + '%' OR Documento LIKE '%' + @Documento + '%' OR Direccion LIKE '%' + @Direccion + '%' OR" +
                              "TellCell LIKE '%' + @TellCell + '%' OR TelRes LIKE '%' + @TelRes + '%' OR FechaRegistro LIKE '%' + @FechaRegistro + '%' OR Estatus LIKE '%' + @Estatus + '% ORDER BY Nombre'";

            SqlCommand cmnd = new SqlCommand(GetValor, Conexion);
            cmnd.Parameters.AddWithValue("@IDUsuario", empleado.IDUsuario);
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

    }
}

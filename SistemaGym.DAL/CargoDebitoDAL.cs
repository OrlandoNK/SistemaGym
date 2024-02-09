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
    public class CargoDebitoDAL : ConexionDAL
    {
        //metodo insertar cargoDebito
        public static void InsertarCargoDebito(CargoDebitoEntity cargoDebito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into CargoDebito(IDCliente, Cargo, Monto, FechaCargo, Estatus)" +
                " values(@idcliente, @cargo, @monto, @fechacargo, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", cargoDebito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoDebito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoDebito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoDebito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoDebito.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar cargo debito
        public static void ActualizarCargoDebito(CargoDebitoEntity cargoDebito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update CargoDebito set IDCliente =@idcliente, Cargo =@cargo, FechaCargo =@fechacargo, Estatus =@estatus";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", cargoDebito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoDebito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoDebito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoDebito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoDebito.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar cargo credito

        public static bool EliminarCargoDebito(CargoDebitoEntity cargoDebito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from CargoDebito where IDCargoDebito= @idcargodebito";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idcargodebito", cargoDebito.IDCargoDebito);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar cargo Debito
        public static DataTable MostrarCargoDebito()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From CargoDebito";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        //buscar por id
        public static DataTable BuscarID(CargoDebitoEntity cargoDebito)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From CargoDebito where IDCargoDebito= @idcargodebito";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcargodebito", cargoDebito.IDCargoDebito);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //obtener valor cargo Debito
        public static DataTable ObtenerPorValor(CargoDebitoEntity cargoDebito)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from CargoDebito " +
                 "Where IDCliente '%' + @idcliente + '%' or Cargo '%' + @cargo + '%' or Monto '%' + @monto + '%' or FechaCargo '%' + @fechacargo + '%' or Estatus '%' + @estatus + '%' Order By IDCliente";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", cargoDebito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoDebito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoDebito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoDebito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoDebito.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static CargoDebitoEntity GetByID(int Id)
        {
            CargoDebitoEntity cargoDebito = null;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            string GetID = "SELECT * FROM CargoDebito WHERE IDCargoDebito = @IDCargoDebito";
            SqlCommand cmd = new SqlCommand(GetID, Conexion);
            cmd.Parameters.AddWithValue("@IDCargoDebito", Id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cargoDebito = ConvertToObject(reader);
            }

            return cargoDebito;
        }

        private static CargoDebitoEntity ConvertToObject(IDataReader reader)
        {
            CargoDebitoEntity _cargoCredito = new CargoDebitoEntity();

            _cargoCredito.IDCargoDebito = Convert.ToInt32(reader["IDCargoDebito"]);
            _cargoCredito.IDCliente = Convert.ToInt32(reader["IDCliente"]);
            _cargoCredito.Cargo = Convert.ToString(reader["Cargo"]);
            _cargoCredito.Monto = Convert.ToDecimal(reader["Monto"]);
            _cargoCredito.FechaCargo = Convert.ToDateTime(reader["FechaCargo"]);
            _cargoCredito.Estatus = Convert.ToString(reader["Estatus"]);

            return _cargoCredito;
        }
    }
}

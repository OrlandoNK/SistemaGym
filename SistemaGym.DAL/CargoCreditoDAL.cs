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
    public class CargoCreditoDAL : ConexionDAL
    {
        //metodo insertar cargoCredito
        public static void InsertarCargoCredito(CargoCreditoEntity cargoCredito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into CargoCredito(IDCliente, Cargo, Monto, FechaCargo, Estatus)" +
                " values(@idcliente, @cargo, @monto, @fechacargo, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", cargoCredito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoCredito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoCredito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoCredito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoCredito.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar cargocredito
        public static void ActualizarCargoCredito(CargoCreditoEntity cargoCredito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update CargoCredito set IDCliente =@idcliente, Cargo =@cargo, FechaCargo =@fechacargo, Estatus =@estatus where IDCargoCredito= @idcargocredito ";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idcargocredito", cargoCredito.IDCargoCredito);
            cmd.Parameters.AddWithValue("@idcliente", cargoCredito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoCredito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoCredito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoCredito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoCredito.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar cargo credito

        public static bool EliminarCargoCredito(CargoCreditoEntity cargoCredito)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from CargoCredito where IDCargoCredito= @idcargocredito";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idcargocredito", cargoCredito.IDCargoCredito);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar cargo credito
        public static DataTable MostrarCargoCredito()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From CargoCredito Order by fechaCargo DESC";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        //buscar por id
        public static DataTable BuscarID(CargoCreditoEntity cargoCredito)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From CargoCredito where IDCargoCredito= @idcargocredito";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcargocredito", cargoCredito.IDCargoCredito);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //obtener valor cargo credito
        public static DataTable ObtenerPorValor(CargoCreditoEntity cargoCredito)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from CargoCredito " +
                 "Where IDCliente '%' + @idcliente + '%' or Cargo '%' + @cargo + '%' or Monto '%' + @monto + '%' or FechaCargo '%' + @fechacargo + '%' or Estatus '%' + @estatus + '%' Order By IDCliente";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", cargoCredito.IDCliente);
            cmd.Parameters.AddWithValue("@cargo", cargoCredito.Cargo);
            cmd.Parameters.AddWithValue("@monto", cargoCredito.Monto);
            cmd.Parameters.AddWithValue("@fechacargo", cargoCredito.FechaCargo);
            cmd.Parameters.AddWithValue("@estatus", cargoCredito.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static CargoCreditoEntity GetByID(int Id)
        {
            CargoCreditoEntity cargoCredito = null;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            string GetID = "SELECT * FROM CargoCredito WHERE IDCargoCredito = @IDCargoCredito";
            SqlCommand cmd = new SqlCommand(GetID, Conexion);
            cmd.Parameters.AddWithValue("@IDCargoCredito", Id);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cargoCredito = ConvertToObject(reader);
            }

            return cargoCredito;
        }

        private static CargoCreditoEntity ConvertToObject(IDataReader reader)
        {
            CargoCreditoEntity _cargoCredito = new CargoCreditoEntity();

            _cargoCredito.IDCargoCredito = Convert.ToInt32(reader["IDCargoCredito"]);
            _cargoCredito.IDCliente = Convert.ToInt32(reader["IDCliente"]);
            _cargoCredito.Cargo = Convert.ToString(reader["Cargo"]);
            _cargoCredito.Monto = Convert.ToDecimal(reader["Monto"]);
            _cargoCredito.FechaCargo = Convert.ToDateTime(reader["FechaCargo"]);
            _cargoCredito.Estatus = Convert.ToString(reader["Estatus"]);

            return _cargoCredito;
        }
    }
}

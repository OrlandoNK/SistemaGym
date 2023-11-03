using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class BlacklistClienteDAL : ConexionDAL
    {
        /* Metodo para Insertar */
        public static void Insertar(BlacklistClienteEntity blacklist)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Insertar = "INSERT INTO BlacklistCliente(IDBlackListCliente, IDListaCliente, IDCliente, Razones, FechaInicial, FechaVencimiento, Estatus) " +
                              " VALUES(@IDBlackListCliente, @IDListaCliente, @IDCliente, @Razones, @FechaInicial, @FechaVencimiento, @Estatus)";

            SqlCommand cmd = new SqlCommand(Insertar, Conexion);
            cmd.Parameters.AddWithValue("@IDBlackListCliente", blacklist.IDBlackListCliente);
            cmd.Parameters.AddWithValue("@IDListaCliente", blacklist.IDListaCliente);
            cmd.Parameters.AddWithValue("@IDCliente", blacklist.IDCliente);
            cmd.Parameters.AddWithValue("@Razones", blacklist.Razones);
            cmd.Parameters.AddWithValue("@FechaInicial", blacklist.FechaInicial);
            cmd.Parameters.AddWithValue("@FechaVencimiento", blacklist.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", blacklist.Estatus);

            cmd.ExecuteNonQuery();

        }

        /* Metodo Actualizar */

        public static void Actualizar(BlacklistClienteEntity blacklist)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();

            string Actualizar = "UPDATE BlacklistCliente SET IDBlackListCliente = @IDBlackListCliente, IDListaCliente = @IDListaCliente, IDCliente = @IDCliente, Razones = @Razones, FechaInicial = @FechaInicial, FechaVencimiento = @FechaVencimiento, Estatus = @Estatus";
            SqlCommand cmd = new SqlCommand(Actualizar, Conexion);

            cmd.Parameters.AddWithValue("@IDBlackListCliente", blacklist.IDBlackListCliente);
            cmd.Parameters.AddWithValue("@IDListaCliente", blacklist.IDListaCliente);
            cmd.Parameters.AddWithValue("@IDCliente", blacklist.IDCliente);
            cmd.Parameters.AddWithValue("@Razones", blacklist.Razones);
            cmd.Parameters.AddWithValue("@FechaInicial", blacklist.FechaInicial);
            cmd.Parameters.AddWithValue("@FechaVencimiento", blacklist.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", blacklist.Estatus);

            cmd.ExecuteNonQuery();

        }

        /* Metodo Eliminar */

        public static bool EliminarByID(BlacklistClienteEntity blacklist)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;

            Conexion.Open();
            string Eliminar = "DELETE FROM BlacklistCliente WHERE IDBlackListCliente = @IDBlackListCliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);

            cmd.Parameters.AddWithValue("@IDBlackListCliente", blacklist.IDBlackListCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;

            return seElimino;

        }

    }
}

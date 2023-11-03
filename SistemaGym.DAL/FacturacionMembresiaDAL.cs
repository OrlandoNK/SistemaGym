using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class FacturacionMembresiaDAL : ConexionDAL
    {
        /* Metodo Insertar */

        public static void Insertar(FacturaMembresiaEntity facturaMembresia)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Insertar = "INSERT INTO FacturacionMembresia(IDFactura, IDMembresia, IDCliente, IDUsuario, NCF, FechaEmision, FechaVencimiento, Estatus) " +
                              " VALUES(@IDFactura, @IDMembresia, @IDCliente, @IDUsuario, @NCF, @FechaEmision, @FechaVencimiento, @Estatus)";

            SqlCommand cmd = new SqlCommand(Insertar, Conexion);
            cmd.Parameters.AddWithValue("@IDFactura", facturaMembresia.IDFactura);
            cmd.Parameters.AddWithValue("@IDMembresia", facturaMembresia.IDMembresia);
            cmd.Parameters.AddWithValue("@IDCliente", facturaMembresia.IDCliente);
            cmd.Parameters.AddWithValue("@IDUsuario", facturaMembresia.IDUsuario);
            cmd.Parameters.AddWithValue("@NCF", facturaMembresia.NCF);
            cmd.Parameters.AddWithValue("@FechaEmision", facturaMembresia.FechaEmision);
            cmd.Parameters.AddWithValue("@FechaVencimiento", facturaMembresia.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", facturaMembresia.Estatus);

            cmd.ExecuteNonQuery();

        }

        /* Metodo Actualizar */

        public static void Actualizar(FacturaMembresiaEntity facturaMembresia)
        {

        }

    }
}

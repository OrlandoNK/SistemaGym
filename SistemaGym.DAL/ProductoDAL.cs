using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class ProductoDAL : ConexionDAL
    {
        /* Metodo para Insertar Producto */
        public static void InsertarProductos(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Insertar = "INSERT INTO(Categorias, No_Existencias, Nombre, PrecioUnitario) VALUES(@Categorias, @No_Existencias, @Nombre, @PrecioUnitario)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion);

            cmd.Parameters.AddWithValue("@Categorias", producto.Categorias);
            cmd.Parameters.AddWithValue("@No_Existencias", producto.No_Existencias);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

            cmd.ExecuteNonQuery();

        }
    }
}

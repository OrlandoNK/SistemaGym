﻿using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
            string Insertar = "INSERT INTO Productos (Categoria, Nombre, PrecioUnitario, No_Existencias) VALUES(@Categoria, @Nombre, @PrecioUnitario, @No_Existencias,)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion);

            cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
            cmd.Parameters.AddWithValue("@No_Existencias", producto.No_Existencias);
            
           

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Actualizar Productos */

        public static void UpdateProduct(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string UpdateProduct = "UPDATE Producto SET Categoria = @Categoria, Nombre = @Nombre, No_Existencias = @No_Existencias, PrecioUnitario = @PrecioUnitario";
            SqlCommand cmd = new SqlCommand(UpdateProduct, Conexion);

            cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@No_Existencias", producto.No_Existencias);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Eliminar un Producto por ID */
        public bool DeleteProduct(ProductoEntity producto)
        {
            bool productDeleted;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Delete = "DELETE FROM Producto WHERE IDProducto = @IDProducto";
            SqlCommand cmd = new SqlCommand(Delete, Conexion);

            cmd.Parameters.AddWithValue("@IDProducto", producto.IDProducto);
            productDeleted = cmd.ExecuteNonQuery() > 0;

            return productDeleted;

        }

        /* Metodo para Mostrar Productos */
        public static DataTable mostrarProductos()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            DataTable dataTBL = new DataTable();

            Conexion.Open();
            string Mostrar = "SELECT * FROM Producto Order by Nombre";
            SqlCommand cmnd = new SqlCommand(Mostrar, Conexion);
            SqlDataAdapter adapterDTBL = new SqlDataAdapter(cmnd);
            adapterDTBL.Fill(dataTBL);

            return dataTBL;

        }

        /* Metodo par Buscar por ID */
        public DataTable BuscarByID(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            DataTable dataTBL = new DataTable();

            string Buscar = "SELECT * FROM Producto WHERE IDProducto = @IDProducto";
            SqlCommand cmnd = new SqlCommand(Buscar, Conexion);
            cmnd.Parameters.AddWithValue("@IDProducto", producto.IDProducto);
            SqlDataAdapter adapterDTBL = new SqlDataAdapter(cmnd);
            adapterDTBL.Fill(dataTBL);

            return dataTBL;
        }

        /* Metodo Obtener por Valor */
        public DataTable GetByValor(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            DataTable dataTBL = new DataTable();
            string GetValor = "SELECT * FROM Producto " +
                              "WHERE Categoria LIKE '%' + @Categoria + '%' or Nombre LIKE '%' + @Nombre + '%' ORDER BY Nombre";

            SqlCommand cmnd = new SqlCommand(GetValor, Conexion);
            cmnd.Parameters.AddWithValue("@Categoria", producto.Categoria);
            cmnd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            SqlDataAdapter adaptTBL = new SqlDataAdapter(cmnd);
            adaptTBL.Fill(dataTBL);

            return dataTBL;

        }

    }
}

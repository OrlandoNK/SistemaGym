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
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Insertar = "INSERT INTO Productos (Categoria, IDProveedor, Nombre, PrecioUnitario, Stock) VALUES(@Categoria, @IDProveedor, @Nombre, @PrecioUnitario, @Stock)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion);

            cmd.Parameters.AddWithValue("@Categoria", producto.IDCategoria);
            cmd.Parameters.AddWithValue("@IDProveedor", producto.IDProveedor);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);
            
           

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Actualizar Productos */

        public static void UpdateProduct(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string UpdateProduct = "UPDATE Productos SET Categoria = @Categoria, IDProveedor= @IDProveedor, Nombre = @Nombre, PrecioUnitario = @PrecioUnitario, Stock = @Stock Where IDProducto= @IDProducto";
            SqlCommand cmd = new SqlCommand(UpdateProduct, Conexion);

            cmd.Parameters.AddWithValue("@Categoria", producto.IDCategoria);
            cmd.Parameters.AddWithValue("@IDProducto", producto.IDProducto);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@IDProveedor", producto.IDProveedor);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Eliminar un Producto por ID */
        public bool DeleteProduct(ProductoEntity producto)
        {
            bool productDeleted;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string Delete = "DELETE FROM Productos WHERE IDProducto = @IDProducto";
            SqlCommand cmd = new SqlCommand(Delete, Conexion);

            cmd.Parameters.AddWithValue("@IDProducto", producto.IDProducto);
            productDeleted = cmd.ExecuteNonQuery() > 0;

            return productDeleted;

        }

        /* Metodo para Mostrar Productos */
        public static DataTable mostrarProductos()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            DataTable dataTBL = new DataTable();

            Conexion.Open();
            string Mostrar = "SELECT * FROM Productos Order by Nombre";
            SqlCommand cmnd = new SqlCommand(Mostrar, Conexion);
            SqlDataAdapter adapterDTBL = new SqlDataAdapter(cmnd);
            adapterDTBL.Fill(dataTBL);

            return dataTBL;

        }

        /* Metodo par Buscar por ID */
        public static DataTable BuscarByID(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dataTBL = new DataTable();

            string Buscar = "SELECT * FROM Productos WHERE IDProducto = @IDProducto";
            SqlCommand cmnd = new SqlCommand(Buscar, Conexion);
            cmnd.Parameters.AddWithValue("@IDProducto", producto.IDProducto);
            SqlDataAdapter adapterDTBL = new SqlDataAdapter(cmnd);
            adapterDTBL.Fill(dataTBL);

            return dataTBL;
        }

        /* Metodo Obtener por Valor */
        public static DataTable GetByValor(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dataTBL = new DataTable();
            string GetValor = "SELECT * FROM Productos " +
                              "WHERE Categoria LIKE '%' + @Categoria + '%' or IDProveedor LIKE '%' + @IDProveedor + '%' or Nombre LIKE '%' + @Nombre + '%' ORDER BY Nombre";

            SqlCommand cmd = new SqlCommand(GetValor, Conexion);
            cmd.Parameters.AddWithValue("@Categoria", producto.IDCategoria);
            cmd.Parameters.AddWithValue("@IDProveedor", producto.IDProveedor);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            SqlDataAdapter adaptTBL = new SqlDataAdapter(cmd);
            adaptTBL.Fill(dataTBL);

            return dataTBL;

        }

    }
}

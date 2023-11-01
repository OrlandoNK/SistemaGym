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
            string Insertar = "INSERT INTO(Categorias, No_Existencias, Nombre, PrecioUnitario) VALUES(@Categorias, @No_Existencias, @Nombre, @PrecioUnitario)";
            SqlCommand cmd = new SqlCommand(Insertar, Conexion);

            cmd.Parameters.AddWithValue("@Categorias", producto.Categorias);
            cmd.Parameters.AddWithValue("@No_Existencias", producto.No_Existencias);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Actualizar Productos */

        public static void UpdateProduct(ProductoEntity producto)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string UpdateProduct = "UPDATE Producto SET Categorias = @Categorias, No_Existencias = @No_Existencias, Nombre = @Nombre, PrecioUnitario = @PrecioUnitario";
            SqlCommand cmd = new SqlCommand(UpdateProduct, Conexion);

            cmd.Parameters.AddWithValue("@Categorias", producto.Categorias);
            cmd.Parameters.AddWithValue("@No_Existencias", producto.No_Existencias);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);

            cmd.ExecuteNonQuery();

        }

        /* Metodo para Eliminar un Producto por ID */
        public bool DeleteProduct(int Id)
        {
            bool productDeleted;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Delete = "DELETE FROM Producto WHERE IDProductos = @IDProductos";
            SqlCommand cmd = new SqlCommand(Delete, Conexion);

            cmd.Parameters.AddWithValue("@IDProductos", Id);
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
            string Mostrar = "SELECT * FROM Producto";
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

            string Buscar = "SELECT * FROM Producto WHERE IDProductos = @IDProductos";
            SqlCommand cmnd = new SqlCommand(Buscar, Conexion);
            cmnd.Parameters.AddWithValue("@IDProducto", producto.IDProductos);
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
                              "WHERE Nombre LIKE '%' + @Nombre + '%' ORDER BY Nombre";

            SqlCommand cmnd = new SqlCommand(GetValor, Conexion);
            cmnd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            SqlDataAdapter adaptTBL = new SqlDataAdapter(cmnd);
            adaptTBL.Fill(dataTBL);

            return dataTBL;

        }

    }
}

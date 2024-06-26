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
    public class BlacklistClienteDAL : ConexionDAL
    {
        /* Metodo para Insertar */
        public static void Insertar(BlacklistClienteEntity blacklist)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = new SqlConnection();

            Conexion.Open();
            string Insertar = "INSERT INTO BlacklistClientes(IDTipoListaCliente, IDCliente, Razones, FechaInicial, FechaVencimiento, Estatus) " +
                              " VALUES(@IDTipoListaCliente, @IDCliente, @Razones, @FechaInicial, @FechaVencimiento, @Estatus)";

            SqlCommand cmd = new SqlCommand(Insertar, Conexion);
            cmd.Parameters.AddWithValue("@IDTipoListaCliente", blacklist.IDTipoListaCliente);
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

            string Actualizar = "UPDATE BlacklistClientes SET IDTipoListaCliente = @IDTipoListaCliente, IDCliente = @IDCliente, Razones = @Razones, FechaInicial = @FechaInicial, FechaVencimiento = @FechaVencimiento, Estatus = @Estatus where IDBlackListCliente= @IDBlackListCliente";
            SqlCommand cmd = new SqlCommand(Actualizar, Conexion);
            cmd.Parameters.AddWithValue("@IDBlackListCliente", blacklist.IDBlackListCliente);
            cmd.Parameters.AddWithValue("@IDTipoListaCliente", blacklist.IDTipoListaCliente);
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
            string Eliminar = "DELETE FROM BlacklistClientes WHERE IDBlackListCliente= @IDBlackListCliente";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);

            cmd.Parameters.AddWithValue("@IDBlackListCliente", blacklist.IDBlackListCliente);
            seElimino = cmd.ExecuteNonQuery() > 0;

            return seElimino;

        }

        /* Metodo para Mostrar */

        public static DataTable Mostrar()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            DataTable dataTBL = new DataTable();
            Conexion.Open();
            string Mostrar = "SELECT * FROM BlacklistClientes ORDER BY IDCliente";
            SqlCommand cmd = new SqlCommand(Mostrar, Conexion);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
            adapterDT.Fill(dataTBL);

            return dataTBL;
        }

        /* Metodo Buscar por ID */

        public static DataTable BuscarByID(BlacklistClienteEntity blacklist)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string Buscar = "SELECT * FROM BlacklistClientes WHERE IDCliente = @IDCliente";
            SqlCommand cmd = new SqlCommand(Buscar, Conexion);
            cmd.Parameters.AddWithValue("@IDCliente", blacklist.IDCliente);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
            adapterDT.Fill(dataTBL);

            return dataTBL;

        }

        /* Metodo Obtener por Valor */

        public static DataTable ObtenerByValor(BlacklistClienteEntity blacklist)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();

            DataTable dataTBL = new DataTable();
            string GetByValor = "SELECT * FROM BlacklistClientes WHERE IDBlackListCliente LIKE '%' + @IDBlacklistCliente + '%' or IDTipoListaCliente LIKE '%' + @IDTipoListaCliente + '%' or IDCliente LIKE '%' + @IDCliente + '%' or Razones LIKE '%' + @Razones + '%' or FechaInicial LIKE '%' + @FechaInicial + '%' or FechaVencimiento LIKE '%' + @FechaVencimiento + '%' or Estatus LIKE '%' + @Estatus + '%' ORDER BY IDCliente";
            SqlCommand cmd = new SqlCommand(GetByValor, Conexion);
            cmd.Parameters.AddWithValue("@IDBlackListCliente", blacklist.IDBlackListCliente);
            cmd.Parameters.AddWithValue("@IDTipoListaCliente", blacklist.IDTipoListaCliente);
            cmd.Parameters.AddWithValue("@IDCliente", blacklist.IDCliente);
            cmd.Parameters.AddWithValue("@Razones", blacklist.Razones);
            cmd.Parameters.AddWithValue("@FechaInicial", blacklist.FechaInicial);
            cmd.Parameters.AddWithValue("@FechaVencimiento", blacklist.FechaVencimiento);
            cmd.Parameters.AddWithValue("@Estatus", blacklist.Estatus);
            SqlDataAdapter adapterDT = new SqlDataAdapter(cmd);
            adapterDT.Fill(dataTBL);

            return dataTBL;

        }

    }
}

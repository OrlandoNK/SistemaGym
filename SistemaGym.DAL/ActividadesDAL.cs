﻿using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class ActividadesDAL :ConexionDAL
    {
        //metodo insertar Actividades
        public static void InsertarActividad(ActividadesEntity actividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Actividades(IDTiposActividades, Nombre, Area, EncargadoActividad, Dia, HoraInicio, HoraCierre, Estatus) " +
                "values(@idtiposactividades, @nombre, @area, @encargadoactividad, @dia, @horainicio, @horacierre, @estatus)";
                
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", actividades.IDTipoActividades);
            cmd.Parameters.AddWithValue("@nombre", actividades.Nombre);
            cmd.Parameters.AddWithValue("@area", actividades.Area);
            cmd.Parameters.AddWithValue("@encargadoactividad", actividades.EncargadoActividad);
            cmd.Parameters.AddWithValue("@dia", actividades.Dia);
            cmd.Parameters.AddWithValue("@horainicio", actividades.HoraInicio);
            cmd.Parameters.AddWithValue("@horacierre", actividades.HoraCierre);
            cmd.Parameters.AddWithValue("@estatus", actividades.Estatus);
            cmd.ExecuteNonQuery();
        }

        //metodo actualizar Actualizar
        public static void ActualizarActividad(ActividadesEntity actividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Actividades set IDTiposActividades =@idtiposactividades, Nombre =@nombre, Area=@area, EncargadoActividad =@encargoactividad " +
                "dia =@dia, horainicio =@horainicio, horacierre =@horariocierre, Estatus =@estatus";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idtiposactividades", actividades.IDTipoActividades);
            cmd.Parameters.AddWithValue("@nombre", actividades.Nombre);
            cmd.Parameters.AddWithValue("@area", actividades.Area);
            cmd.Parameters.AddWithValue("@encargadoactividad", actividades.EncargadoActividad);
            cmd.Parameters.AddWithValue("@dia", actividades.Dia);
            cmd.Parameters.AddWithValue("@horainicio", actividades.HoraInicio);
            cmd.Parameters.AddWithValue("@horacierre", actividades.HoraCierre);
            cmd.Parameters.AddWithValue("@estatus", actividades.Estatus);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar Actividades

        public static bool EliminarActividad(ActividadesEntity actividades)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Actividades where IDActividad= @idactividad";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idactividad", actividades.IDActividad);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar Actividades
        public static DataTable MostrarActividades()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Actividades Order By Nombre";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }

        public static DataTable BuscarID(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Clientes where IDCliente= @idcliente";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idcliente", clientes.IDCliente);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        public static DataTable ObtenerPorValor(ClientesEntity clientes)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "Select * from Clientes " +
                 "Where IDMembresia Like '%' + @idmembresia + '%' or Nombre Like '%' + @nombre + '%' or Apellido Like '%' + @apellido + '%' or " +
                 "Documento Like '%' + @Documento '%' or Direccion Like '%' + @Direccion + '%' or TelCell Like '%' + @telcell + '%' " +
                 "TelRes Like '%' + @telres + '%' or Estatus Like '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idmembresia", clientes.IDMembresia);
            cmd.Parameters.AddWithValue("@nombre", clientes.Nombre);
            cmd.Parameters.AddWithValue("@apellido", clientes.Apellido);
            cmd.Parameters.AddWithValue("@documento", clientes.Documento);
            cmd.Parameters.AddWithValue("@direccion", clientes.Direccion);
            cmd.Parameters.AddWithValue("@telcell", clientes.TelCell);
            cmd.Parameters.AddWithValue("@telres", clientes.TelRes);
            cmd.Parameters.AddWithValue("@estatus", clientes.Estatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}

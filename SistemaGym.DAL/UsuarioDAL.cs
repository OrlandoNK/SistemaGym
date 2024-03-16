﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SistemaGym.Entities;

namespace SistemaGym.DAL
{
    public class UsuarioDAL : ConexionDAL
    {
        public int ConsultaLogin(UsuarioEntity usuario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            int count;
            Conexion.Open();
            string Query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario =@nombreusuario AND Contrasena =@contrasena ";
            SqlCommand cmd = new SqlCommand(Query, Conexion);
            cmd.Parameters.AddWithValue("@nombreusuario", usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            return count;
        }
        //insertar usuario
        public static void InsertarUsuario(UsuarioEntity usuario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string insertar = "Insert into Usuarios(IDEmpleado, IDRol, Nombre, Apellido, Sexo, Correo, Direccion, FechaRegistro," +
                " NombreUsuario, Contrasena, Estatus)" +
                " values(@idempleado, @idrol, @nombre, @apellido, @sexo, @correo, @direccion, @fecharegistro, @nombreusuario, @contrasena, @estatus)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion);
            cmd.Parameters.AddWithValue("@idrol", usuario.IDRol);
            cmd.Parameters.AddWithValue("@idempleado", usuario.IDEmpleado);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
            cmd.Parameters.AddWithValue("@correo", usuario.Correo);
            cmd.Parameters.AddWithValue("@direccion", usuario.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
            cmd.Parameters.AddWithValue("@nombreusuario", usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
            cmd.Parameters.AddWithValue("@estatus", usuario.Estatus);
            cmd.ExecuteNonQuery();
        }

        public string GetNameFromUser(string usuario, string contraseña)
        {
            string? UserName = string.Empty;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

                string qry = "SELECT Nombre + ' ' + Apellido FROM Usuarios WHERE NombreUsuario = @Usuario AND Contrasena = @Contrasena";
                using (SqlCommand cmnd = new SqlCommand(qry, Conexion))
                {
                    cmnd.Parameters.AddWithValue("@Usuario", usuario);
                    cmnd.Parameters.AddWithValue("@Contrasena", contraseña);
                    Conexion.Open();
                    UserName = Convert.ToString(cmnd.ExecuteScalar());
                }

            return UserName;
        }

        public string GetIDFromUser(string usuario, string contraseña)
        {
            string? UserName = string.Empty;

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            string qry = "SELECT IDUsuario FROM Usuarios WHERE NombreUsuario = @Usuario AND Contrasena = @Contrasena";
            using (SqlCommand cmnd = new SqlCommand(qry, Conexion))
            {
                cmnd.Parameters.AddWithValue("@Usuario", usuario);
                cmnd.Parameters.AddWithValue("@Contrasena", contraseña);
                Conexion.Open();
                UserName = Convert.ToString(cmnd.ExecuteScalar());
            }

            return UserName;
        }

        //metodo actualizar usuario
        public static void ActualizarUsuario(UsuarioEntity usuario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            string actualizar = "Update Usuarios set IDRol =@idrol, Nombre =@nombre, Apellido =@apellido, Sexo =@sexo, Correo =@correo, Direccion =@direccion, " +
                "FechaRegistro =@fecharegistro, NombreUsuario =@nombreusuario, Contrasena =@contrasena, Estatus =@estatus where IDUsuario = @idusuario";
            SqlCommand cmd = new SqlCommand(actualizar, Conexion);
            cmd.Parameters.AddWithValue("@idrol", usuario.IDRol);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
            cmd.Parameters.AddWithValue("@correo", usuario.Correo);
            cmd.Parameters.AddWithValue("@direccion", usuario.Direccion);
            cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
            cmd.Parameters.AddWithValue("@nombreusuario", usuario.NombreUsuario);
            cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
            cmd.Parameters.AddWithValue("@estatus", usuario.Estatus);
            cmd.Parameters.AddWithValue("@idusuario", usuario.IDUsuario);
            cmd.ExecuteNonQuery();


        }
        //funcion eliminar usuario

        public static bool EliminarUsuario(int idUsuario)
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            bool seElimino;



            Conexion.Open();
            string Eliminar = "Delete from Usuarios where IDUsuario= @idusuario";
            SqlCommand cmd = new SqlCommand(Eliminar, Conexion);
            cmd.Parameters.AddWithValue("@idusuario", idUsuario);
            seElimino = cmd.ExecuteNonQuery() > 0;
            return seElimino;

        }


        //metodo mostrar usuario
        public static DataTable MostrarUsuario()
        {
            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();
            DataTable dt = new DataTable();
            Conexion.Open();
            string mostrar = "Select * From Usuarios Order By Nombre";
            SqlCommand cmd = new SqlCommand(mostrar, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;

        }
        //buscar id
        public static UsuarioEntity BuscarID(int id)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string buscar = "Select * From Usuarios where IDUsuario= @idusuario";
            SqlCommand cmd = new SqlCommand(buscar, Conexion);
            cmd.Parameters.AddWithValue("@idusuario", id);

            SqlDataReader reader = cmd.ExecuteReader();
            UsuarioEntity usuarioEncontrado = null;

            if (reader.Read())
            {
                usuarioEncontrado = new UsuarioEntity("","");
                usuarioEncontrado.IDUsuario = Convert.ToInt32(reader["IDUsuario"]);
                usuarioEncontrado.Nombre = reader["Nombre"].ToString();
                
              

            }

            Conexion.Close();
            return usuarioEncontrado;
        }
        // buscar por valor
        public static DataTable ObtenerPorValor(UsuarioEntity usuario)
        {

            ConexionDAL instancia = Instancia();
            SqlConnection Conexion = instancia.Conexion();

            Conexion.Open();
            DataTable dt = new DataTable();
            string obtenerValor = "SELECT * FROM Usuarios " +
    "WHERE IDRol LIKE '%' + @idrol + '%' OR Nombre LIKE '%' + @nombre + '%' OR Apellido LIKE '%' + @apellido + '%' OR " +
    "Sexo LIKE '%' + @sexo + '%' OR Correo LIKE '%' + @correo + '%' OR Direccion LIKE '%' + @direccion + '%' OR NombreUsuario LIKE '%' + @nombreusuario + '%' OR " +
    "Contrasena LIKE '%' + @contrasena + '%' OR Estatus LIKE '%' + @estatus + '%' ORDER BY Nombre";
            SqlCommand cmd = new SqlCommand(obtenerValor, Conexion);
            cmd.Parameters.AddWithValue("@idrol", "%" + usuario.IDRol + "%");
            cmd.Parameters.AddWithValue("@nombre", "%" + usuario.Nombre + "%");
            cmd.Parameters.AddWithValue("@apellido", "%" + usuario.Apellido + "%");
            cmd.Parameters.AddWithValue("@sexo", "%" + usuario.Sexo + "%");
            cmd.Parameters.AddWithValue("@correo", "%" + usuario.Correo + "%");
            cmd.Parameters.AddWithValue("@direccion", "%" + usuario.Direccion + "%");
            cmd.Parameters.AddWithValue("@nombreusuario", "%" + usuario.NombreUsuario + "%");
            cmd.Parameters.AddWithValue("@contrasena", "%" + usuario.Contrasena + "%");
            cmd.Parameters.AddWithValue("@estatus", "%" + usuario.Estatus + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}


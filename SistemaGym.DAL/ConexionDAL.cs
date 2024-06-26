﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.DAL
{
    public class ConexionDAL
    {
        private string Base;
        private string servidor;
        private string usuario;
        private string clave;
        private bool seguridad;
        private static ConexionDAL con = null;



        protected ConexionDAL()
        {
            this.Base = "SistemaGym";
            this.servidor = "DESKTOP-FT9L2OG\\SQLEXPRESS";
            this.seguridad = true;
        }

        public SqlConnection Conexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Server= " + this.servidor + "; Database =" + this.Base + ";";
                if (this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + " Integrated Security = SSPI";
                }

                /*
                else if (this.seguridad) 
                { cadena.ConnectionString = "Server= LAPTOP-JHI5587U\\SQLEMANUEL" + "; Database =" + this.Base + ";" + " Integrated Security = SSPI"; }
                else if (this.seguridad)
                { cadena.ConnectionString = "Server= DESKTOP-FT9L2OG\\SQLEXPRESS" + "; Database =" + this.Base + ";" + " Integrated Security = SSPI"; }
                else if (this.seguridad)
                { cadena.ConnectionString = "Server= ORLANDOABREU\SQLEXPRESS01" + "; Database =" + this.Base + ";" + " Integrated Security = SSPI"; }
                else { cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.usuario + ";Password=" + this.clave; }


                */


            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;

            }
            return cadena;
        }

        public static ConexionDAL Instancia()
        {
            if (con == null)
            {
                con = new ConexionDAL();
            }
            return con;


        }
    }
}

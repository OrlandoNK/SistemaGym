﻿using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class ProveedoresBLL
    {
        readonly ProveedoresDAL proveedores = new ProveedoresDAL();
        public static void Guardar(ProveedoresEntity proveedores)
        {
            ProveedoresDAL.InsertarProveedores(proveedores);
        }
        public static void Update(ProveedoresEntity proveedores)
        {
            ProveedoresDAL.ActualizarProveedores(proveedores);
        }

        public static DataTable BuscarProveedor(string buscar)
        {
            return ProveedoresDAL.Buscar(buscar);
        }

        public static void Actualizar(ProveedoresEntity proveedor)
        {
            ProveedoresDAL.ActualizarProveedores(proveedor);
        }

        public DataTable ShowProviders()
        {
            return ProveedoresDAL.ShowProviders();
        }

        public static bool Eliminar(int Id)
        {
            return ProveedoresDAL.EliminarProveedores(Id);
        }

        public static DataTable MostrarProveedores()
        {
            return ProveedoresDAL.MostrarProveedores();

        }

        public static DataTable BuscarID(ProveedoresEntity proveedores)
        {
            return ProveedoresDAL.BuscarID(proveedores);
        }

        public static DataTable ObtenerPorValor(ProveedoresEntity proveedores)
        {
            return ProveedoresDAL.ObtenerPorValor(proveedores);
        }
    }
}

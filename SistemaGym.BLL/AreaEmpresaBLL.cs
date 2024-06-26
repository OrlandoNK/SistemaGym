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
    public class AreaEmpresaBLL
    {
        public void Insertar(AreaEmpresaEntity areaEmpresa)
        {
            AreaEmpresaDAL.InsertarArea(areaEmpresa);
        }

        public void Actualizar (AreaEmpresaEntity areaEmpresa)
        {
            AreaEmpresaDAL.ActualizarArea(areaEmpresa);
        }
        public static DataTable Buscar(string buscar)
        {
            return AreaEmpresaDAL.Buscar(buscar);
        }
        public bool Eliminar (int areaEmpresa)
        {
            return AreaEmpresaDAL.EliminarArea(areaEmpresa);
        }

        public DataTable Mostrar ()
        {
            DataTable dataTable = AreaEmpresaDAL.MostrarAreaEmpresa();
            return dataTable;
        }

        public DataTable BuscarByID (AreaEmpresaEntity areaEmpresa)
        {
            DataTable dataTable = AreaEmpresaDAL.BuscarID(areaEmpresa);
            return dataTable;
        }
    }
}

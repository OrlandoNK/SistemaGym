using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGym.BLL
{
    public class ClientesBLL
    {
        readonly ClientesDAL clientesDAL = new ClientesDAL();
        public static void guardar(ClientesEntity clientes)
        {
            if (clientes.IDCliente == 0)
            {
                //agregar
                ClientesDAL.InsertarCliente(clientes);
            }
            else
                //Actualizar
                ClientesDAL.ActualizarCliente(clientes);
        }
        public static bool Eliminar(ClientesEntity clientes)
        {
            return ClientesDAL.EliminarCliente(clientes);
        }
        public static DataTable MostrarCliente()
        {
            return ClientesDAL.MostrarCliente();
        }
        public static DataTable BuscarID(ClientesEntity clientes)
        {
            return ClientesDAL.BuscarID(clientes);
        }
        public static DataTable ObtenerPorValor(ClientesEntity clientes)
        {
            return ClientesDAL.ObtenerPorValor(clientes);
        }

    }
}

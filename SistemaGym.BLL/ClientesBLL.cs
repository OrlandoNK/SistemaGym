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
            ClientesDAL.InsertarCliente(clientes);
        }
        public static void guardarClientePaseDiario(ClientesEntity clientes)
        {
            ClientesDAL.InsertarClientePaseDiario(clientes);
        }
        public DataTable ObtenerClienteCargosMembresiaAndGrupos(int idCliente)
        {
            return clientesDAL.GetClientWithCargosAndGroups(idCliente);
        }
        public DataTable GetClientMembreship(int idCliente)
        {
            return clientesDAL.GetClientWithMembership(idCliente);
        }
        public DataTable GetClientCargos(int idCliente)
        {
            return clientesDAL.GetClientWithCargos(idCliente);
        }
        public static void update(ClientesEntity clientes)
        {
            ClientesDAL.ActualizarCliente(clientes);
        }
        public static bool Eliminar(int clientes)
        {
            return ClientesDAL.EliminarCliente(clientes);
        }
        public static DataTable MostrarCliente()
        {
            return ClientesDAL.MostrarCliente();
        }
        public static ClientesEntity BuscarPorID(int id)
        {
            return ClientesDAL.BuscarPorID(id);
        }
        public static DataTable ObtenerPorValor(ClientesEntity clientes)
        {
            return ClientesDAL.ObtenerPorValor(clientes);
        }
        public static ClientesEntity GetById(int Id)
        {
            return ClientesDAL.GetByID(Id);
        }
        public static DataTable GetClients()
        {
            return ClientesDAL.GetClients();
        }
    }
}

using SistemaGym.BLL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{
    public partial class frmBuscarCliente : Form
    {

        private int idCliente;
        public frmBuscarCliente()
        {
            InitializeComponent();
        }
        public int id
        {

            get { return idCliente; }
            set { }

        }


        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            dgvBuscarClientes.AutoGenerateColumns = false;
            dgvBuscarClientes.DataSource = ClientesBLL.MostrarCliente();
            CargarUsuarios();
            CargarMembresia();
            CargarTipoCliente();
            CargarTipoListaCliente();

        }
        private void CargarUsuarios()
        {


            var colUsuario = (DataGridViewComboBoxColumn)dgvBuscarClientes.Columns["IDUsuario"];

            colUsuario.ValueMember = "IDUsuario";
            colUsuario.DisplayMember = "NombreUsuario";
            colUsuario.DataPropertyName = "IDUsuario";
            colUsuario.DataSource = UsuarioBLL.Mostrar();

        }
        private void CargarMembresia()
        {


            var colMembresia = (DataGridViewComboBoxColumn)dgvBuscarClientes.Columns["IDMembresia"];

            colMembresia.ValueMember = "IDMembresia";
            colMembresia.DisplayMember = "Nombre";
            colMembresia.DataPropertyName = "IDMembresia";
            colMembresia.DataSource = MembresiaBLL.Mostrar();
        }
        private void CargarTipoListaCliente()
        {



            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvBuscarClientes.Columns["IDTipoListaCliente"];

            colTipoListaCliente.ValueMember = "IDTipoListaCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoListaCliente";
            colTipoListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
        }
        private void CargarTipoCliente()
        {


            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvBuscarClientes.Columns["IDTipoCliente"];

            colTipoListaCliente.ValueMember = "IDTipoCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoCliente";
            colTipoListaCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBuscarClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            idCliente = (int)dgvBuscarClientes.CurrentRow.Cells["IDCliente"].Value;
            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxbBusqueda_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = TxbBusqueda.Text;

            ClientesEntity clienteBusqueda = new ClientesEntity();
            clienteBusqueda.Nombre = textoBusqueda;
            clienteBusqueda.Apellido = textoBusqueda;
            clienteBusqueda.Documento = textoBusqueda;
            int idMembresia;
            if (int.TryParse(textoBusqueda, out idMembresia))
            {
                clienteBusqueda.IDMembresia = idMembresia;
            }
            clienteBusqueda.Direccion = textoBusqueda;
            clienteBusqueda.TelCell = textoBusqueda;
            clienteBusqueda.TelRes = textoBusqueda;
            clienteBusqueda.Estatus = textoBusqueda;

            dgvBuscarClientes.DataSource = ClientesBLL.ObtenerPorValor(clienteBusqueda);
        }
    }
}

using SistemaGym.BLL;
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
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            dgvBuscarFactura.AutoGenerateColumns = false;
            dgvBuscarFactura.DataSource = FacturacionProductoBLL.Mostrar();
            CargarUsuarios();
            CargarClientes();
        }
        private void CargarUsuarios()
        {
            var colUsuario = (DataGridViewComboBoxColumn)dgvBuscarFactura.Columns["IDUsuario"];

            colUsuario.ValueMember = "IDUsuario";
            colUsuario.DisplayMember = "NombreUsuario";
            colUsuario.DataPropertyName = "IDUsuario";
            colUsuario.DataSource = UsuarioBLL.Mostrar();

        }
        private void CargarClientes()
        {
            var colCliente = (DataGridViewComboBoxColumn)dgvBuscarFactura.Columns["IDCliente"];

            colCliente.ValueMember = "IDCliente";
            colCliente.DisplayMember = "Nombre";
            colCliente.DataPropertyName = "IDCliente";
            colCliente.DataSource = ClientesBLL.MostrarCliente();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxbBusqueda_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbBusqueda.Text;

            DataTable resultBusqueda = FacturacionProductoBLL.BuscarFacturaProducto(buscar);
            dgvBuscarFactura.DataSource = resultBusqueda;
            CargarClientes();
            CargarUsuarios();
        }
    }
}


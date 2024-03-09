using Microsoft.VisualBasic;
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
    public partial class frmClientes : Form
    {
        const string sistema = "Sistema Gestion Gimnasion (COMFORT GYM) dice:";
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = ClientesBLL.GetClients();
            dgvCliente.AutoGenerateColumns = false;
            CargarUsuarios();
            CargarMembresia();
            CargarTipoCliente();
            CargarTipoListaCliente();
        }

        private void CargarUsuarios()
        {
            var colUsuario = (DataGridViewComboBoxColumn)dgvCliente.Columns["IDUsuario"];

            colUsuario.ValueMember = "IDUsuario";
            colUsuario.DisplayMember = "NombreUsuario";
            colUsuario.DataPropertyName = "IDUsuario";
            colUsuario.DataSource = UsuarioBLL.Mostrar();

        }
        private void CargarMembresia()
        {
            var colMembresia = (DataGridViewComboBoxColumn)dgvCliente.Columns["IDMembresia"];

            colMembresia.ValueMember = "IDMembresia";
            colMembresia.DisplayMember = "Nombre";
            colMembresia.DataPropertyName = "IDMembresia";
            colMembresia.DataSource = MembresiaBLL.Mostrar();
        }
        private void CargarTipoListaCliente()
        {
            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvCliente.Columns["IDTipoListaCliente"];

            colTipoListaCliente.ValueMember = "IDTipoListaCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoListaCliente";
            colTipoListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
        }
        private void CargarTipoCliente()
        {

            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvCliente.Columns["IDTipoCliente"];

            colTipoListaCliente.ValueMember = "IDTipoCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoCliente";
            colTipoListaCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevoCliente nuevoCliente = new nuevoCliente();
            nuevoCliente.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

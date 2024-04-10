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
    public partial class mantenimientoGrupoClientes : Form
    {
        public mantenimientoGrupoClientes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarGrupoClientes nuevoGrupoCliente = new registrarGrupoClientes();
            nuevoGrupoCliente.Show();
        }

        private void mantenimientoGrupoClientes_Load(object sender, EventArgs e)
        {
            dgvGrupoClientes.DataSource = GrupoClienteBLL.Mostrar();
            dgvGrupoClientes.AutoGenerateColumns = false;
            CargarCliente();
            CargarGrupoMembresia();
        }

        private void CargarCliente()
        {
            var colIDCliente = (DataGridViewComboBoxColumn)dgvGrupoClientes.Columns["IDCliente"];
            colIDCliente.DataSource = ClientesBLL.MostrarCliente();
            colIDCliente.ValueMember = "IDCliente";
            colIDCliente.DisplayMember = "Nombre";
            colIDCliente.DataPropertyName = "IDCliente";
        }

        private void CargarGrupoMembresia()
        {
            var colGrupoMembresia = (DataGridViewComboBoxColumn)dgvGrupoClientes.Columns["IDGrupoMembresia"];
            colGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
            colGrupoMembresia.ValueMember = "IDGrupoMembresia";
            colGrupoMembresia.DisplayMember = "Nombre";
            colGrupoMembresia.DataPropertyName = "IDGrupoMembresia";
        }
    }
}

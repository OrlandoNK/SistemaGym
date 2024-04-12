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
    public partial class mantenimientoAsistenciaClientes : Form
    {
        public mantenimientoAsistenciaClientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarAsistenciaClientes nuevaAsistencia = new registrarAsistenciaClientes();
            nuevaAsistencia.Show();
        }

        private void mantenimientoAsistenciaClientes_Load(object sender, EventArgs e)
        {
            dgvAsistenciaClientes.DataSource = AsistenciaClientesBLL.MostrarAsistencia();
            dgvAsistenciaClientes.AutoGenerateColumns = false;
            CargarCliente();
        }
        private void CargarCliente()
        {
            var colIDCliente = (DataGridViewComboBoxColumn)dgvAsistenciaClientes.Columns["IDCliente"];
            colIDCliente.DataSource = ClientesBLL.MostrarCliente();
            colIDCliente.ValueMember = "IDCliente";
            colIDCliente.DisplayMember = "Nombre";
            colIDCliente.DataPropertyName = "IDCliente";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvAsistenciaClientes.DataSource = AsistenciaClientesBLL.MostrarAsistencia();
            dgvAsistenciaClientes.AutoGenerateColumns = false;
            CargarCliente();
        }
    }
}

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
    public partial class mantenimientoTipoClientes : Form
    {
        public mantenimientoTipoClientes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoCliente nuevoTipoCliente = new frmTipoCliente();
            nuevoTipoCliente.Show();
        }

        private void mantenimientoTipoClientes_Load(object sender, EventArgs e)
        {
            dgvTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
            dgvTipoCliente.AutoGenerateColumns = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
            dgvTipoCliente.AutoGenerateColumns = false;
        }
    }
}

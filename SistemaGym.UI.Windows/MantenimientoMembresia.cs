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
    public partial class frmMembresia : Form
    {
        const string sistema = "Sistema Gym";
        public frmMembresia()
        {
            InitializeComponent();
        }

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            dgvMembresia.DataSource = MembresiaBLL.Mostrar();
            dgvMembresia.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarMembresia newMembership = new registrarMembresia();
            newMembership.Show();
        }
    }
}

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
    public partial class listaMembresias : Form
    {


        private int? _IdMembresia;

        public int? IdMembresia
        {
            get
            {
                return _IdMembresia;
            }
        }

        public listaMembresias()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listaMembresias_Load(object sender, EventArgs e)
        {
            dgvListaMembresia.DataSource = MembresiaBLL.Mostrar();
            dgvListaMembresia.AutoGenerateColumns = false;
        }

        private void dgvListaMembresias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdMembresia = (int?)dgvListaMembresia.CurrentRow.Cells["IDMembresia"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvListaMembresia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdMembresia = (int?)dgvListaMembresia.CurrentRow.Cells["IDMembresia"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

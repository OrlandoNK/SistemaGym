using SistemaGym.BLL;
using SistemaGym.DAL;
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

        private int _IdMembresia;

        public int IdMembresia
        {
            get { return _IdMembresia; }
        }

        public listaMembresias()
        {
            InitializeComponent();
        }

        private void listaMembresias_Load(object sender, EventArgs e)
        {
            dgvlistaMembresias.DataSource = MembresiaDAL.MostrarMembresia();
            dgvlistaMembresias.AutoGenerateColumns = false;
        }

        private void dgvlistaMembresias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            _IdMembresia = (int)dgvlistaMembresias.CurrentRow.Cells["IDMembresia"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

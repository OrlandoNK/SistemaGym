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
        public listaMembresias()
        {
            InitializeComponent();
        }

        private int _IdMembresia;

        public int IdMembresia
        {
            get { return _IdMembresia; }
        }

        private void dgvListaMembresia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            _IdMembresia = (int)dgvListaMembresia.CurrentRow.Cells["IDMembresia"].Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void listaMembresias_Load(object sender, EventArgs e)
        {
            dgvListaMembresia.DataSource = MembresiaDAL.MostrarMembresia();
        }
    }
}

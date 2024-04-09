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
    public partial class listaGrupoMembresia : Form
    {
        public listaGrupoMembresia()
        {
            InitializeComponent();
        }

        private int? _IdGrupoMembresia;

        public int? IdGrupoMembresia
        {
            get
            {
                return _IdGrupoMembresia;
            }
        }

        private void listaGrupoMembresia_Load(object sender, EventArgs e)
        {
            dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
            dgvGrupoMembresia.AutoGenerateColumns = false;
            CargarMembresia();
        }
        private void CargarMembresia()
        {
            var colIDMembresia = (DataGridViewComboBoxColumn)dgvGrupoMembresia.Columns["IDMembresia"];
            colIDMembresia.DataSource = MembresiaBLL.Mostrar();
            colIDMembresia.ValueMember = "IDMembresia";
            colIDMembresia.DisplayMember = "Nombre";
            colIDMembresia.DataPropertyName = "IDMembresia";
        }

        private void dgvGrupoMembresia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdGrupoMembresia = (int?)dgvGrupoMembresia.CurrentRow.Cells["IDGrupoMembresia"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

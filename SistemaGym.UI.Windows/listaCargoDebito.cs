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
    public partial class listaCargoDebito : Form
    {

        private int? _IdCargoDebito;

        public int? IdCargoDebito
        {
            get
            {
                return _IdCargoDebito;
            }
        }

        public listaCargoDebito()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListaCargoDebito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdCargoDebito = (int?)dgvListaCargoDebito.CurrentRow.Cells["IDCargoDebito"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listaCargoDebito_Load(object sender, EventArgs e)
        {
            dgvListaCargoDebito.DataSource = CargoDebitoBLL.MostrarCargoDebito();
            dgvListaCargoDebito.AutoGenerateColumns = false;
        }
    }
}

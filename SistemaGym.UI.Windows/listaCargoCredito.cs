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
    public partial class listaCargoCredito : Form
    {

        private int? _IdCargoCredito;

        public int? IdCargoCredito
        {
            get
            {
                return _IdCargoCredito;
            }
        }

        public listaCargoCredito()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListaCargoCredito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdCargoCredito = (int?)dgvListaCargoCredito.CurrentRow.Cells["IDCargoCredito"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listaCargoCredito_Load(object sender, EventArgs e)
        {

            dgvListaCargoCredito.DataSource = CargoCreditoBLL.MostrarCargoCredito();
            dgvListaCargoCredito.AutoGenerateColumns = false;

        }
    }
}

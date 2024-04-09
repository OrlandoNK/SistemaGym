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
    public partial class listaEmpleados : Form
    {
        public listaEmpleados()
        {
            InitializeComponent();
        }

        private int _IdEmpleado;

        public int IdEmpleado
        {
            get
            {
                return _IdEmpleado;
            }
        }

        private void listaEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = EmpleadoBLL.GetEmpleados();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _IdEmpleado = (int)dgvEmpleados.CurrentRow.Cells["IDEmpleado"].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            dgvPago.DataSource = PagoBLL.Mostrarpago();
            CargarFacturaMembresia();
            CargarFacturaProducto();
            dgvPago.AutoGenerateColumns = false;
        }
        public void CargarFacturaMembresia()
        {
            var colFacturaMembresia = (DataGridViewComboBoxColumn)dgvPago.Columns["IDFacturaMembresia"];
            colFacturaMembresia.DataSource = FacturaMembresiaBLL.Mostrar();
            colFacturaMembresia.ValueMember = "IDFactura";
            colFacturaMembresia.DisplayMember = "IDFactura";
            colFacturaMembresia.DataPropertyName = "IDFacturaMembresia";
        }
        public void CargarFacturaProducto()
        {
            var colFacturaProducto = (DataGridViewComboBoxColumn)dgvPago.Columns["IDFacturaProducto"];
            colFacturaProducto.DataSource = FacturacionProductoBLL.Mostrar();
            colFacturaProducto.ValueMember = "IDFactura";
            colFacturaProducto.DisplayMember = "IDFactura";
            colFacturaProducto.DataPropertyName = "IDFacturaProducto";
        }
    }
}

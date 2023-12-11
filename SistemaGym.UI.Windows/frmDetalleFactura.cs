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
    public partial class frmDetalleFactura : Form
    {
        public frmDetalleFactura()
        {
            InitializeComponent();
        }

        private void frmDetalleFactura_Load(object sender, EventArgs e)
        {
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.DataSource = FacturacionProductoBLL.MostrarDetalle();
            CargarFactura();
            CargarProducto();
        }
        private void CargarProducto()
        {


            var colProducto = (DataGridViewComboBoxColumn)dgvDetalle.Columns["IDProducto"];

            colProducto.ValueMember = "IDProducto";
            colProducto.DisplayMember = "Nombre";
            colProducto.DataPropertyName = "IDProducto";
            colProducto.DataSource = ProductoBLL.GetAll();

        }
        private void CargarFactura()
        {


            var colFactura = (DataGridViewComboBoxColumn)dgvDetalle.Columns["IDFacturaProducto"];

            colFactura.ValueMember = "IDFacturaProducto";
            colFactura.DisplayMember = "IDFactura";
            colFactura.DataPropertyName = "IDFacturaProducto";
            colFactura.DataSource = FacturacionProductoBLL.Mostrar();

        }
    }
}


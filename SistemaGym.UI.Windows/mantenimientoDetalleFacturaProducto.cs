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
    public partial class mantenimientoDetalleFacturaProducto : Form
    {
        public mantenimientoDetalleFacturaProducto()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mantenimientoDetalleFacturaProducto_Load(object sender, EventArgs e)
        {
            dgvDetalleFacturaProducto.DataSource = FacturacionProductoBLL.MostrarDetalle();
            CargarProducto();
            dgvDetalleFacturaProducto.AutoGenerateColumns = false;
        }
        private void CargarProducto()
        {
            var colProducto = (DataGridViewComboBoxColumn)dgvDetalleFacturaProducto.Columns["IDProducto"];
            colProducto.DataSource = ProductoBLL.GetAll();
            colProducto.ValueMember = "IDProducto";
            colProducto.DisplayMember = "Nombre";
            colProducto.DataPropertyName = "IDProducto";
        }


    }
}

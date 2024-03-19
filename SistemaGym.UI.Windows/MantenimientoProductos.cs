using SistemaGym.BLL;
using SistemaGym.DAL;
using SistemaGym.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGym.UI.Windows
{
    public partial class MantenimientoProductos : Form
    {

        string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        public MantenimientoProductos()
        {
            InitializeComponent();
        }
        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        private void CargarCategoria()
        {
            var colCategoria = (DataGridViewComboBoxColumn)dgvProductos.Columns["IDCategoria"];
            colCategoria.DataSource = CategoriaProductoBLL.Mostrar();
            colCategoria.ValueMember = "IDCategoria";
            colCategoria.DisplayMember = "Nombre";
            colCategoria.DataPropertyName = "IDCategoria";
        }
        private void CargarProveedor()
        {
            var colProveedor = (DataGridViewComboBoxColumn)dgvProductos.Columns["IDProveedor"];

            colProveedor.ValueMember = "IDProveedor";
            colProveedor.DisplayMember = "Nombre";
            colProveedor.DataPropertyName = "IDProveedor";
            colProveedor.DataSource = ProveedoresBLL.MostrarProveedores();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoBLL productoBLL = new ProductoBLL();
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar este Producto?", "¿Eliminar Producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {


                }
                if (dialogResult == DialogResult.No)
                {

                }

            }
        }
    }
}
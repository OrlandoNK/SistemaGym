using SistemaGym.BLL;
using SistemaGym.Entities;
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
    public partial class frmBuscarProductos : Form
    {
        int idProducto;
        public frmBuscarProductos()
        {
            InitializeComponent();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {


        }
        public int id
        {
            get { return idProducto; }
            set { }
        }
        private void frmBuscarProductos_Load(object sender, EventArgs e)
        {
            dgvBuscarProductos.AutoGenerateColumns = false;
            dgvBuscarProductos.DataSource = ProductoBLL.GetAll();
            CargarCategoria();
            CargarProveedor();

        }
        private void CargarCategoria()
        {


            var colCategoria = (DataGridViewComboBoxColumn)dgvBuscarProductos.Columns["IDCategoria"];

            colCategoria.ValueMember = "IDCategoria";
            colCategoria.DisplayMember = "Nombre";
            colCategoria.DataPropertyName = "IDCategoria";
            colCategoria.DataSource = CategoriaProductoBLL.Mostrar();

        }
        private void CargarProveedor()
        {


            var colProveedor = (DataGridViewComboBoxColumn)dgvBuscarProductos.Columns["IDProveedor"];

            colProveedor.ValueMember = "IDProveedor";
            colProveedor.DisplayMember = "Nombre";
            colProveedor.DataPropertyName = "IDProveedor";
            colProveedor.DataSource = ProveedoresBLL.MostrarProveedores();

        }

        private void dgvBuscarProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            idProducto = (int)dgvBuscarProductos.CurrentRow.Cells["IDProducto"].Value;
            DialogResult = DialogResult.OK;
            Close();

        }

        private void TxbBusqueda_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = TxbBusqueda.Text;

            ProductoEntity productoBusqueda = new ProductoEntity();
            productoBusqueda.Nombre = textoBusqueda;
            int idProveedor;
            if (int.TryParse(textoBusqueda, out idProveedor))
            {
                productoBusqueda.IDProveedor = idProveedor;
            }

            int idCategoria;
            if (int.TryParse(textoBusqueda, out idCategoria))
            {
                productoBusqueda.IDCategoria = idCategoria;
            }
            dgvBuscarProductos.DataSource = ProductoBLL.GetByValor(productoBusqueda);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


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
    public partial class frmBuscarProducto : Form
    {
        private int idPRoducto;
        public frmBuscarProducto()
        {
            InitializeComponent();
        }
        private int id
        {
            get { return idPRoducto; }
            set { }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscarProducto.Text;


            ProductoEntity productoBusqueda = new ProductoEntity();
            productoBusqueda.Nombre = textoBusqueda;
            productoBusqueda.IDProveedor = int.Parse(textoBusqueda);
            productoBusqueda.IDCategoria = int.Parse(textoBusqueda);


            dgvBuscarProductos.DataSource = ProductoBLL.GetByValor(productoBusqueda);

        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
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
    }
}


using SistemaGym.BLL;
using SistemaGym.DAL;
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
    public partial class MantenimientoProductos : Form
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }
        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {
            InicializarCampos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InicializarCampos();
        }
        public void InicializarCampos()
        {
            txtIDProducto.Text = "0";
            txtNombre.Clear();
            txtPrecioUnitario.Clear();
            txtStock.Clear();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = ProductoBLL.GetAll();
            CargarCategoria();
            CargarProveedor();
        }
        private void CargarCategoria()
        {
            cbCategoria.DataSource = CategoriaProductoBLL.Mostrar();
            cbCategoria.ValueMember = "IDCategoria";
            cbCategoria.DisplayMember = "Nombre";

            var colCategoria = (DataGridViewComboBoxColumn)dgvProductos.Columns["IDCategoria"];

            colCategoria.ValueMember = "IDCategoria";
            colCategoria.DisplayMember = "Nombre";
            colCategoria.DataPropertyName = "IDCategoria";
            colCategoria.DataSource = CategoriaProductoBLL.Mostrar();

        }
        private void CargarProveedor()
        {
            cbProveedor.DataSource = ProveedoresBLL.MostrarProveedores();
            cbProveedor.ValueMember = "IDProveedor";
            cbProveedor.DisplayMember = "Nombre";

            var colProveedor = (DataGridViewComboBoxColumn)dgvProductos.Columns["IDProveedor"];

            colProveedor.ValueMember = "IDProveedor";
            colProveedor.DisplayMember = "Nombre";
            colProveedor.DataPropertyName = "IDProveedor";
            colProveedor.DataSource = ProveedoresBLL.MostrarProveedores();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quiere guardar los datos?", "Guardar Producto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ProductoEntity nuevoproducto = new ProductoEntity();
                nuevoproducto.Nombre = txtNombre.Text;
                nuevoproducto.IDCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                nuevoproducto.PrecioUnitario = decimal.Parse(txtPrecioUnitario.Text);
                nuevoproducto.Stock = int.Parse(txtStock.Text);

                if (txtIDProducto.Text == "0")
                {
                    ProductoBLL.Guardar(nuevoproducto);
                    MessageBox.Show("Producto Guardado", "mantenimineto producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvProductos.DataSource = ProductoBLL.GetAll();
                }

            }
            if (result == DialogResult.No)
            {

            }
        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El Nombre Es Obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(cbCategoria.Text))
            {
                errorProvider.SetError(cbCategoria, "La Categoria Es Obligatoria");
                resultado = false;
            }


            if (string.IsNullOrEmpty(cbProveedor.Text))
            {
                errorProvider.SetError(cbProveedor, "Obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtPrecioUnitario.Text))
            {
                errorProvider.SetError(txtPrecioUnitario, "El Precio es Obligatorio");
                resultado = false;
            }


            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoBLL productoBLL = new ProductoBLL();
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere eliminar este producto?", "¿Eliminar Producto?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int idproducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IDProducto"].Value);
                    bool seElimino = true;

                    if (seElimino)
                    {
                        dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows[0].Index);
                        MessageBox.Show("Producto Eliminado", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No Se Elimino El Producto", "Error Al Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (dialogResult == DialogResult.No)
                {

                }

            }
        }
    }
}
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
    public partial class MantenimientoProductos : Form
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }
        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ProductoBLL.MostrarProducto();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InicializarCampos();
        }
        public void InicializarCampos()
        {
            txtIDProducto.Text = "0";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtPrecioUnitario.Text = "";
            txtNoExistencia.Text = "";
        }
        public void LimpiarCampos()
        {
            txtIDProducto.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecioUnitario.Clear();
            txtNoExistencia.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quiere guardar los datos?","Guardar Producto", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ProductoEntity nuevoproducto = new ProductoEntity();
                nuevoproducto.Nombre = txtNombre.Text;
                nuevoproducto.Categoria = txtCategoria.Text;
                nuevoproducto.PrecioUnitario = txtPrecioUnitario.Text;
                nuevoproducto.Stock = txtNoExistencia.Text;

                if (txtIDProducto.Text == "0")
                {
                    ProductoBLL.Guardar(nuevoproducto);
                    MessageBox.Show("Producto Guardado", "mantenimineto producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    dgvProductos.DataSource = ProductoBLL.MostrarProductos();
                }

            }
            if (result == DialogResult.No)
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoBLL productoBLL = new ProductoBLL();
            if (dgvProductos.SelectedRows.Count > 0 )
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere eliminar este producto?", "¿Eliminar Producto?" MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int idproducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["IDProducto"].Value);
                    bool seElimino = ProductoBLL.Eliminar(idproducto);

                    if(seElimino)
                    {
                        dgvProductos.Rows.RemoveAt(dgvProductos.SelectedRows[0].Index);
                        MessageBox.Show("Producto Eliminado", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProductos.DataSource = ProductoBLL.MostrarProducto();
                    }
                    else
                    {
                        MessageBox.Show("No Se Elimino El Producto", "Error Al Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcons.Error);
                    }

                }
                if (dialogResult == DialogResult.No)
                {
                    
                }

            }
        }
    }
}
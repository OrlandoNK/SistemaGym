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
            colCategoria.DataSource = CategoriaProductoBLL.Mostrar();
            colCategoria.ValueMember = "IDCategoria";
            colCategoria.DisplayMember = "Nombre";
            colCategoria.DataPropertyName = "IDCategoria";


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
            bool CamposValidados = ValidarDatos();

            /*
            if (!ValidarDatos())
            {
                return;

            }
            */

            ProductoEntity nuevoproducto = new ProductoEntity();
            nuevoproducto.Nombre = txtNombre.Text;
            nuevoproducto.IDCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            nuevoproducto.IDProveedor = Convert.ToInt32(cbProveedor.SelectedValue);
            nuevoproducto.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
            nuevoproducto.Stock = int.Parse(txtStock.Text);

            try
            {
                if (CamposValidados)
                {
                    ProductoBLL.Guardar(nuevoproducto);
                    MessageBox.Show("¡El Producto ha sido Guardado de Manera Satisfactoria!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.DataSource = ProductoBLL.GetAll();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Producto:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Producto:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
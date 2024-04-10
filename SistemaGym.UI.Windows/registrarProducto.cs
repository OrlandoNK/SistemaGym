using SistemaGym.BLL;
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
    public partial class registrarProducto : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        public registrarProducto()
        {
            InitializeComponent();
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

        private void CargarCategoria()
        {
            cbCategoria.DataSource = CategoriaProductoBLL.Mostrar();
            cbCategoria.ValueMember = "IDCategoria";
            cbCategoria.DisplayMember = "Nombre";
        }
        private void CargarProveedor()
        {
            cbProveedor.DataSource = ProveedoresBLL.MostrarProveedores();
            cbProveedor.ValueMember = "IDProveedor";
            cbProveedor.DisplayMember = "Nombre";
        }

        public void InicializarCampos()
        {
            txtIDProducto.Text = "0";
            txtNombre.Clear();
            txtPrecioUnitario.Clear();
            txtStock.Clear();
            CargarCategoria();
            CargarProveedor();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarCampos();
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
                    InicializarCampos();
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

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            frmCategoria nuevaCategoria = new frmCategoria();
            nuevaCategoria.Show();
        }

        private void btnNewProvider_Click(object sender, EventArgs e)
        {
            registrarProveedores nuevoProveedor = new registrarProveedores();
            nuevoProveedor.Show();
        }

        private void btnRefreshCategories_Click(object sender, EventArgs e)
        {
            CargarCategoria();
        }

        private void btnRefreshProviders_Click(object sender, EventArgs e)
        {
            CargarProveedor();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrarProducto_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            CargarProveedor();
        }
    }
}

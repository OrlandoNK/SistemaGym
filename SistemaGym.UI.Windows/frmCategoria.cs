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
using static Guna.UI2.Native.WinApi;

namespace SistemaGym.UI.Windows
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private string SISTEMA_GYM = "Sistema Gestion Gimnasio (CONFORT GYM) dice";
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtDescripcion.Clear();
            txtIDCategoria.Text = "0";
            txtNombre.Clear();
            txtNombre.Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        /*
        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }

            DataGridViewRow row = dgvCategoria.CurrentRow;
            txtIDCategoria.Text = row.Cells["IDCategoria"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();

        }
        */
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El Nombre es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, "La Descripcion es obligatorio");
                resultado = false;
            }
            return resultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validar los datos
            if (!ValidarDatos())
            {
                return;

            }
            //datos de control al objeto
            CategoriaProductoEntity oCategoria = new CategoriaProductoEntity();
            oCategoria.IDCategoria = int.Parse(txtIDCategoria.Text);
            oCategoria.Nombre = txtNombre.Text;
            oCategoria.Descripcion = txtDescripcion.Text;
            InicializarControles();
            // guardar base datos
            try
            {
                CategoriaProductoBLL.Guardar(oCategoria);
                MessageBox.Show("¡La Categoria Ha Sido Guardada de Manera Satisfactoria!", SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Se Ha Producido un Error al Intentar Guardar la Categoria! \nDetalles A Continuación:\n" + ex.Message, SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Se Ha Producido un Error al Intentar Guardar la Categoria! \nDetalles A Continuación:\n" + ex.Message, SISTEMA_GYM, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

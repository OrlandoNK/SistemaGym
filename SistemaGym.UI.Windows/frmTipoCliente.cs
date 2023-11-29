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
    public partial class frmTipoCliente : Form
    {
        const string sistema = "Sistema Gym";
        public frmTipoCliente()
        {
            InitializeComponent();
        }

        private void frmTipoCliente_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtID.Text = "0";
            txtNombre.Clear();
            txtDescripcion.Clear();
            dtpFechaCreacion.Clear();
            dgvTipoCliente.AutoGenerateColumns = false;
            dgvTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validacion de datos
            if (!ValidarDatos())
            {
                return;
            }
            //pasar datos de controles a un objeto
            TipoClienteEntity TipoCliente = new TipoClienteEntity();
            TipoCliente.IDTipoCliente = int.Parse(txtID.Text);
            TipoCliente.Nombre = txtNombre.Text;
            TipoCliente.Descripcion = txtDescripcion.Text;
            TipoCliente.FechaCreacion = DateTime.Parse(dtpFechaCreacion.Text);

            //Mandar a guardar el objeto creado a la base de datos
            try
            {
                TipoClienteBLL.Guardar(TipoCliente);
                MessageBox.Show("TipoCliente guardada.", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider1.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "El valor no es obligatorio");
                resultado = false;
            }

            if (string.IsNullOrEmpty(dtpFechaCreacion.Text))
            {
                errorProvider1.SetError(dtpFechaCreacion, "La fecha es obligatorio");
                resultado = false;
            }

            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTipoCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }

            DataGridViewRow row = dgvTipoCliente.CurrentRow;
            txtID.Text = row.Cells["IDTipoCliente"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();
            dtpFechaCreacion.Text = row.Cells["FechaCreacion"].Value?.ToString();


        }


    }
}

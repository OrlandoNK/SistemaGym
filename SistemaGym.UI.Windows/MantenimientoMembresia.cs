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
    public partial class frmMembresia : Form
    {
        const string sistema = "Sistema Gym";
        public frmMembresia()
        {
            InitializeComponent();
        }

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            InicializarControles();
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
            txtDuracion.Clear();
            txtValor.Clear();
            dtpFechaCreacion.Text = "";
            dgvMembresia.AutoGenerateColumns = false;
            dgvMembresia.DataSource = MembresiaBLL.Mostrar();
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
            MembresiaEntity oMembresia = new MembresiaEntity();
            oMembresia.IDMembresia = int.Parse(txtID.Text);
            oMembresia.Nombre = txtNombre.Text;
            oMembresia.Descripcion = txtDescripcion.Text;
            oMembresia.Duracion = txtDuracion.Text;
            oMembresia.Valor = decimal.Parse(txtValor.Text);
            oMembresia.FechaCreacion = DateTime.Parse(dtpFechaCreacion.Text);
            oMembresia.Estatus = cbEstatus.Text;



            //Mandar a guardar el objeto creado a la base de datos
            try
            {
                MembresiaBLL.Insertar(oMembresia);
                MessageBox.Show("Membresia guardada.", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                errorProvider.SetError(txtValor, "El valor es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(dtpFechaCreacion.Text))
            {
                errorProvider.SetError(dtpFechaCreacion, "La fecha es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(cbEstatus.Text))
            {
                errorProvider.SetError(cbEstatus, "El estatus es obligatorio");
                resultado = false;
            }
            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMembresia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }

            DataGridViewRow row = dgvMembresia.CurrentRow;
            txtID.Text = row.Cells["IDMembresia"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();
            txtDuracion.Text = row.Cells["Duracion"].Value?.ToString();
            txtValor.Text = row.Cells["Valor"].Value?.ToString();
            dtpFechaCreacion.Text = row.Cells["FechaCreacion"].Value?.ToString();
            cbEstatus.Text = row.Cells["Estatus"].Value?.ToString();

        }
    }
}

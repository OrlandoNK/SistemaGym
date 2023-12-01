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
    public partial class frmAreaEmpresa : Form
    {
        const string sistema = "Sistema Gym";
        public frmAreaEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtIDArea.Text = "0";
            txtEncargado.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            dtpFechaCreacion.Text = "";
            dgvAreaEmpresa.AutoGenerateColumns = false;
            dgvAreaEmpresa.DataSource = AreaEmpresaBLL.Mostrar();
            txtEncargado.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validacion de datos
            if (!ValidarDatos())
            {
                return;
            }
            //Pasar datos al objeto desde los controles
            AreaEmpresaEntity areaEmpresa = new AreaEmpresaEntity();
            areaEmpresa.IDArea = int.Parse(txtIDArea.Text);
            areaEmpresa.Encargado = int.Parse(txtEncargado.Text);
            areaEmpresa.Nombre = txtNombre.Text;
            areaEmpresa.Descripcion = txtDescripcion.Text;

            try
            {
                AreaEmpresaDAL.InsertarArea(areaEmpresa);
                MessageBox.Show("Area Empresa se guardo.", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //Inicializar los mensajes
            errorProvider1.Clear();
            //Asegurarse que en los capos obligatoios hayan datos
            if (string.IsNullOrEmpty(txtEncargado.Text))
            {
                errorProvider1.SetError(txtEncargado, "Campo obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Campo obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Campo obligatorio");
                resultado = false;
            }

            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAreaEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dgvAreaEmpresa.CurrentRow;
            txtIDArea.Text = row.Cells["IDArea"].Value?.ToString();
            txtEncargado.Text = row.Cells["Encargado"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();
            dtpFechaCreacion.Text = row.Cells["FechaCreacion"].Value?.ToString();
        }
    }
}



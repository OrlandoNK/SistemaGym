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
            textIDArea.Text = "0";
            txtEncargado.Clear();
            textNombre.Clear();
            txtDescripcion.Clear();
            dtpFechaCreacion = ;
            dgvAreaEmpresa.AutoGenerateColumns = false;
            dgvAreaEmpresa.DataSource = AreaEmpresaDAL.MostrarAreaEmpresa();
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
            areaEmpresa.IDArea = int.Parse(textIDArea.Text);
            areaEmpresa.Encargado = int.Parse(txtEncargado.Text);
            areaEmpresa.Nombre = textNombre.Text;
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
                errorProvider1.SetError(textNombre, "Campo obligatorio");
                resultado = false;
                errorProvider1.SetError(txtDescripcion, "Campo no obligatorio");
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
            textIDArea.Text = row.Cells["IDArea"].Value?.ToString();
            txtEncargado.Text = row.Cells["Encargado"].Value?.ToString();
            textNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();
            dtpFechaCreacion.Text = row.Cells["FechaCreacion"].Value?.ToString();
        }
    }
}



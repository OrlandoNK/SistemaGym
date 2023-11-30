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
    public partial class frmTipoActividades : Form
    {
        const string sistema = "Sistema Gym";
        public frmTipoActividades()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtIDTipoActividad.Text = "0";
            txtNombre.Clear();
            txtDescripcion.Clear();
            dgvTipoActividades.AutoGenerateColumns = false;
            dgvTipoActividades.DataSource = TiposActividadesBLL.MostrarTipoActividades();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validacion de datos
            if (!ValidarDatos())
            {
                return;
            }
            //Pasar datos al objeto desde los controles
            TiposActividadesEntity tiposActividad = new TiposActividadesEntity();
            tiposActividad.IDTipoActividad = int.Parse(txtIDTipoActividad.Text);
            tiposActividad.Nombre = txtNombre.Text;
            tiposActividad.Descripcion = txtDescripcion.Text;

            try
            {
                TiposActividadesBLL.Guardar(tiposActividad);
                MessageBox.Show("Tipo Asistencia se guardo.", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Campo obligatorio");
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

        private void dgvTipoActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dgvTipoActividades.CurrentRow;
            txtIDTipoActividad.Text = row.Cells["IDTipoActividad"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();
        }
    }
}

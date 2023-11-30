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
    public partial class frmAsistenciaClientes : Form
    {
        const string sistema = "SistemaGym";
        public frmAsistenciaClientes()
        {
            InitializeComponent();
        }
        private void InicializarControles()
        {
            txtIDAsistenciaCliente.Text = "0";
            txtCliente.Clear();
            txtAsistencia.Clear();
            dgvAsistenciaClientes.AutoGenerateColumns = false;
            dgvAsistenciaClientes.DataSource = AsistenciaClientesBLL.MostrarAsistencia();
            txtAsistencia.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validar
            if (!ValidarDatos())
            {
                return;
            }

            AsistenciaClientesEntity asistencia = new AsistenciaClientesEntity();
            asistencia.IDAsistenciaCliente = int.Parse(txtIDAsistenciaCliente.Text);
            asistencia.IDCliente = int.Parse(txtCliente.Text);
            asistencia.Asistencia = chbAsistencia.Checked;
            asistencia.FechaAsistencia = DateTime.Now;

            try
            {
                AsistenciaClientesBLL.Guardar(asistencia);
                MessageBox.Show("Asistencia Agregada.", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de la validacion
            errorProvider1.Clear();
            //verificar los datos en los campos obligatorios 
            if (string.IsNullOrEmpty(txtAsistencia.Text))
            {
                errorProvider1.SetError(txtAsistencia,  "Campo obligatorio");
                resultado = false;
                errorProvider1.SetError(txtFechaAsistencia, "Campo obligatorio");
                resultado = false;
            }
            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAsistenciaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex == -1)
                {
                    return;

                }

                DataGridViewRow row = dgvAsistenciaClientes.CurrentRow;
                txtIDAsistenciaCliente.Text = row.Cells["IDAsistencia"].Value?.ToString();
                txtCliente.Text = row.Cells["cliente"].Value?.ToString();
                txtAsistencia.Text = row.Cells["Asistencia"].Value?.ToString();
                txtFechaAsistencia.Text = row.Cells["FechaAsistencia"].Value?.ToString();

            }
        }
    }
}

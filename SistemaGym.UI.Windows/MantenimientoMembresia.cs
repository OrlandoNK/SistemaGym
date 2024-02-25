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

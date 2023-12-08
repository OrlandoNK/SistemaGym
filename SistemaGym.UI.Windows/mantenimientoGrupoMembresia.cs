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
    public partial class mantenimientoGrupoMembresia : Form
    {
        public mantenimientoGrupoMembresia()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxbIDMembresia.Text, out int idMembresia))
            {
                errorProvider.SetError(TxbIDMembresia, "Ingrese un Valor Entero Valido");
                return;
            }

            string nombre = TxbNombre.Text;
            string fechaRegistro = dtpFechaRegistro.Value.ToString();
            string estatus = cmbxEstatus.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(estatus))
            {
                errorProvider.SetError(btnAgregar, "Complete los Campoes Correspondientes");
                return;
            }

            dgvGrupoMembresia.Rows.Add(idMembresia, nombre, fechaRegistro, estatus);
            LimpiarCampos();

        }

        public void LimpiarCampos()
        {
            TxbIDMembresia.Clear();
            TxbNombre.Clear();
            cmbxEstatus.SelectedIndex = -1;
        }


        private void btnBuscarMembresia_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var buscarMembresia = new listaMembresias();

            if (buscarMembresia.ShowDialog() == DialogResult.OK)
            {
                MembresiaEntity oMembresia = MembresiaDAL.ObtenerMembresiaByID(buscarMembresia.IdMembresia);
                if (oMembresia != null)
                {
                    TxbIDMembresia.Text = oMembresia.IDMembresia.ToString();
                    TxbNombre.Text = $"{oMembresia.Nombre}";
                }
            }
            else
            {
                MessageBox.Show("Membresia No Encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mantenimientoGrupoMembresia_Load(object sender, EventArgs e)
        {
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow filaGrupoMembresia in dgvGrupoMembresia.Rows)
            {
                if (!filaGrupoMembresia.IsNewRow)
                {
                    GrupoMembresiaEntity nuevoGrupoMembresia = new GrupoMembresiaEntity();
                    nuevoGrupoMembresia.IDMembresia = int.Parse(filaGrupoMembresia.Cells["IDMembresia"].Value.ToString());
                    nuevoGrupoMembresia.Nombre = filaGrupoMembresia.Cells["Nombre"].Value.ToString();
                    nuevoGrupoMembresia.FechaRegistro = DateTime.Parse(filaGrupoMembresia.Cells["FechaRegistro"].Value.ToString());
                    nuevoGrupoMembresia.Estatus = filaGrupoMembresia.Cells["Estatus"].Value.ToString();

                    GrupoMembresiaBLL.guardar(nuevoGrupoMembresia);
                }
                else
                {
                    MessageBox.Show("Error al Guardar el Grupo de Membresia", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
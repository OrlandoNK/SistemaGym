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
                errorProvider.SetError(TxbIDMembresia, "Ingrese un Valor Entero Valido, este Campo no puede estar Vacio");
                return;
            }

            string nombre = TxbNombre.Text;
            string fechaRegistro = dtpFechaRegistro.Value.ToString();
            string estatus = cmbxEstatus.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(estatus))
            {
                errorProvider.SetError(btnAgregar, "Complete los Campos Correspondientes");
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
            dgvGrupoMembresia.AutoGenerateColumns = true;
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
                    MessageBox.Show("¡Grupo de Membresia Registrado con Exito!", "REGISTRO GRUPO MEMBRESIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGrupoMembresia.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Error al Guardar el Grupo de Membresia", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvGrupoMembresia.SelectedRows.Count > 0)
            {
                DataGridViewRow removerFila = dgvGrupoMembresia.SelectedRows[0];
                dgvGrupoMembresia.Rows.Remove(removerFila);
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un Grupo de Membresia de la lista antes de eliminarlo. Por favor, seleccione el Grupo de Membresia que desea eliminar", "Error al intentar eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTraerGrupoMembresia_Click(object sender, EventArgs e)
        {
            dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GrupoMembresiaBLL grupoMembresiaBLL = new GrupoMembresiaBLL();

            DialogResult resultDialog = MessageBox.Show("¿Seguro que desea eliminar a este Grupo de Membresia?", "¿Eliminar Grupo de Membresia?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                if (dgvGrupoMembresia.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectRow = dgvGrupoMembresia.SelectedRows[0];

                    int idDelete = Convert.ToInt32(selectRow.Cells["IDGrupoMembresia"].Value);
                    bool resultado = GrupoMembresiaBLL.Eliminar(idDelete);

                    if (resultado)
                    {
                        MessageBox.Show("¡Grupo de Membresia Eliminado con Éxito!", "GRUPO DE MEMBRESIA ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
                    }
                    else
                    {
                        MessageBox.Show("Error al tratar de eliminar el Grupo de Membresia", "Error de Eliminación de Grupo de Membresia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (resultDialog == DialogResult.No)
            {

            }

        }

        private void btnagregarMembresia_Click(object sender, EventArgs e)
        {
            registrarMembresias membresiasReg = new registrarMembresias();
            membresiasReg.Show();
        }
    }
}
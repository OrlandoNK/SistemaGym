using SistemaGym.BLL;
using SistemaGym.DAL;
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

namespace SistemaGym.UI.Windows
{
    public partial class frmMembresia : Form
    {
        string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        public frmMembresia()
        {
            InitializeComponent();
        }

        private void frmMembresia_Load(object sender, EventArgs e)
        {
            dgvMembresia.DataSource = MembresiaBLL.Mostrar();
            dgvMembresia.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarMembresia newMembership = new registrarMembresia();
            newMembership.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvMembresia.DataSource = MembresiaBLL.Mostrar();
            dgvMembresia.AutoGenerateColumns = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar esta Membresia?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvMembresia.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectRow = dgvMembresia.SelectedRows[0];
                        int deleteEmpleado = Convert.ToInt32(selectRow.Cells["IDMembresia"].Value);
                        bool resultado = MembresiaBLL.Eliminar(deleteEmpleado);

                        if (resultado)
                        {
                            MessageBox.Show("¡Membresia Eliminada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvMembresia.DataSource = MembresiaBLL.Mostrar();
                        }
                        else
                        {
                            MessageBox.Show("Error al Tratar de Eliminar la Membresia", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Empleado, \nDetalles A Continuacion.\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Empleado, \nDetalles A Continuacion.\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}

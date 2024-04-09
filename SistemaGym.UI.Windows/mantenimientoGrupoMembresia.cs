using SistemaGym.BLL;
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
    public partial class mantenimientoGrupoMembresia : Form
    {
        public mantenimientoGrupoMembresia()
        {
            InitializeComponent();
        }

        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarGrupoMembresia nuevoGrupoMembresia = new registrarGrupoMembresia();
            nuevoGrupoMembresia.Show();
        }

        private void mantenimientoGrupoMembresia_Load(object sender, EventArgs e)
        {
            dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
            dgvGrupoMembresia.AutoGenerateColumns = false;
            CargarMembresia();
        }

        private void CargarMembresia()
        {
            var colIDMembresia = (DataGridViewComboBoxColumn)dgvGrupoMembresia.Columns["IDMembresia"];
            colIDMembresia.DataSource = MembresiaBLL.Mostrar();
            colIDMembresia.ValueMember = "IDMembresia";
            colIDMembresia.DisplayMember = "Nombre";
            colIDMembresia.DataPropertyName = "IDMembresia";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
            dgvGrupoMembresia.AutoGenerateColumns = false;
            CargarMembresia();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvGrupoMembresia.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<GrupoMembresiaEntity> grupoMembresiaActualizar = ConvertirDatatableALista(changeData);

                    foreach (GrupoMembresiaEntity grupoMembresia in grupoMembresiaActualizar)
                    {
                        GrupoMembresiaBLL.actualizar(grupoMembresia);
                    }

                    MessageBox.Show("Dato(s) del Grupo de Membresia ha(n) sido Editado(s) de manera Satisfactoria", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar el Grupo de Membresia. \nDetalles a Continuacion\n: {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar el Grupo de Membresia. \nDetalles a Continuacion\n: {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<GrupoMembresiaEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<GrupoMembresiaEntity> grupoMembresiaList = new List<GrupoMembresiaEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                GrupoMembresiaEntity grupoMembresia = new GrupoMembresiaEntity
                {
                    IDGrupoMembresia = Convert.ToInt32(fila["IDGrupoMembresia"]),
                    IDMembresia = Convert.ToInt32(fila["IDMembresia"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    MontoTotal = Convert.ToDecimal(fila["MontoTotal"]),
                    FechaRegistro = Convert.ToDateTime(fila["FechaRegistro"]),
                    Estatus = Convert.ToString(fila["Estatus"])
                };

                grupoMembresiaList.Add(grupoMembresia);
            }

            return grupoMembresiaList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Grupo de Membresia?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvGrupoMembresia.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectRow = dgvGrupoMembresia.SelectedRows[0];
                        int deleteEmpleado = Convert.ToInt32(selectRow.Cells["IDGrupoMembresia"].Value);
                        bool resultado = GrupoMembresiaBLL.Eliminar(deleteEmpleado);

                        if (resultado)
                        {
                            MessageBox.Show("¡Grupo de Membresia Eliminado con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
                        }
                        else
                        {
                            MessageBox.Show("Error al Tratar de Eliminar el Grupo de Membresia", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Grupo de Membresia, \nDetalles A Continuacion.\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Grupo de Membresia, \nDetalles A Continuacion.\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (dialogResult == DialogResult.No)
                {

                }

            }
        }
    }
}

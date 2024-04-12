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
    public partial class mantenimientoGrupoClientes : Form
    {
        public mantenimientoGrupoClientes()
        {
            InitializeComponent();
        }
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarGrupoClientes nuevoGrupoCliente = new registrarGrupoClientes();
            nuevoGrupoCliente.Show();
        }

        private void mantenimientoGrupoClientes_Load(object sender, EventArgs e)
        {
            dgvGrupoClientes.DataSource = GrupoClienteBLL.Mostrar();
            dgvGrupoClientes.AutoGenerateColumns = false;
            CargarCliente();
            CargarGrupoMembresia();
        }

        private void CargarCliente()
        {
            var colIDCliente = (DataGridViewComboBoxColumn)dgvGrupoClientes.Columns["IDCliente"];
            colIDCliente.DataSource = ClientesBLL.MostrarCliente();
            colIDCliente.ValueMember = "IDCliente";
            colIDCliente.DisplayMember = "Nombre";
            colIDCliente.DataPropertyName = "IDCliente";
        }

        private void CargarGrupoMembresia()
        {
            var colGrupoMembresia = (DataGridViewComboBoxColumn)dgvGrupoClientes.Columns["IDGrupoMembresia"];
            colGrupoMembresia.DataSource = GrupoMembresiaBLL.MostrarGrupoMembresia();
            colGrupoMembresia.ValueMember = "IDGrupoMembresia";
            colGrupoMembresia.DisplayMember = "Nombre";
            colGrupoMembresia.DataPropertyName = "IDGrupoMembresia";
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dgvGrupoClientes.DataSource = GrupoClienteBLL.Mostrar();
            dgvGrupoClientes.AutoGenerateColumns = false;
            CargarCliente();
            CargarGrupoMembresia();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvGrupoClientes.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<GrupoClienteEntity> grupoClienteActualizar = ConvertirDatatableALista(changeData);

                    foreach (GrupoClienteEntity grupoCliente in grupoClienteActualizar)
                    {
                        GrupoClienteBLL.Actualizar(grupoCliente);
                    }

                    MessageBox.Show("Dato(s) del Grupo de Clientes ha(n) sido Editado(s) de manera Satisfactoria", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvGrupoClientes.DataSource = GrupoClienteBLL.Mostrar();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar el Grupo de Clientes. \nDetalles a Continuacion\n: {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar el Grupo de Clientes. \nDetalles a Continuacion\n: {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<GrupoClienteEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<GrupoClienteEntity> grupoClienteList = new List<GrupoClienteEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                GrupoClienteEntity grupoCliente = new GrupoClienteEntity
                {
                    IDGrupoCliente = Convert.ToInt32(fila["IDGrupoCliente"]),
                    IDGrupoMembresia = Convert.ToInt32(fila["IDGrupoMembresia"]),
                    IDCliente = Convert.ToInt32(fila["IDCliente"]),
                    Monto = Convert.ToDecimal(fila["Monto"]),
                    FechaRegistro = Convert.ToDateTime(fila["FechaRegistro"]),
                    Estatus = Convert.ToString(fila["Estatus"])
                };

                grupoClienteList.Add(grupoCliente);
            }

            return grupoClienteList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Grupo de Membresia?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvGrupoClientes.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectRow = dgvGrupoClientes.SelectedRows[0];
                        int deleteEmpleado = Convert.ToInt32(selectRow.Cells["IDGrupoCliente"].Value);
                        bool resultado = GrupoClienteBLL.Eliminar(deleteEmpleado);

                        if (resultado)
                        {
                            MessageBox.Show("¡Grupo de Cliente Eliminado con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvGrupoClientes.DataSource = GrupoClienteBLL.Mostrar();
                        }
                        else
                        {
                            MessageBox.Show("Error al Tratar de Eliminar el Grupo de Cliente", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Grupo de Cliente, \nDetalles A Continuacion.\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

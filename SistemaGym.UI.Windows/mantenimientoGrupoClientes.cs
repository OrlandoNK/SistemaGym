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
                    List<GrupoClientesEntity> grupoMembresiaActualizar = ConvertirDatatableALista(changeData);

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
    }
}

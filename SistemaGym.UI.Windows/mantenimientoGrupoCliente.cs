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
    public partial class mantenimientoGrupoCliente : Form
    {
        public mantenimientoGrupoCliente()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarIDGrupoMembresia_Click(object sender, EventArgs e)
        {
            var buscarGrupoMembresia = new listaGrupoMembresia();

            if (buscarGrupoMembresia.ShowDialog() == DialogResult.OK)
            {
                MembresiaEntity oGrupoMembresia = MembresiaDAL.ObtenerMembresiaByID(buscarGrupoMembresia.IdGrupoMembresia);
                if (oGrupoMembresia != null)
                {
                    TxbIDGrupoMembresia.Text = oGrupoMembresia.IDMembresia.ToString();
                }
            }
            else
            {
                MessageBox.Show("Grupo de Membresia No Encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarIDCliente_Click(object sender, EventArgs e)
        {
            var buscarClientes = new listaClientes();

            if (buscarClientes.ShowDialog() == DialogResult.OK)
            {
                ClientesEntity oClientes = ClientesDAL.ObtenerByID(buscarClientes.IdCliente);
                if (oClientes != null)
                {
                    TxbIDCliente.Text = oClientes.IDCliente.ToString();
                }
            }
            else
            {
                MessageBox.Show("Cliente No Encontrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GrupoClienteEntity nuevoGrupoCliente = new GrupoClienteEntity();

            if (string.IsNullOrEmpty(TxbIDGrupoMembresia.Text))
            {
                errorProvider.SetError(TxbIDGrupoMembresia, "Por Favor, Debes llenar este Campo");
                return;

            }

            else if (string.IsNullOrEmpty(TxbIDCliente.Text))
            {
                errorProvider.SetError(TxbIDCliente, "Por Favor, Debes llenar este Campo");
                return;
            }

            nuevoGrupoCliente.IDGrupoMembresia = Convert.ToInt32(TxbIDGrupoMembresia.Text);
            nuevoGrupoCliente.IDCliente = Convert.ToInt32(TxbIDCliente.Text);
            nuevoGrupoCliente.FechaRegistro = DateTime.Now;
            nuevoGrupoCliente.Estatus = "Activo";

            GrupoClienteDAL.InsertarGrupoCliente(nuevoGrupoCliente);
            MessageBox.Show("Grupo de Clientes Registrado de Manera Correcta", "Grupo de Cliente Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            dgvGrupoClientes.DataSource = GrupoClienteDAL.MostrarGrupoCliente();
        }

        private void LimpiarCampos()
        {
            TxbIDGrupoMembresia.Clear();
            TxbIDCliente.Clear();
        }

        private void btnTraerClientes_Click(object sender, EventArgs e)
        {
            dgvGrupoClientes.DataSource = GrupoClienteDAL.MostrarGrupoCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult resultDialog = MessageBox.Show("¿Seguro que desea eliminar a este Grupo de Clientes?", "¿Eliminar Grupo de Clientes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
            {
                if (dgvGrupoClientes.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectRow = dgvGrupoClientes.SelectedRows[0];

                    int idDelete = Convert.ToInt32(selectRow.Cells["IDGrupoCliente"].Value);
                    bool resultado = GrupoClienteBLL.Eliminar(idDelete);


                    if (resultado)
                    {
                        MessageBox.Show("¡Grupo de Clientes Eliminado con Éxito!", "GRUPO DE CLIENTES ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvGrupoClientes.DataSource = GrupoClienteBLL.Mostrar();
                    }
                    else
                    {
                        MessageBox.Show("Error al tratar de eliminar el Grupo de Clientes", "Error de Eliminación de Grupo de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (resultDialog == DialogResult.No)
                {

                }
            }
        }

        private void btnagregargrupomembresia_Click(object sender, EventArgs e)
        {
            mantenimientoGrupoMembresia grupoMembresia = new mantenimientoGrupoMembresia();
            grupoMembresia.Show();
        }
    }
}

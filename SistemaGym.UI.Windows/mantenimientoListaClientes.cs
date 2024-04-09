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
    public partial class mantenimientoListaClientes : Form
    {
        private string sistema = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        public mantenimientoListaClientes()
        {
            InitializeComponent();
        }

        private void mantenimientoListaClientes_Load(object sender, EventArgs e)
        {
            dgvListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
            dgvListaCliente.AutoGenerateColumns = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmListaCliente frmListaCliente = new frmListaCliente();
            frmListaCliente.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
            dgvListaCliente.AutoGenerateColumns = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvListaCliente.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<TipoListaClienteEntity> listaclientesEntities = ConvertirDatatableALista(changeData);

                    foreach (TipoListaClienteEntity oListaCliente in listaclientesEntities)
                    {
                        TipoListaClienteBLL.Actualizar(oListaCliente);
                    }

                    MessageBox.Show("¡Se Ha Modificado la Lista de Cliente Correctamente!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar la Lista de Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar la Lista de Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<TipoListaClienteEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<TipoListaClienteEntity> TipoListaClientesList = new List<TipoListaClienteEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                TipoListaClienteEntity tipolistaclientes = new TipoListaClienteEntity
                {
                    IDTipoListaCliente = Convert.ToInt32(fila["IDTipoListaCliente"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Descripcion = Convert.ToString(fila["Descripcion"])
                };

                TipoListaClientesList.Add(tipolistaclientes);
            }
            return TipoListaClientesList;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Tipo Lista de Cliente?", sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvListaCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectRow = dgvListaCliente.SelectedRows[0];
                    int deleteCliente = Convert.ToInt32(selectRow.Cells["IDTipoListaCliente"].Value);
                    bool deleteProcess = TipoListaClienteBLL.Eliminar(deleteCliente);

                    if (deleteProcess)
                    {
                        MessageBox.Show("¡El Tipo Lista de Cliente ha sido Eliminado con Exito!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
                    }
                    else
                    {
                        MessageBox.Show("Error al Tratar de Eliminar El Tipo Lista de Cliente", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

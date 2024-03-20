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
    public partial class mantenimientoTipoClientes : Form
    {
        private string sistema = "Sistema Gestión Gimnasion (COMFORT GYM) dice";
        public mantenimientoTipoClientes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoCliente nuevoTipoCliente = new frmTipoCliente();
            nuevoTipoCliente.Show();
        }

        private void mantenimientoTipoClientes_Load(object sender, EventArgs e)
        {
            dgvTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
            dgvTipoCliente.AutoGenerateColumns = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
            dgvTipoCliente.AutoGenerateColumns = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvTipoCliente.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<TipoClienteEntity> clientesEntities = ConvertirDatatableALista(changeData);

                    foreach (TipoClienteEntity oCliente in clientesEntities)
                    {
                        TipoClienteBLL.Actualizar(oCliente);
                    }

                    MessageBox.Show("¡Se Ha Modificado el Tipo de Cliente Correctamente!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Tipo de Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Tipo de Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<TipoClienteEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<TipoClienteEntity> TipoClientesList = new List<TipoClienteEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                TipoClienteEntity tipoclientes = new TipoClienteEntity
                {
                    IDTipoCliente = Convert.ToInt32(fila["IDTipoCliente"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Descripcion = Convert.ToString(fila["Descripcion"]),
                    FechaCreacion = Convert.ToDateTime(fila["FechaCreacion"])
                };

                TipoClientesList.Add(tipoclientes);
            }
            return TipoClientesList;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Tipo de Cliente?", sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvTipoCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectRow = dgvTipoCliente.SelectedRows[0];
                    int deleteCliente = Convert.ToInt32(selectRow.Cells["IDTipoCliente"].Value);
                    bool deleteProcess = TipoClienteBLL.Eliminar(deleteCliente);

                    if (deleteProcess)
                    {
                        MessageBox.Show("¡El Tipo de Cliente ha sido Eliminado con Exito!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
                    }
                    else
                    {
                        MessageBox.Show("Error al Tratar de Eliminar el Cliente", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}

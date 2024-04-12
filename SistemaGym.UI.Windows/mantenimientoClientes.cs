using Microsoft.VisualBasic;
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
    public partial class frmClientes : Form
    {
        const string sistema = "Sistema Gestion Gimnasion (COMFORT GYM) dice:";
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ClientesBLL.MostrarCliente();
            dgvClientes.AutoGenerateColumns = false;
            CargarUsuarios();
            CargarMembresia();
            CargarTipoCliente();
            CargarTipoListaCliente();
        }

        private void CargarUsuarios()
        {
            var colUsuario = (DataGridViewComboBoxColumn)dgvClientes.Columns["IDUsuario"];

            colUsuario.DataSource = UsuarioBLL.Mostrar();
            colUsuario.ValueMember = "IDUsuario";
            colUsuario.DisplayMember = "NombreUsuario";
            colUsuario.DataPropertyName = "IDUsuario";


        }
        private void CargarMembresia()
        {
            var colMembresia = (DataGridViewComboBoxColumn)dgvClientes.Columns["IDMembresia"];

            colMembresia.DataSource = MembresiaBLL.Mostrar();
            colMembresia.ValueMember = "IDMembresia";
            colMembresia.DisplayMember = "Nombre";
            colMembresia.DataPropertyName = "IDMembresia";

        }
        private void CargarTipoListaCliente()
        {
            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvClientes.Columns["TipoListaCliente"];

            colTipoListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
            colTipoListaCliente.ValueMember = "IDTipoListaCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoListaCliente";

        }
        private void CargarTipoCliente()
        {

            var colTipoListaCliente = (DataGridViewComboBoxColumn)dgvClientes.Columns["TipoCliente"];

            colTipoListaCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
            colTipoListaCliente.ValueMember = "IDTipoCliente";
            colTipoListaCliente.DisplayMember = "Nombre";
            colTipoListaCliente.DataPropertyName = "TipoCliente";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevoCliente nuevoCliente = new nuevoCliente();
            nuevoCliente.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvClientes.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<ClientesEntity> clientesEntities = ConvertirDatatableALista(changeData);

                    foreach (ClientesEntity oCliente in clientesEntities)
                    {
                        ClientesBLL.update(oCliente);
                    }

                    MessageBox.Show("¡Se Ha Modificado el Cliente Correctamente!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvClientes.DataSource = ClientesBLL.MostrarCliente();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<ClientesEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<ClientesEntity> ClientesList = new List<ClientesEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                ClientesEntity clientes = new ClientesEntity
                {
                    IDCliente = Convert.ToInt32(fila["IDCliente"]),
                    IDUsuario = Convert.ToInt32(fila["IDUsuario"]),
                    IDMembresia = Convert.ToInt32(fila["IDMembresia"]),
                    TipoListaCliente = Convert.ToInt32(fila["TipoListaCliente"]),
                    TipoCliente = Convert.ToInt32(fila["TipoCliente"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Apellido = Convert.ToString(fila["Apellido"]),
                    TipoDocumento = Convert.ToString(fila["TipoDocumento"]),
                    Documento = Convert.ToString(fila["Documento"]),
                    Direccion = Convert.ToString(fila["Direccion"]),
                    TelCell = Convert.ToString(fila["TelCell"]),
                    TelRes = Convert.ToString(fila["TelRes"]),
                    FechaRegistro = Convert.ToDateTime(fila["FechaRegistro"]),
                    Estatus = Convert.ToString(fila["Estatus"])
                };

                ClientesList.Add(clientes);
            }
            return ClientesList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Cliente?", sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectRow = dgvClientes.SelectedRows[0];
                    int deleteCliente = Convert.ToInt32(selectRow.Cells["IDCliente"].Value);
                    bool deleteProcess = ClientesBLL.Eliminar(deleteCliente);

                    if (deleteProcess)
                    {
                        MessageBox.Show("¡Cliente Eliminado con Exito!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvClientes.DataSource = ClientesBLL.MostrarCliente();
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

        private void btnUpdateDGV_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ClientesBLL.MostrarCliente();
            dgvClientes.AutoGenerateColumns = false;
        }

        private void btnTipoCliente_Click(object sender, EventArgs e)
        {
            mantenimientoTipoClientes tipoClientes = new mantenimientoTipoClientes();
            tipoClientes.Show();
        }

        private void btnListaCliente_Click(object sender, EventArgs e)
        {
            mantenimientoListaClientes listaClientes = new mantenimientoListaClientes();
            listaClientes.Show();
        }

        private void btnGrupoClientes_Click(object sender, EventArgs e)
        {
            mantenimientoGrupoClientes grupoClientes = new mantenimientoGrupoClientes();
            grupoClientes.Show();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            mantenimientoAsistenciaClientes asistenciaClientes = new mantenimientoAsistenciaClientes();
            asistenciaClientes.Show();
        }
    }

}

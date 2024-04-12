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
    public partial class mantenimientoAsistenciaClientes : Form
    {
        public mantenimientoAsistenciaClientes()
        {
            InitializeComponent();
        }
        private string sistema = "Sistema Gestión Gimnasion (COMFORT GYM) dice";
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            registrarAsistenciaClientes nuevaAsistencia = new registrarAsistenciaClientes();
            nuevaAsistencia.Show();
        }

        private void mantenimientoAsistenciaClientes_Load(object sender, EventArgs e)
        {
            dgvAsistenciaClientes.DataSource = AsistenciaClientesBLL.MostrarAsistencia();
            dgvAsistenciaClientes.AutoGenerateColumns = false;
            CargarCliente();
        }
        private void CargarCliente()
        {
            var colIDCliente = (DataGridViewComboBoxColumn)dgvAsistenciaClientes.Columns["IDCliente"];
            colIDCliente.DataSource = ClientesBLL.MostrarCliente();
            colIDCliente.ValueMember = "IDCliente";
            colIDCliente.DisplayMember = "Nombre";
            colIDCliente.DataPropertyName = "IDCliente";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvAsistenciaClientes.DataSource = AsistenciaClientesBLL.MostrarAsistencia();
            dgvAsistenciaClientes.AutoGenerateColumns = false;
            CargarCliente();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvAsistenciaClientes.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<AsistenciaClientesEntity> asistenciaClientes = ConvertirDatatableALista(changeData);

                    foreach (AsistenciaClientesEntity oAsistencias in asistenciaClientes)
                    {
                        AsistenciaClientesBLL.Actualizar(oAsistencias);
                    }

                    MessageBox.Show("¡Se Ha Modificado la Asistencia del Cliente Correctamente!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAsistenciaClientes.DataSource = TipoClienteBLL.MostrarTipoCliente();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar la Asistencia del Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar la Asistencia del Cliente: \n{ex.Message}", sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<AsistenciaClientesEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<AsistenciaClientesEntity> AsistenciaClientesList = new List<AsistenciaClientesEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                AsistenciaClientesEntity asistenciaClientes = new AsistenciaClientesEntity
                {
                    IDAsistenciaCliente = Convert.ToInt32(fila["IDAsistenciaCliente"]),
                    IDCliente = Convert.ToInt32(fila["IDCliente"]),
                    Asistencia = Convert.ToBoolean(fila["Asistencia"]),
                    FechaAsistencia = Convert.ToDateTime(fila["FechaAsistencia"]),
                };

                AsistenciaClientesList.Add(asistenciaClientes);
            }
            return AsistenciaClientesList;
        }
    }
}

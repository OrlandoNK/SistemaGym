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
    public partial class mantenimientoFacturacionMembresia : Form
    {
        private FacturaMembresiaBLL facturaMembresiaBLL = new FacturaMembresiaBLL();

        public mantenimientoFacturacionMembresia()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mantenimientoFacturacionMembresia_Load(object sender, EventArgs e)
        {
            dgvFacturacionMembresia.DataSource = facturaMembresiaBLL.Mostrar();
            CargarCliente();
            CargarMembresia();
            CargarUsuario();
            CargarCargoCredito();
            CargarCargoDebito();
            dgvFacturacionMembresia.AutoGenerateColumns = false;
        }

        private void CargarMembresia()
        {
            var colIDMembresia = (DataGridViewComboBoxColumn)dgvFacturacionMembresia.Columns["IDMembresia"];
            colIDMembresia.DataSource = MembresiaBLL.Mostrar();
            colIDMembresia.ValueMember = "IDMembresia";
            colIDMembresia.DisplayMember = "Nombre";
            colIDMembresia.DataPropertyName = "IDMembresia";
        }
        private void CargarCliente()
        {
            var colIDCliente = (DataGridViewComboBoxColumn)dgvFacturacionMembresia.Columns["IDCliente"];
            colIDCliente.DataSource = ClientesBLL.MostrarCliente();
            colIDCliente.ValueMember = "IDCliente";
            colIDCliente.DisplayMember = "Nombre";
            colIDCliente.DataPropertyName = "IDCliente";
        }

        private void CargarUsuario()
        {
            var colIDUsuario = (DataGridViewComboBoxColumn)dgvFacturacionMembresia.Columns["IDUsuario"];
            colIDUsuario.DataSource = UsuarioBLL.Mostrar();
            colIDUsuario.ValueMember = "IDUsuario";
            colIDUsuario.DisplayMember = "Nombre";
            colIDUsuario.DataPropertyName = "IDUsuario";
        }
        private void CargarCargoCredito()
        {
            var colCargoCredito = (DataGridViewComboBoxColumn)dgvFacturacionMembresia.Columns["CargoCredito"];
            colCargoCredito.DataSource = CargoCreditoBLL.MostrarCargoCredito();
            colCargoCredito.ValueMember = "IDCargoCredito";
            colCargoCredito.DisplayMember = "Cargo";
            colCargoCredito.DataPropertyName = "CargoCredito";
        }

        private void CargarCargoDebito()
        {
            var colCargoDebito = (DataGridViewComboBoxColumn)dgvFacturacionMembresia.Columns["CargoDebito"];
            colCargoDebito.DataSource = CargoDebitoBLL.MostrarCargoDebito();
            colCargoDebito.ValueMember = "IDCargoDebito";
            colCargoDebito.DisplayMember = "Cargo";
            colCargoDebito.DataPropertyName = "CargoDebito";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            nuevaFacturaMembresia nuevaFacturaMembresia = new nuevaFacturaMembresia();
            nuevaFacturaMembresia.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvFacturacionMembresia.DataSource = facturaMembresiaBLL.Mostrar();
            CargarMembresia();
            CargarCliente();
            CargarUsuario();
            CargarCargoCredito();
            CargarCargoDebito();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string SYSTEM_TITLE = "SISTEMA GESTION GIMNASIO (COMFORT GYM)";

            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar esta Factura Membresia?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                if (dgvFacturacionMembresia.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectRow = dgvFacturacionMembresia.SelectedRows[0];
                    int deleteFacturaMembresia = Convert.ToInt32(selectRow.Cells["IDFactura"].Value);
                    bool deleteProcess = facturaMembresiaBLL.Eliminar(deleteFacturaMembresia);

                    if (deleteProcess)
                    {
                        MessageBox.Show("¡Factura de Membresia Eliminada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFacturacionMembresia.DataSource = facturaMembresiaBLL.Mostrar();
                    }
                    else
                    {
                        MessageBox.Show("Error al Tratar de Eliminar la Factura de Membresia", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            if (dialogResult == DialogResult.No)
            {

            }

        }

        private List<FacturaMembresiaEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<FacturaMembresiaEntity> facturaMembresiaList = new List<FacturaMembresiaEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                FacturaMembresiaEntity facturaMembresia = new FacturaMembresiaEntity
                {
                    IDFactura = Convert.ToInt32(fila["IDFactura"]),
                    IDMembresia = Convert.ToInt32(fila["IDMembresia"]),
                    IDCliente = Convert.ToInt32(fila["IDCliente"]),
                    IDUsuario = Convert.ToInt32(fila["IDUsuario"]),
                    CargoCredito = Convert.ToInt32(fila["CargoCredito"]),
                    CargoDebito = Convert.ToInt32(fila["CargoDebito"]),
                    NCF = Convert.ToString(fila["NCF"]),
                    ValorFactura = Convert.ToDecimal(fila["ValorFactura"]),
                    FechaEmision = Convert.ToDateTime(fila["FechaEmision"]),
                    FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]),
                    Estatus = Convert.ToString(fila["Estatus"])
                };

                facturaMembresiaList.Add(facturaMembresia);
            }
            return facturaMembresiaList;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string SYSTEM_TITLE = "SISTEMA GESTION GIMNASIO (COMFORT GYM)";
            try
            {
                DataTable changeData = ((DataTable)dgvFacturacionMembresia.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<FacturaMembresiaEntity> facturaMembresiasEntities = ConvertirDatatableALista(changeData);

                    foreach (FacturaMembresiaEntity facturaMembresia in facturaMembresiasEntities)
                    {
                        facturaMembresiaBLL.Actualizar(facturaMembresia);
                    }

                    MessageBox.Show("¡Se Ha Modificado la Factura de Membresia Correctamente!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvFacturacionMembresia.DataSource = facturaMembresiaBLL.Mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar la Factura Membresia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbBuscar.Text;

            DataTable resultBusqueda = facturaMembresiaBLL.ObtenerByValor(buscar);
            dgvFacturacionMembresia.DataSource = resultBusqueda;
        }
    }
}

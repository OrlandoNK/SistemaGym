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
    public partial class mantenimientoFacturaProductos : Form
    {
        public mantenimientoFacturaProductos()
        {
            InitializeComponent();
        }
        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmFacturaProductos nuevaFacturaProductos = new frmFacturaProductos();
            nuevaFacturaProductos.Show();
        }

        private void mantenimientoFacturaProductos_Load(object sender, EventArgs e)
        {
            dgvFacturaProducto.DataSource = FacturacionProductoBLL.Mostrar();
            CargarCliente();
            CargarUsuario();
            dgvFacturaProducto.AutoGenerateColumns = false;

        }

        private void CargarCliente()
        {
            var colIDCliente = (DataGridViewComboBoxColumn)dgvFacturaProducto.Columns["IDCliente"];
            colIDCliente.DataSource = ClientesBLL.MostrarCliente();
            colIDCliente.ValueMember = "IDCliente";
            colIDCliente.DisplayMember = "Nombre";
            colIDCliente.DataPropertyName = "IDCliente";
        }

        private void CargarUsuario()
        {
            var colIDUsuario = (DataGridViewComboBoxColumn)dgvFacturaProducto.Columns["IDUsuario"];
            colIDUsuario.DataSource = UsuarioBLL.Mostrar();
            colIDUsuario.ValueMember = "IDUsuario";
            colIDUsuario.DisplayMember = "Nombre";
            colIDUsuario.DataPropertyName = "IDUsuario";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvFacturaProducto.DataSource = FacturacionProductoBLL.Mostrar();
            CargarCliente();
            CargarUsuario();
            dgvFacturaProducto.AutoGenerateColumns = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvFacturaProducto.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<FacturaProductoEntity> facturaProductosEntities = ConvertirDatatableALista(changeData);

                    foreach (FacturaProductoEntity facturaProducto in facturaProductosEntities)
                    {
                        FacturacionProductoBLL.Actualizar(facturaProducto);
                    }

                    MessageBox.Show("¡Se Ha Modificado la Factura de Producto Correctamente!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvFacturaProducto.DataSource = FacturacionProductoBLL.Mostrar();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar la Factura Producto:\n {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar la Factura Producto:\n {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<FacturaProductoEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<FacturaProductoEntity> facturaProductoList = new List<FacturaProductoEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                FacturaProductoEntity facturaProducto = new FacturaProductoEntity
                {
                    IDFactura = Convert.ToInt32(fila["IDFactura"]),
                    IDCliente = Convert.ToInt32(fila["IDCliente"]),
                    IDUsuario = Convert.ToInt32(fila["IDUsuario"]),
                    NCF = Convert.ToString(fila["NCF"]),
                    SubTotal = Convert.ToDecimal(fila["Subtotal"]),
                    TotalDescuento = Convert.ToDecimal(fila["TotalDescuento"]),
                    TotalItbis = Convert.ToDecimal(fila["TotalItbis"]),
                    Total = Convert.ToDecimal(fila["Total"]),
                    FechaEmision = Convert.ToDateTime(fila["FechaEmision"]),
                    FechaVencimiento = Convert.ToDateTime(fila["FechaVencimiento"]),
                    Estatus = Convert.ToString(fila["Estatus"])
                };

                facturaProductoList.Add(facturaProducto);
            }
            return facturaProductoList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar esta Factura Membresia?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvFacturaProducto.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectRow = dgvFacturaProducto.SelectedRows[0];
                        int deleteFacturaMembresia = Convert.ToInt32(selectRow.Cells["IDFactura"].Value);
                        bool deleteProcess = FacturacionProductoBLL.DeleteByID(deleteFacturaMembresia);

                        if (deleteProcess)
                        {
                            MessageBox.Show("¡Factura de Producto Eliminada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvFacturaProducto.DataSource = FacturacionProductoBLL.Mostrar();
                        }
                        else
                        {
                            MessageBox.Show("Error al Tratar de Eliminar la Factura de Producto", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se Ha Producido Un Error al Intentar Eliminar la Factura de Productos:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido Un Error al Intentar Eliminar la Factura de Productos:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDetalleFactura_Click(object sender, EventArgs e)
        {
            mantenimientoDetalleFacturaProducto detalleFacturaProducto = new mantenimientoDetalleFacturaProducto();
            detalleFacturaProducto.Show();
        }
    }
}

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
    public partial class mantenimientoDetalleFacturaProducto : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        public mantenimientoDetalleFacturaProducto()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mantenimientoDetalleFacturaProducto_Load(object sender, EventArgs e)
        {
            dgvDetalleFacturaProducto.DataSource = FacturacionProductoBLL.MostrarDetalle();
            CargarProducto();
            dgvDetalleFacturaProducto.AutoGenerateColumns = false;
        }
        private void CargarProducto()
        {
            var colProducto = (DataGridViewComboBoxColumn)dgvDetalleFacturaProducto.Columns["IDProducto"];
            colProducto.DataSource = ProductoBLL.GetAll();
            colProducto.ValueMember = "IDProducto";
            colProducto.DisplayMember = "Nombre";
            colProducto.DataPropertyName = "IDProducto";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvDetalleFacturaProducto.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<DetalleFacturaProductoEntity> detallefacturaProductosEntities = ConvertirDatatableALista(changeData);

                    foreach (DetalleFacturaProductoEntity detallefacturaProducto in detallefacturaProductosEntities)
                    {
                        DetalleFacturaProductoBLL.ActualizarDetalle(detallefacturaProducto);
                    }

                    MessageBox.Show("¡Se Ha Modificado el Detalle de Factura de Producto Correctamente!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDetalleFacturaProducto.DataSource = FacturacionProductoBLL.MostrarDetalle();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Detalle de Factura Producto:\n {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Modificar el Detalle de Factura Producto:\n {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<DetalleFacturaProductoEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<DetalleFacturaProductoEntity> detallefacturaProductoList = new List<DetalleFacturaProductoEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                DetalleFacturaProductoEntity detallefacturaProducto = new DetalleFacturaProductoEntity
                {
                    IDDetalleFacturaProducto = Convert.ToInt32(fila["IDDetalleFacturaProductos"]),
                    IDFacturaProducto = Convert.ToInt32(fila["IDProducto"]),
                    IDProducto = Convert.ToInt32(fila["IDProducto"]),
                    Precio = Convert.ToDecimal(fila["precio"]),
                    Cantidad = Convert.ToInt32(fila["cantidad"]),
                    SubTotal = Convert.ToDecimal(fila["Subototal"]),
                    Descuento = Convert.ToDecimal(fila["Descuento"]),
                    Itbis = Convert.ToDecimal(fila["Itbis"]),
                    Total = Convert.ToDecimal(fila["Total"])

                };

                detallefacturaProductoList.Add(detallefacturaProducto);
            }
            return detallefacturaProductoList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Seguro que Desea Eliminar este Detalle de Factura de Producto?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    if (dgvDetalleFacturaProducto.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectRow = dgvDetalleFacturaProducto.SelectedRows[0];
                        int deleteFacturaMembresia = Convert.ToInt32(selectRow.Cells["IDDetalleFacturaProductos"].Value);
                        bool deleteProcess = DetalleFacturaProductoBLL.EliminarDetalle(deleteFacturaMembresia);

                        if (deleteProcess)
                        {
                            MessageBox.Show("¡Detalle de Factura de Producto Eliminado con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvDetalleFacturaProducto.DataSource = FacturacionProductoBLL.MostrarDetalle();
                        }
                        else
                        {
                            MessageBox.Show("Error al Tratar de Eliminar el Detalle de Factura de Producto", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se Ha Producido Un Error al Intentar Eliminar el Detalle de Factura de Producto:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido Un Error al Intentar Eliminar el Detalle de Factura de Producto:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dialogResult == DialogResult.No)
            {

            }
        }

        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbBuscar.Text;

            DataTable resultBusqueda = DetalleFacturaProductoBLL.BuscarDetalle(buscar);
            dgvDetalleFacturaProducto.DataSource = resultBusqueda;
        }
    }
}

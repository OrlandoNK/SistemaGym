using SistemaGym.BLL;
using SistemaGym.DAL;
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
    public partial class MantenimientoProductos : Form
    {

        string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        public MantenimientoProductos()
        {
            InitializeComponent();
        }
        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ProductoBLL.GetAll();
            dgvProductos.AutoGenerateColumns = false;
            CargarCategoria();
            CargarProveedor();
        }

        private void CargarCategoria()
        {
            var colCategoria = (DataGridViewComboBoxColumn)dgvProductos.Columns["IDCategoria"];
            colCategoria.DataSource = CategoriaProductoBLL.Mostrar();
            colCategoria.ValueMember = "IDCategoria";
            colCategoria.DisplayMember = "Nombre";
            colCategoria.DataPropertyName = "Categoria";
        }
        private void CargarProveedor()
        {
            var colProveedor = (DataGridViewComboBoxColumn)dgvProductos.Columns["IDProveedor"];

            colProveedor.ValueMember = "IDProveedor";
            colProveedor.DisplayMember = "Nombre";
            colProveedor.DataPropertyName = "IDProveedor";
            colProveedor.DataSource = ProveedoresBLL.MostrarProveedores();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            registrarProducto nuevoProducto = new registrarProducto();
            nuevoProducto.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductoBLL productoBLL = new ProductoBLL();
            if (dgvProductos.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar este Producto?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        if (dgvProductos.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectRow = dgvProductos.SelectedRows[0];
                            int deleteEmpleado = Convert.ToInt32(selectRow.Cells["IDProducto"].Value);
                            bool resultado = productoBLL.DeleteProduct(deleteEmpleado);

                            if (resultado)
                            {
                                MessageBox.Show("¡El Producto ha sido Eliminado con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvProductos.DataSource = ProductoBLL.GetAll();
                            }
                            else
                            {
                                MessageBox.Show("Error al Tratar de Eliminar el Producto", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Producto, \nDetalles A Continuacion.\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Se ha producido un Error al Intentar Eliminar el Producto, \nDetalles A Continuacion.\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ProductoBLL.GetAll();
            dgvProductos.AutoGenerateColumns = false;
            CargarCategoria();
            CargarProveedor();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvProductos.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<ProductoEntity> productoActualizar = ConvertirDatatableALista(changeData);

                    foreach (ProductoEntity producto in productoActualizar)
                    {
                        ProductoBLL.Actualizar(producto);
                    }

                    MessageBox.Show("¡El Producto ha sido Modificado con Éxito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProductos.DataSource = ProductoBLL.GetAll();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar el Producto. \nDetalles a Continuacion\n: {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar el Producto. \nDetalles a Continuacion\n: {ex.Message}", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<ProductoEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<ProductoEntity> ProductList = new List<ProductoEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                ProductoEntity producto = new ProductoEntity
                {
                    IDProducto = Convert.ToInt32(fila["IDProducto"]),
                    IDCategoria = Convert.ToInt32(fila["IDCategoria"]),
                    IDProveedor = Convert.ToInt32(fila["IDProveedor"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    PrecioUnitario = Convert.ToDecimal(fila["PrecionUnitario"]),
                    Stock = Convert.ToInt32(fila["Stock"])
                };

                ProductList.Add(producto);
            }

            return ProductList;
        }
        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbBuscar.Text;

            DataTable resultBusqueda = ProductoBLL.BuscarProducto(buscar);
            CargarCategoria();
            CargarProveedor();
            dgvProductos.DataSource = resultBusqueda;
        }
    }
}
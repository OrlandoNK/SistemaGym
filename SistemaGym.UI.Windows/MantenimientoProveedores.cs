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
using static Guna.UI2.Native.WinApi;

namespace SistemaGym.UI.Windows
{
    public partial class MantenimientoProveedores : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        ProveedoresBLL proveedoresBLL = new ProveedoresBLL();

        public MantenimientoProveedores()
        {
            InitializeComponent();
        }

        private void MantenimientoProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
            dgvProveedores.AutoGenerateColumns = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvProveedores.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar este Proveedor?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int idProveedor = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["IDProveedor"].Value);

                        bool seElimino = ProveedoresBLL.Eliminar(idProveedor);


                        if (seElimino)
                        {
                            dgvProveedores.Rows.RemoveAt(dgvProveedores.SelectedRows[0].Index);
                            MessageBox.Show("¡Proveedor Eliminado Satisfactoriamente!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
                        }
                        else
                        {
                            MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Proveedor", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Proveedor. \nDetalles a continuacion\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Proveedor. \nDetalles a continuacion\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            registrarProveedores nuevoProveedor = new registrarProveedores();
            nuevoProveedor.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
            dgvProveedores.AutoGenerateColumns = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable changeData = ((DataTable)dgvProveedores.DataSource).GetChanges();

                if (changeData != null)
                {
                    List<ProveedoresEntity> proveedorActualizar = ConvertirDatatableALista(changeData);

                    foreach (ProveedoresEntity proveedor in proveedorActualizar)
                    {
                        ProveedoresBLL.Actualizar(proveedor);
                    }

                    MessageBox.Show("¡Dato(s) del Proveedor Actualizado(s) Correctamente!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se Produjo un Error al Intentar Actualizar: \n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<ProveedoresEntity> ConvertirDatatableALista(DataTable dataTbl)
        {
            List<ProveedoresEntity> proveedorList = new List<ProveedoresEntity>();

            foreach (DataRow fila in dataTbl.Rows)
            {
                ProveedoresEntity proveedoresEntity = new ProveedoresEntity
                {
                    IDProveedor = Convert.ToInt32(fila["IDProveedor"]),
                    Nombre = Convert.ToString(fila["Nombre"]),
                    Telefono = Convert.ToString(fila["Telefono"]),
                    Direccion = Convert.ToString(fila["Direccion"]),
                    FechaRegistro = Convert.ToDateTime(fila["FechaRegistro"]),
                    Estatus = Convert.ToString(fila["Estatus"])
                };

                proveedorList.Add(proveedoresEntity);
            }

            return proveedorList;
        }

        private void TxbBuscar_TextChanged(object sender, EventArgs e)
        {
            string buscar = TxbBuscar.Text;

            DataTable resultBusqueda = ProveedoresBLL.BuscarProveedor(buscar);
            dgvProveedores.DataSource = resultBusqueda;
        }
    }
}

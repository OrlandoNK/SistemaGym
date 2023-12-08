using SistemaGym.BLL;
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
    public partial class MantenimientoProveedores : Form
    {
        public MantenimientoProveedores()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MantenimientoProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar este Registro de Proveedor?", "¿Guardar Proveedor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ProveedoresEntity nuevoProveedor = new ProveedoresEntity();

                nuevoProveedor.Nombre = TxbNombre.Text;
                nuevoProveedor.Telefono = TxbTelefono.Text;
                nuevoProveedor.Direccion = TxbDireccion.Text;
                nuevoProveedor.FechaRegistro = DateTime.Now;
                nuevoProveedor.Estatus = TxbEstatus.Text;


                if (TxbID.Text == "0")
                {
                    ProveedoresBLL.Guardar(nuevoProveedor);
                    MessageBox.Show("¡Proveedor Registrado de Manera Satisfactoria!", "MANTENIMIENTO PROVEEDOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
                }
            }

            if (result == DialogResult.No)
            {

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarCampos();
        }

        public void InicializarCampos()
        {
            TxbID.Text = "0";
            TxbNombre.Text = "";
            TxbTelefono.Text = "";
            TxbDireccion.Text = "";
            TxbEstatus.Text = "";
        }

        public void LimpiarCampos()
        {
            TxbID.Clear();
            TxbNombre.Clear();
            TxbTelefono.Clear();
            TxbDireccion.Clear();
            TxbEstatus.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProveedoresBLL proveedoresBLL = new ProveedoresBLL();

            if (dgvProveedores.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Seguro que desea Eliminar este Proveedor?", "¿Eliminar Proveedor?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int idProveedor = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells["IDProveedor"].Value);

                    bool seElimino = ProveedoresBLL.Eliminar(idProveedor);


                    if (seElimino)
                    {
                        dgvProveedores.Rows.RemoveAt(dgvProveedores.SelectedRows[0].Index);
                        MessageBox.Show("¡Proveedor Eliminado Satisfactoriamente!", "Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();
                    }
                    else
                    {
                        MessageBox.Show("Se Produjo un Error al Intentar Eliminar el Proveedor", "Error al Eliminar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
using static Guna.UI2.Native.WinApi;

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
            InicializarControles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;

            }
            //datos de control al objeto
            ProveedoresEntity oProveedor = new ProveedoresEntity();
            oProveedor.Nombre = TxbNombre.Text;
            oProveedor.Telefono = TxbTelefono.Text;
            oProveedor.Estatus = TxbEstatus.Text;
            oProveedor.FechaRegistro = DateTime.Parse(dtpFechaRegistro.Text);
            oProveedor.Direccion = TxbDireccion.Text;

            // guardar base datos
            try
            {
                ProveedoresBLL.Guardar(oProveedor);
                MessageBox.Show("Usuario Guardado", "Sistema Gym", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Gym", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(TxbDireccion.Text))
            {
                errorProvider.SetError(TxbDireccion, "obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(TxbNombre.Text))
            {
                errorProvider.SetError(TxbNombre, "El Nombre es obligatorio");
                resultado = false;
            }


            if (string.IsNullOrEmpty(TxbTelefono.Text))
            {
                errorProvider.SetError(TxbTelefono, "Obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(TxbDireccion.Text))
            {
                errorProvider.SetError(TxbDireccion, "La Direccion es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(dtpFechaRegistro.Text))
            {
                errorProvider.SetError(dtpFechaRegistro, "La Fecha es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(TxbEstatus.Text))
            {
                errorProvider.SetError(TxbEstatus, "El Estatus es obligatorio");
                resultado = false;
            }

            return resultado;
        }
        private void InicializarControles()
        {
            TxtID.Text = "0";
            TxbTelefono.Clear();
            TxbNombre.Clear();
            TxbEstatus.Clear();
            TxbDireccion.Clear();

            dgvProveedores.AutoGenerateColumns = false;
            dgvProveedores.DataSource = ProveedoresBLL.MostrarProveedores();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarCampos();
        }

        public void InicializarCampos()
        {
            TxtID.Text = "0";
            TxbNombre.Text = "";
            TxbTelefono.Text = "";
            TxbDireccion.Text = "";
            TxbEstatus.Text = "";
        }

        public void LimpiarCampos()
        {
            TxtID.Clear();
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

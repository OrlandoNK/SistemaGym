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
    }
}

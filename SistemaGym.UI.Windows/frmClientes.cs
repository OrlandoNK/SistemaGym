using Microsoft.VisualBasic;
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
    public partial class frmClientes : Form
    {
        const string sistema = "Sistema Gym";
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtidcliente.Text = "0";
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtTelCell.Clear();
            txtTelRes.Clear();
            CargarUsuarios();
            CargarMembresia();
            CargarTipoListaCliente();
            CargarTipoCliente();


        }
        private void CargarUsuarios()
        {
            cbUsuario.ValueMember = "IDUsuario";
            cbUsuario.DisplayMember = "NombreUsuario";
            cbUsuario.DataSource = UsuarioBLL.Mostrar();
        }
        private void CargarMembresia()
        {
            cbMembresia.ValueMember = "IDMembresia";
            cbMembresia.DisplayMember = "Nombre";
            cbMembresia.DataSource = MembresiaBLL.Mostrar();
        }
        private void CargarTipoListaCliente()
        {
            cbTipoListaCliente.ValueMember = "IDTipoListaCliente";
            cbTipoListaCliente.DisplayMember = "Nombre";
            cbTipoListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
        }
        private void CargarTipoCliente()
        {
            cbTipoCliente.ValueMember = "IDTipoListaCliente";
            cbTipoCliente.DisplayMember = "Nombre";
            cbTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validar los datos
            if (!ValidarDatos())
            {
                return;

            }
            //datos de control al objeto
            ClientesEntity oCliente = new ClientesEntity();
            oCliente.IDCliente = int.Parse(txtidcliente.Text);
            oCliente.IDUsuario = (int)cbUsuario.SelectedValue;
            oCliente.IDMembresia = (int)cbMembresia.SelectedValue;
            oCliente.TipoListaCliente = (int)cbTipoListaCliente.SelectedValue;
            oCliente.TipoCliente = (int)cbTipoCliente.SelectedValue;
            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.TipoDocumento = cbTipoDocumento.Text;
            oCliente.Documento = txtDocumento.Text;
            oCliente.TelCell = txtTelCell.Text;
            oCliente.TelRes = txtTelRes.Text;
            oCliente.FechaRegistro = DateTime.Parse(dtpFechaRegistro.Text);

            // guardar base datos
            try
            {
                ClientesBLL.guardar(oCliente);
                MessageBox.Show("Cliente Guardado", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(cbUsuario.Text))
            {
                errorProvider.SetError(txtNombre, "El Usuario es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(cbMembresia.Text))
            {
                errorProvider.SetError(cbMembresia, "La Membresia es obligatori");
                resultado = false;
            }
            decimal valor;

            if (string.IsNullOrEmpty(cbTipoListaCliente.Text))
            {
                errorProvider.SetError(cbTipoListaCliente, "Obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(cbTipoCliente.Text))
            {
                errorProvider.SetError(cbTipoCliente, "El TipoCliente es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El Nombre es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "El Apellido es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(dtpFechaRegistro.Text))
            {
                errorProvider.SetError(dtpFechaRegistro, "La Fecha es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(cbEstatus.Text))
            {
                errorProvider.SetError(cbEstatus, "El Estatus es obligatorio");
                resultado = false;
            }

            return resultado;
        }


        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }

            DataGridViewRow row = dgvCliente.CurrentRow;
            txtidcliente.Text = row.Cells["IDCliente"].Value?.ToString();
            cbUsuario.Text = row.Cells["IDUsuario"].Value?.ToString();
            cbMembresia.Text = row.Cells["IDMembresia"].Value?.ToString();
            cbTipoListaCliente.Text = row.Cells["IDTipoListaCliente"].Value?.ToString();
            cbTipoCliente.Text = row.Cells["IDTipoCliente"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = row.Cells["Apellido"].Value?.ToString();
            cbTipoDocumento.Text = row.Cells["TipoDocumento"].Value?.ToString();
            txtDocumento.Text = row.Cells["Documento"].Value?.ToString();
            txtDireccion.Text = row.Cells["Direccion"].Value?.ToString();
            txtTelCell.Text = row.Cells["TelCell"].Value?.ToString();
            txtTelRes.Text = row.Cells["TelRes"].Value?.ToString();
            dtpFechaRegistro.Text = row.Cells["FechaRegistro"].Value?.ToString();
            cbEstatus.Text = row.Cells["Estatus"].Value?.ToString();

        }
    }

}

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
    public partial class frmUsuario : Form
    {
        const string sistema = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            InicializarControles();

        }

        private void CargarRol()
        {
            cbRol.ValueMember = "IDRol";
            cbRol.DisplayMember = "Nombre";
            cbRol.DataSource = RolBLL.MostrarRol();
        }
        private void InicializarControles()
        {
            txtIDUsuario.Text = "0";
            cbRol.Text = "";
            TxbIDEmpleado.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtSexo.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
            txtDireccion.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            CargarRol();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbtnNO.Checked)
            {
                //validar los datos
                if (!ValidarDatos())
                {
                    return;

                }
                //datos de control al objeto
                UsuarioEntity oUsuario = new UsuarioEntity("", "");
                oUsuario.IDUsuario = int.Parse(txtIDUsuario.Text);
                oUsuario.IDRol = (int)cbRol.SelectedValue;
                oUsuario.Nombre = txtNombre.Text;
                oUsuario.Apellido = txtApellido.Text;
                oUsuario.Sexo = txtSexo.Text;
                oUsuario.Correo = txtCorreo.Text;
                oUsuario.Direccion = txtDireccion.Text;
                oUsuario.FechaRegistro = DateTime.Now;
                oUsuario.NombreUsuario = txtNombreUsuario.Text;
                oUsuario.Contrasena = txtContrasena.Text;
                oUsuario.Estatus = "Activo";
                // guardar base datos
                try
                {
                    UsuarioBLL.GuardarNoEmpleado(oUsuario);
                    MessageBox.Show("Usuario Guardado con Éxito", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarControles();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Usuario. \n\nDetalles a continuacion:\n\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Usuario. \n\nDetalles a continuacion:\n\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rbtnSI.Checked)
            {
                //validar los datos
                if (!ValidarDatos())
                {
                    return;

                }
                //datos de control al objeto
                UsuarioEntity oUsuario = new UsuarioEntity("", "");
                oUsuario.IDUsuario = int.Parse(txtIDUsuario.Text);
                oUsuario.IDEmpleado = int.Parse(TxbIDEmpleado.Text);
                oUsuario.IDRol = (int)cbRol.SelectedValue;
                oUsuario.Nombre = txtNombre.Text;
                oUsuario.Apellido = txtApellido.Text;
                oUsuario.Sexo = txtSexo.Text;
                oUsuario.Correo = txtCorreo.Text;
                oUsuario.Direccion = txtDireccion.Text;
                oUsuario.FechaRegistro = DateTime.Now;
                oUsuario.NombreUsuario = txtNombreUsuario.Text;
                oUsuario.Contrasena = txtContrasena.Text;
                oUsuario.Estatus = "Activo";
                // guardar base datos
                try
                {
                    UsuarioBLL.Guardar(oUsuario);
                    MessageBox.Show("Usuario Guardado", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicializarControles();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Usuario. \n\nDetalles a continuacion:\n\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Usuario. \n\nDetalles a continuacion:\n\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(cbRol.Text))
            {
                errorProvider.SetError(cbRol, "El Rol es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El Nombre es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProvider.SetError(txtApellido, "El Apellido es Obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorProvider.SetError(txtDireccion, "La Direccion es obligatorio");
                resultado = false;
            }

            return resultado;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listaEmpleados empleadoLista = new listaEmpleados();

            if (empleadoLista.ShowDialog() == DialogResult.OK)
            {
                EmpleadoEntity oEmpleados = EmpleadoBLL.GetByID(empleadoLista.IdEmpleado);

                if (oEmpleados != null)
                {
                    this.TxbIDEmpleado.Text = oEmpleados.IDEmpleado.ToString();
                    this.txtNombre.Text = oEmpleados.Nombre.ToString();
                    this.txtApellido.Text = oEmpleados.Apellido.ToString();
                    this.txtDireccion.Text = oEmpleados.Direccion.ToString();
                }
                else
                {
                    MessageBox.Show("Empleado No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbtnSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSI.Checked)
            {
                txtNombre.Enabled = false;
                txtNombre.ReadOnly = true;

                txtApellido.Enabled = false;
                txtApellido.ReadOnly = true;

                txtDireccion.Enabled = false;
                txtDireccion.ReadOnly = true;

                btnSearch.Enabled = true;
                btnNuevoEmpleado.Enabled = true;
            }
        }

        private void rbtnNO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNO.Checked)
            {
                txtNombre.Enabled = true;
                txtNombre.ReadOnly = false;

                txtApellido.Enabled = true;
                txtApellido.ReadOnly = false;

                txtDireccion.Enabled = true;
                txtDireccion.ReadOnly = false;

                btnSearch.Enabled = false;
                btnNuevoEmpleado.Enabled = false;
            }
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            registrarEmpleados nuevoEmpleado = new registrarEmpleados();
            nuevoEmpleado.Show();
        }
    }

}


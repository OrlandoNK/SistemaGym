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
    public partial class nuevoCliente : Form
    {
        public nuevoCliente()
        {
            InitializeComponent();
        }
        const string sistema = "Sistema Gestion Gimnasion (COMFORT GYM) dice:";
        private void nuevoCliente_Load(object sender, EventArgs e)
        {
            CargarUsuario();
            cbUsuario.SelectedValue = gestioUsuarioEntities.IDUserLogged;
            CargarMembresia();
            CargarTipoCliente();
            CargarTipoListaCliente();
        }

        
        private void CargarUsuario()
        {
            cbUsuario.DataSource = UsuarioBLL.Mostrar();
            cbUsuario.ValueMember = "IDUsuario";
            cbUsuario.DisplayMember = "Nombre";
        }
        

        private void CargarTipoListaCliente()
        {
            cbTipoListaCliente.ValueMember = "IDTipoListaCliente";
            cbTipoListaCliente.DisplayMember = "Nombre";
            cbTipoListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
        }

        private void CargarTipoCliente()
        {
            cbTipoCliente.ValueMember = "IDTipoCliente";
            cbTipoCliente.DisplayMember = "Nombre";
            cbTipoCliente.DataSource = TipoClienteBLL.MostrarTipoCliente();
        }

        private void CargarMembresia()
        {
            cbMembresia.ValueMember = "IDMembresia";
            cbMembresia.DisplayMember = "Nombre";
            cbMembresia.DataSource = MembresiaBLL.Mostrar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
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
            oCliente.IDUsuario = Convert.ToInt32(cbUsuario.Text);
            oCliente.IDMembresia = (int)cbMembresia.SelectedValue;
            oCliente.TipoListaCliente = (int)cbTipoListaCliente.SelectedValue;
            oCliente.TipoCliente = (int)cbTipoCliente.SelectedValue;
            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.TipoDocumento = cbTipoDocumento.Text;
            oCliente.Documento = txtDocumento.Text;
            oCliente.Direccion = txtDireccion.Text;
            oCliente.TelCell = txtTelCell.Text;
            oCliente.TelRes = txtTelRes.Text;
            oCliente.FechaRegistro = DateTime.Now;

            if (chEstatus.Checked)
            {
                oCliente.Estatus = "Activo";
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("¿Seguro que desea Guardar el Cliente como Inactivo?", sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    oCliente.Estatus = "Inactivo";
                }
                if (dialogResult == DialogResult.No)
                {

                }
            }

            // guardar base datos
            try
            {
                ClientesBLL.guardar(oCliente);
                MessageBox.Show("Cliente Guardado de Manera Satisfactoria", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Cliente. \nDetalles a Continuacion\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Guardar el Cliente. \nDetalles a Continuacion\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos

            if (string.IsNullOrEmpty(cbMembresia.Text))
            {
                errorProvider.SetError(cbMembresia, "La Membresia es obligatoria");
                resultado = false;
            }

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

            return resultado;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            cbMembresia.SelectedIndex = -1;
            cbTipoCliente.SelectedIndex = -1;
            cbTipoDocumento.SelectedIndex = -1;
            cbTipoListaCliente.SelectedIndex = -1;
            txtDireccion.Clear();
            txtTelCell.Clear();
            txtTelRes.Clear();
        }

    }
}

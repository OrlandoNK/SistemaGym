﻿using SistemaGym.BLL;
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
    public partial class frmUsuario : Form
    {
        const string sistema = "Sistema Gym";
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

            var colRol = (DataGridViewComboBoxColumn)dgvUsuario.Columns["Rol"];
            colRol.ValueMember = "IDRol";
            colRol.DisplayMember = "Nombre";
            colRol.DataPropertyName = "IDRol";
            colRol.DataSource = RolBLL.MostrarRol();

        }
        private void InicializarControles()
        {
            txtIDUsuario.Text = "0";
            cbRol.Text = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtSexo.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
            txtDireccion.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            cbEstatus.Text = "";
            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.DataSource = UsuarioBLL.Mostrar();
            CargarRol();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }

            DataGridViewRow row = dgvUsuario.CurrentRow;
            txtIDUsuario.Text = row.Cells["IDUsuario"].Value?.ToString();
            cbRol.Text = row.Cells["Rol"].EditedFormattedValue.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = row.Cells["Apellido"].Value?.ToString();
            txtSexo.Text = row.Cells["Sexo"].Value?.ToString();
            txtCorreo.Text = row.Cells["Correo"].Value?.ToString();
            txtDireccion.Text = row.Cells["Direccion"].Value?.ToString();
            dtpFechaRegistro.Text = row.Cells["FechaRegistro"].Value?.ToString();
            txtNombreUsuario.Text = row.Cells["NombreUsuario"].Value?.ToString();
            txtContrasena.Text = row.Cells["Contrasena"].Value?.ToString();
            cbEstatus.Text = row.Cells["Estatus"].Value?.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //validar los datos
            if (!ValidarDatos())
            {
                return;

            }
            //datos de control al objeto
            UsuarioEntity oUsuario = new UsuarioEntity("","");
            oUsuario.IDUsuario = int.Parse(txtIDUsuario.Text);
            oUsuario.IDRol = (int)cbRol.SelectedValue;
            oUsuario.Nombre = txtNombre.Text;
            oUsuario.Apellido = txtApellido.Text;
            oUsuario.Sexo = txtSexo.Text;
            oUsuario.Correo = txtCorreo.Text;
            oUsuario.Direccion = txtDireccion.Text;
            oUsuario.FechaRegistro = DateTime.Parse(dtpFechaRegistro.Text);
            oUsuario.NombreUsuario = txtNombreUsuario.Text;
            oUsuario.Contrasena = txtContrasena.Text;
            oUsuario.Estatus = cbEstatus.Text;
            // guardar base datos
            try
            {
                UsuarioBLL.Guardar(oUsuario);
                MessageBox.Show("Usuario Guardado", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(dtpFechaRegistro.Text))
            {
                errorProvider.SetError(txtNombre, "La Fecha es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(cbEstatus.Text))
            {
                errorProvider.SetError(cbEstatus, "El Estatus es obligatorio");
                resultado = false;
            }

            return resultado;
        }

    }
   
    }


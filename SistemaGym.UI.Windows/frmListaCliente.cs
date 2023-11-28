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
    public partial class frmListaCliente : Form
    {
        const string sistema = "Sistema Gym";
        public frmListaCliente()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtID.Text = "0";
            txtNombre.Clear();
            txtDescripcion.Clear();
            dgvListaCliente.AutoGenerateColumns = false;
            dgvListaCliente.DataSource = TipoListaClienteBLL.MostrarTipoListaCliente();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //validacion de datos
            if (!ValidarDatos())
            {
                return;
            }
            //pasar datos de controles a un objeto
            TipoListaClienteEntity ListaCliente = new TipoListaClienteEntity();
            ListaCliente.IDTipoListaCliente = int.Parse(txtID.Text);
            ListaCliente.Nombre = txtNombre.Text;
            ListaCliente.Descripcion = txtDescripcion.Text;

            //Mandar a guardar el objeto creado a la base de datos
            try
            {
                TipoListaClienteBLL.Guardar();
                MessageBox.Show("TipoListaCliente guarda.", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider1.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "El valor no es obligatorio");
                resultado = false;
            }

            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;

            }

            DataGridViewRow row = dgvListaCliente.CurrentRow;
            txtID.Text = row.Cells["IDListaCliente"].Value?.ToString();
            txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
            txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();
        }
    }
}


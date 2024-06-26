﻿using SistemaGym.BLL;
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
    public partial class registrarMembresia : Form
    {

        string SYSTEM_TITLE = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        MembresiaBLL membresiaBLL = new MembresiaBLL();

        public registrarMembresia()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            string CampoObligatorio = "Este Campo es Obligatorio";
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider.Clear();
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, CampoObligatorio);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                errorProvider.SetError(txtValor, CampoObligatorio);
                resultado = false;
            }

            decimal valor;
            if (!decimal.TryParse(txtValor.Text, out valor))
            {
                errorProvider.SetError(txtValor, "Ingrese un valor decimal válido");
                resultado = false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider.SetError(txtDescripcion, CampoObligatorio);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDuracion.Text))
            {
                errorProvider.SetError(txtDuracion, CampoObligatorio);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtCantidadPersonas.Text))
            {
                errorProvider.SetError(txtCantidadPersonas, CampoObligatorio);
                resultado = false;
            }

            return resultado;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //validacion de datos
            if (!ValidarDatos())
            {
                return;
            }
            //pasar datos de controles a un objeto
            MembresiaEntity oMembresia = new MembresiaEntity();
            oMembresia.Nombre = txtNombre.Text;
            oMembresia.Descripcion = txtDescripcion.Text;
            oMembresia.Duracion = Convert.ToInt32(txtDuracion.Text);
            oMembresia.Valor = Decimal.Parse(txtValor.Text);
            oMembresia.FechaCreacion = DateTime.Now;
            oMembresia.CantidadPersonas = Convert.ToInt32(txtCantidadPersonas.Text);
            oMembresia.Estatus = "Activo";


            //Mandar a guardar el objeto creado a la base de datos
            try
            {
                MembresiaBLL.Insertar(oMembresia);
                MessageBox.Show("¡La Membresia Ha Sido Guardada con Exito!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Registrar la Membresia. \nDetalles a continuación\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Registrar la Mambresia. \nDetalles a continuación\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtDuracion.Clear();
            txtValor.Clear();
            txtCantidadPersonas.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

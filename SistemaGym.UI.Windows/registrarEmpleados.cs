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
    public partial class registrarEmpleados : Form
    {
        public registrarEmpleados()
        {
            InitializeComponent();
        }

        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        EmpleadoBLL empleadoBLL = new EmpleadoBLL();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarCampos()
        {

            bool validation = true;
            string CampoObligatorio = "¡Este Campo es Obligatorio!";

            if (TxbDocumento.Text == "   -       -")
            {
                errorProvider.SetError(TxbDocumento, CampoObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbNombre.Text))
            {
                errorProvider.SetError(TxbNombre, CampoObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbApellido.Text))
            {
                errorProvider.SetError(TxbApellido, CampoObligatorio);
                validation = false;
            }
            if (string.IsNullOrEmpty(TxbDireccion.Text))
            {
                errorProvider.SetError(TxbDireccion, CampoObligatorio);
                validation = false;
            }
            if (cbTipoDocumento.SelectedIndex == -1)
            {
                errorProvider.SetError(cbTipoDocumento, "Seleccione un Tipo de Documento Válido");
                validation = false;
            }
            if (TxbTellCell.Text == "(   )-   -")
            {
                errorProvider.SetError(TxbTellCell, CampoObligatorio);
                validation = false;
            }
            if (TxbTelRes.Text == "(   )-   -")
            {
                errorProvider.SetError(TxbTelRes, CampoObligatorio);
                validation = false;
            }


            return validation;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool CamposValidados = ValidarCampos();

            EmpleadoEntity nuevoEmpleado = new EmpleadoEntity();

            nuevoEmpleado.Nombre = TxbNombre.Text;
            nuevoEmpleado.Apellido = TxbApellido.Text;
            nuevoEmpleado.TipoDocumento = Convert.ToString(cbTipoDocumento.SelectedItem);
            nuevoEmpleado.Documento = TxbDocumento.Text;
            nuevoEmpleado.Direccion = TxbDireccion.Text;
            nuevoEmpleado.TellCell = TxbTellCell.Text;
            nuevoEmpleado.TelRes = TxbTelRes.Text;
            nuevoEmpleado.FechaRegistro = DateTime.Now;
            if (chEstatus.Checked)
            {
                nuevoEmpleado.Estatus = "Activo";
            }
            else
            {
                DialogResult dialogResults = new DialogResult();
                dialogResults = MessageBox.Show("¿Seguro que desea Registrar el Empleado como Inactivo?", SYSTEM_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResults == DialogResult.Yes)
                {
                    nuevoEmpleado.Estatus = "Inactivo";
                }
                if (dialogResults == DialogResult.No)
                {

                }
            }

            try
            {
                if (CamposValidados)
                {
                    EmpleadoBLL.Create(nuevoEmpleado);
                    MessageBox.Show("¡Empleado Registrado de Manera Satisfactoria!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Registrar el Empleado. \nDetalles A Continuación\n " + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se Ha Producido un Error al Intentar Registrar el Empleado. \nDetalles A Continuación\n " + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            TxbNombre.Clear();
            TxbApellido.Clear();
            TxbDocumento.Clear();
            cbTipoDocumento.SelectedIndex = -1;
            TxbTellCell.Clear();
            TxbTelRes.Clear();
            TxbDireccion.Clear();
            chEstatus.Checked = false;
        }

    }
}

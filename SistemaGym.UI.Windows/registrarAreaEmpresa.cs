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
    public partial class registrarAreaEmpresa : Form
    {
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice";
        public registrarAreaEmpresa()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarCampos()
        {
            string CampoObligatorio = "¡Este Campo es Obligatorio!";
            string EncargadoObligatorio = "¡Debe Agregar el Encargado!";
            bool validacion = true;
            ErrorProvider.Clear();

            if (string.IsNullOrEmpty(txbNombreArea.Text))
            {
                ErrorProvider.SetError(txbNombreArea, CampoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(txbDescripcion.Text))
            {
                ErrorProvider.SetError(txbDescripcion, CampoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(txbEncargado.Text))
            {
                ErrorProvider.SetError(txbEncargado, EncargadoObligatorio);
                validacion = false;
            }
            int encargado;
            if (!int.TryParse(txbEncargado.Text, out encargado))
            {
                ErrorProvider.SetError(txbEncargado, EncargadoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(txbNombre.Text))
            {
                ErrorProvider.SetError(txbNombre, CampoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(txbApellido.Text))
            {
                ErrorProvider.SetError(txbApellido, CampoObligatorio);
                validacion = false;
            }


            return validacion;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            AreaEmpresaEntity nuevaAreaEmpresa = new AreaEmpresaEntity();
            AreaEmpresaBLL areaEmpresaBLL = new AreaEmpresaBLL();

            nuevaAreaEmpresa.Encargado = Convert.ToInt32(txbEncargado.Text);
            nuevaAreaEmpresa.Nombre = txbNombreArea.Text;
            nuevaAreaEmpresa.Descripcion = txbDescripcion.Text;
            nuevaAreaEmpresa.FechaRegistro = DateTime.Now;

            try
            {
                areaEmpresaBLL.Insertar(nuevaAreaEmpresa);
                MessageBox.Show("¡Area de la Empresa Guardada de Manera Satisfactoria!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Area de Empresa:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Area de Empresa:\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimpiarCampos()
        {
            txbEncargado.Clear();
            txbNombre.Clear();
            txbNombreArea.Clear();
            txbApellido.Clear();
            txbDescripcion.Clear();
        }

        private void btnBuscarEncargado_Click(object sender, EventArgs e)
        {
            listaEmpleados empleadoLista = new listaEmpleados();

            if (empleadoLista.ShowDialog() == DialogResult.OK)
            {
                EmpleadoEntity oEmpleados = EmpleadoBLL.GetByID(empleadoLista.IdEmpleado);

                if (oEmpleados != null)
                {
                    this.txbEncargado.Text = oEmpleados.IDEmpleado.ToString();
                    this.txbNombre.Text = oEmpleados.Nombre.ToString();
                    this.txbApellido.Text = oEmpleados.Apellido.ToString();
                }
                else
                {
                    MessageBox.Show("Empleado No Encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
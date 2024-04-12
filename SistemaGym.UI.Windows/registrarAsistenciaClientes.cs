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
    public partial class registrarAsistenciaClientes : Form
    {
        public registrarAsistenciaClientes()
        {
            InitializeComponent();
        }
        private string SYSTEM_TITLE = "Sistema Gestión Gimnasio (COMFORT GYM) dice:";
        private void btnBuscarIDCliente_Click(object sender, EventArgs e)
        {
            listaClientes listaClientes = new listaClientes();

            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                ClientesEntity oCliente = ClientesBLL.GetById((int)listaClientes.IdCliente);

                if (oCliente != null)
                {
                    this.TxbIDCliente.Text = oCliente.IDCliente.ToString();
                    this.TxbNombreCliente.Text = oCliente.Nombre.ToString();
                    this.TxbApellidoCliente.Text = oCliente.Apellido.ToString();
                    this.TxbTipoDocumento.Text = oCliente.TipoDocumento.ToString();
                    this.TxbDocumentoCliente.Text = oCliente.Documento.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente No Encontrado", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            errorProvider.Clear();
            bool validacion = true;

            string CampoObligatorio = "¡El Cliente es Obligatorio, Debe Agregarlo!";

            if (string.IsNullOrEmpty(TxbIDCliente.Text))
            {
                errorProvider.SetError(TxbIDCliente, CampoObligatorio);
                validacion = false;
            }
            int IDCliente;
            if (!int.TryParse(TxbIDCliente.Text, out IDCliente))
            {
                errorProvider.SetError(TxbIDCliente, CampoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbNombreCliente.Text))
            {
                errorProvider.SetError(TxbNombreCliente, CampoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbApellidoCliente.Text))
            {
                errorProvider.SetError(TxbApellidoCliente, CampoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbTipoDocumento.Text))
            {
                errorProvider.SetError(TxbTipoDocumento, CampoObligatorio);
                validacion = false;
            }
            if (string.IsNullOrEmpty(TxbDocumentoCliente.Text))
            {
                errorProvider.SetError(TxbDocumentoCliente, CampoObligatorio);
                validacion = false;
            }


            return validacion;
        }

        private void btnAssistanceSave_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos())
            {

                return;
            }

            AsistenciaClientesEntity nuevaAsistenciaCliente = new AsistenciaClientesEntity();
            AsistenciaClientesBLL asistenciaClientesBLL = new AsistenciaClientesBLL();

            nuevaAsistenciaCliente.IDCliente = Convert.ToInt32(TxbIDCliente.Text);
            if (rbtnAsistio.Checked)
            {
                nuevaAsistenciaCliente.Asistencia = true;
            }
            else
            {
                nuevaAsistenciaCliente.Asistencia = false;
            }
            nuevaAsistenciaCliente.FechaAsistencia = DateTime.Now;

            try
            {
                AsistenciaClientesBLL.Guardar(nuevaAsistenciaCliente);
                MessageBox.Show("¡Asistencia Guardada de Manera Satisfactoria!", SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Se ha Producido un Error al Intentar Guardar la Asistencia:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Se ha Producido un Error al Intentar Guardar la Asistencia:\n\n" + ex.Message, SYSTEM_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            TxbIDCliente.Clear();
            TxbNombreCliente.Clear();
            TxbApellidoCliente.Clear();
            TxbTipoDocumento.Clear();
            TxbDocumentoCliente.Clear();
            rbtnAsistio.Checked = false;
        }
    }
}

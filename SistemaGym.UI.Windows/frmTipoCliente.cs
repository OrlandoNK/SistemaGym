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
    public partial class frmTipoCliente : Form
    {
        const string sistema = "Sistema Gestion Gimnasio (COMFORT GYM) dice";
        public frmTipoCliente()
        {
            InitializeComponent();
        }

        private void frmTipoCliente_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("¿Desea crear un Nuevo Tipo de Cliente?", sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                InicializarControles();
            }
            if (dialogResult == DialogResult.No)
            {

            }

        }
        private void InicializarControles()
        {
            txtID.Text = "0";
            txtNombre.Clear();
            txtDescripcion.Clear();
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
            TipoClienteEntity TipoCliente = new TipoClienteEntity();
            TipoCliente.IDTipoCliente = int.Parse(txtID.Text);
            TipoCliente.Nombre = txtNombre.Text;
            TipoCliente.Descripcion = txtDescripcion.Text;
            TipoCliente.FechaCreacion = DateTime.Now;

            //Mandar a guardar el objeto creado a la base de datos
            try
            {
                TipoClienteBLL.Guardar(TipoCliente);
                MessageBox.Show("¡El Tipo de Cliente ha sido Guardado de Manera Satisfactoria!", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Tipo de Cliente:\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un Error al Intentar Guardar el Tipo de Cliente:\n" + ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //inicializando los mensajes de validaciones
            errorProvider1.Clear();
            string CampoObligatorio = "¡Este Campo es Obligatorio!";
            //verificar que en los campos obligatorios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, CampoObligatorio);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, CampoObligatorio);
                resultado = false;
            }

            return resultado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using SistemaGym.BLL;
using SistemaGym.DAL;
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
    public partial class frmTipoListaCliente : Form
    {
        private string sistema = "Sistema Gym";
        public frmTipoListaCliente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            txtID.Text = "0";
            txtNombre.Clear();
            txtDescripcion.Clear();
            dgvTipoListaCliente.AutoGenerateColumns = false;
            dgvTipoListaCliente.DataSource = AreaEmpresaBLL.Mostrar();
            txtNombre.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validacion de datos
            if (!ValidarDatos())
            {
                return;
            }
            //Pasar datos al objeto desde los controles
            TipoListaClienteEntity tipoListaCliente = new TipoListaClienteEntity();
            tipoListaCliente.IDTipoListaCliente = int.Parse(txtID.Text);
            tipoListaCliente.Nombre = txtNombre.Text;
            tipoListaCliente.Descripcion = txtDescripcion.Text;

            try
            {
                TipoClienteBLL.Guardar(tipoListaCliente);
                MessageBox.Show("Tipo Lista Cliente se guardo.", sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicializarControles();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private bool ValidarDatos()
        {
            bool resultado = true;
            //Inicializar los mensajes
            errorProvider1.Clear();
            //Asegurarse que en los capos obligatoios hayan datos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Campo obligatorio");
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorProvider1.SetError(txtDescripcion, "Campo obligatorio");
                resultado = false;
            }

            return resultado;
        }

    }
}


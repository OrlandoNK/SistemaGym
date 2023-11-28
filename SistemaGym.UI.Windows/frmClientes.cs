using SistemaGym.BLL;
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
    public partial class frmClientes : Form
    {
        ClientesBLL clientesBLL = new ClientesBLL();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
        private void InicializarControles()
        {
            txtidcliente.Text = "0";
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtDireccion.Clear();
            txtTelCell.Clear();
            txtTelRes.Clear();

        }
        private void CargarUsuarios()
        {
            cbUsuario.ValueMember = "IDCliente";
            cbUsuario.DisplayMember = "NombreUsuario";
        }
    }
}

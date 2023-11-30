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
    public partial class frmUsuario : Form
    {
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
           
        }
    }
}

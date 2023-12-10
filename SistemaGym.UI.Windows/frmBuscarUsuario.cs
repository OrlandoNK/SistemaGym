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
    public partial class frmBuscarUsuario : Form
    {
        private int idUsuario;
        public frmBuscarUsuario()
        {
            InitializeComponent();
        }
        public int id
        {

            get { return idUsuario; }
            set { }

        }
        public void CargarRol()
        {
            var colRol = (DataGridViewComboBoxColumn)dgvBuscarUsuarios.Columns["IDRol"];
            colRol.DataPropertyName = "IDRol";
            colRol.DataSource = RolBLL.MostrarRol();
            colRol.ValueMember = "IDRol";
            colRol.DisplayMember = "Nombre";
        }

        private void frmBuscarUsuario_Load(object sender, EventArgs e)
        {
            dgvBuscarUsuarios.AutoGenerateColumns = false;
            dgvBuscarUsuarios.DataSource = UsuarioBLL.Mostrar();
            CargarRol();
        }
    }
}
